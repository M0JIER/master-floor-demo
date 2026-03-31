using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace MasterFloorDB.Entities
{
    public class DBFuncs
    {
        private static string connectionString = "Data Source = base.db";

        public DBFuncs()
        {
            CreateTable();
        }

        private void CreateTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sqlItems =
                @"CREATE TABLE IF NOT EXISTS Items(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                CollectionId INTEGER,
                Name TEXT,
                Year INTEGER,
                ConditionId INTEGER,
                RareId INTEGER,
                StoragePlace TEXT,
                Value REAL,
                StatusID INTEGER,
                FOREIGN KEY (CollectionId) REFERENCES Collections(Id),
                FOREIGN KEY (ConditionId) REFERENCES Conditions(Id),
                FOREIGN KEY (RareId) REFERENCES Rares(Id),
                FOREIGN KEY (StatusId) REFERENCES Status(Id)
                );

                CREATE TABLE IF NOT EXISTS Collections(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT UNIQUE);
                insert or ignore into Collections(Name) values (""Монеты""), (""Виниловые пластинки""), (""Значки""), (""Марки"");


                CREATE TABLE IF NOT EXISTS Conditions(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT UNIQUE);
                insert or ignore into Conditions(Name) values (""Ужасное""), (""Нормальное""), (""Отличное"");


                CREATE TABLE IF NOT EXISTS Rares(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT UNIQUE);
                insert or ignore into Rares(Name) values (""Обычное""), (""Необычное""), (""Редкое""), 
                                                            (""Эпическое""), (""Мифическое""), (""Легендарное"");

        
                CREATE TABLE IF NOT EXISTS Status(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT UNIQUE);
                insert or ignore into Status (Name) values (""Выставлено на продажу""), (""Подлежит обмену""), (""Требует реставрации""); 


                create view if not exists itemsView as
                select 
                i.Id as Id,
                i.name as ""Название"",
                col.Name as ""Коллекция"",
                i.Year as ""Год"",
                con.Name as ""Состояние"",
                r.Name as ""Редкость"",
                i.StoragePlace as ""Место хранения"",
                s.name as ""Статус"",
                i.Value as ""Стоимость""
                from Items i
                join Collections col on col.Id = i.CollectionId
                join Conditions con on con.Id = i.ConditionId
                join Status s on s.Id = i.StatusID
                join Rares r on r.Id = i.RareId";

                
                SQLiteCommand cmd = new SQLiteCommand(sqlItems, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAll()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                SQLiteDataAdapter adapter =
                    new SQLiteDataAdapter("SELECT * FROM itemsView", conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public static List<Collections> GetCollsList()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                List<Collections> colls = new List<Collections>();

                var cmd = new SQLiteCommand("Select * from Collections", conn);
                using (cmd)
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        colls.Add(new Collections()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
                    return colls;
            }
        }
        public static DataTable GetData(string data)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                DataTable table = new DataTable();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter($"Select * from {data}", conn);
                adapter.Fill(table);
                return table;
            }
        }

        public static bool UpdateItemsData(string table,
            int id, string name, int colId, int? year, int condId, int rareId, string place, int statusId, int? value )
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string com =
                    $@"
                    update {table}
                    set 
                    name = @name,
                    CollectionId = @colId,
                    Year = @year,
                    ConditionId = @condId,
                    RareId = @rareId ,
                    StoragePlace = @place,
                    Value = @value,
                    StatusId = @statusId
                    where id = @id
                    ";
                var cmd = new SQLiteCommand(com, conn);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@colId", colId);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@condId", condId);
                cmd.Parameters.AddWithValue("@rareId", rareId);
                cmd.Parameters.AddWithValue("@place", place);
                cmd.Parameters.AddWithValue("@value", value);
                cmd.Parameters.AddWithValue("@statusId", statusId);
                cmd.Parameters.AddWithValue("@id", id);

                foreach (SQLiteParameter par in cmd.Parameters)
                {
                    if (par == null || par.Value.ToString() == "")
                    {
                        MessageBox.Show("Заполнены не все столбцы");
                        return false;
                    }

                }

                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public static bool UpdateData(string table, string name, int Id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                
                if(name == null || name=="")
                {
                    MessageBox.Show("Пожалуйста, заполните столбец");
                    return false;
                }

                var cmd = new SQLiteCommand($@"update {table} set Name = ""{name}"" where Id = {Id}", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public static void DeleteData(string table, int Id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var cmd = new SQLiteCommand($"delete from {table} where Id = {Id}", connection);
                cmd.ExecuteNonQuery();
            }
        }


        public static List<Conditions> GetConditionsList()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                List<Conditions> conds = new List<Conditions>();

                var reader = new SQLiteCommand("select * from Conditions", connection).ExecuteReader();
                while(reader.Read())
                {
                    conds.Add(new Conditions()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
                return conds;
            }
        }

        public static List<Rares> GetRaresList()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                List<Rares> rare = new List<Rares>();

                var reader = new SQLiteCommand("select * from Rares", connection).ExecuteReader();
                while (reader.Read())
                {
                    rare.Add(new Rares()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
                return rare;
            }
        }


        public static List<Status> GetStatusList()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                List<Status> statuses = new List<Status>();

                var reader = new SQLiteCommand("Select * from Status", connection).ExecuteReader();
                while (reader.Read())
                {
                    statuses.Add(new Status() 
                    { 
                        Id = reader.GetInt32(0), 
                        Name = reader.GetString(1)
                    });
                }
                return statuses;

            }
        }



        public static bool Add(Items item)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sql =
                @"INSERT INTO Items
            (CollectionId,Name,Year,ConditionId,RareId,StoragePlace,Value,StatusId)
            VALUES(@type,@name,@year,@cond,@rare,@place,@value,@status)";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@type", item.CollectionType.Id);
                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@year", item.Year);
                cmd.Parameters.AddWithValue("@cond", item.Condition.Id);
                cmd.Parameters.AddWithValue("@rare", item.Rare.Id);
                cmd.Parameters.AddWithValue("@place", item.StoragePlace);
                cmd.Parameters.AddWithValue("@value", item.Price);
                cmd.Parameters.AddWithValue("@status", item.Status.Id);

                foreach (SQLiteParameter par in  cmd.Parameters)
                {
                    if (par == null || par.Value.ToString() == "")
                    {
                        MessageBox.Show("Заполнены не все столбцы");
                        return false;
                    }

                }

                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public static bool AddDataInBase(string table, string name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                if (name == null || name == "")
                {
                    MessageBox.Show("Пожалуйста, заполните столбец");
                    return false;
                }

                var cmd = new SQLiteCommand($@"insert into {table}(Name) values(""{name}"")", connection);
                cmd.ExecuteNonQuery();
            }
            return true;
        }



        public DataTable FilterByStatus(string status)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                SQLiteDataAdapter adapter =
                    new SQLiteDataAdapter(
                        "SELECT * FROM Items WHERE Status=@status",
                        conn);

                adapter.SelectCommand.Parameters.AddWithValue("@status", status);

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public DataTable Search(string type, double price)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                SQLiteDataAdapter adapter =
                    new SQLiteDataAdapter(
                    "SELECT * FROM Items WHERE CollectionType=@type AND Value<=@price",
                    conn);

                adapter.SelectCommand.Parameters.AddWithValue("@type", type);
                adapter.SelectCommand.Parameters.AddWithValue("@price", price);

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }
        //public Collections GetCollection(DBFuncs dB, string cellName)
        //{
        //    Collections i = dB.;
        //    var c = from p in i.Name
        //            where p.ToString() == cellName
        //            select p;
        //    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        //    {
        //        string s = "";
        //        string cmd =
        //            @"
        //            SELECT name 
        //            from @tableN
        //            ";
        //        SQLiteCommand command = new SQLiteCommand(cmd, conn);
        //        command.Parameters.AddWithValue("@tableN", tableName);
        //    }
        //    return i;

        //}


    }
}
