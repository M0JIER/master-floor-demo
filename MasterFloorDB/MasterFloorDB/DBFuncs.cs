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

                //insert or ignore into Product_type(Type) values(""Спекулянт""), (""Перекуп""), (""Инвестор""), (""Пенсионер"");


                string sqlItems =
                @"CREATE TABLE if not exists ""Partners"" (
	            ""Id""	INTEGER NOT NULL,
	            ""Name""	TEXT NOT NULL,
	            ""TypeId""	INTEGER NOT NULL,
	            ""Address""	TEXT,
	            ""TIN""	INTEGER,
	            ""DirectorsName""	TEXT NOT NULL,
	            ""Phone""	TEXT NOT NULL,
	            ""Email""	TEXT,
	            ""Rating""	INTEGER NOT NULL,
	            PRIMARY KEY(""Id"" AUTOINCREMENT)
                FOREIGN KEY (TypeId) REFERENCES Product_type(Id)
                );

                create table if not exists partner_type
                (
                Id integer PRIMARY KEY AUTOINCREMENT,
                Name TEXT UNIQUE
                );
                insert or ignore into partner_type (name) VALUES
                (""ЗАО""), (""ООО""), (""ПАО""), (""ОАО"");


                CREATE TABLE if not exists ""Product_type"" (
                	""Id""	INTEGER,
                	""Type""	TEXT UNIQUE,
                	""Ratio""	REAL,
                	PRIMARY KEY(""Id"" AUTOINCREMENT)
                );
                insert or ignore into Product_type (Type, Ratio) values 
                (""Ламинат"", 2.35), (""Массивная доска"", 5.15), (""Паркетная доска"", 4.34), (""Пробковое покрытие"", 1.5);


                CREATE TABLE if not exists ""PartnerProduct"" (
                	""Id""	INTEGER,
                	""ProductId""	INTEGER,
                	""PartnerId""	INTEGER,
                	""NumberOfProd""	INTEGER,
                	""SellDate""	TEXT,
                	PRIMARY KEY(""Id"" AUTOINCREMENT),
                	FOREIGN KEY(""PartnerId"") REFERENCES ""Partners""(""Id""),
                	FOREIGN KEY(""ProductId"") REFERENCES ""Products""(""Id"")
                );




                CREATE TABLE if not exists ""Material_type"" (
                	""Id""	INTEGER,
                	""Type""	TEXT,
                	""DefectPerc""	REAL,
                	PRIMARY KEY(""Id"" AUTOINCREMENT)
                );



                CREATE TABLE if not exists ""Products"" (
                	""Id""	INTEGER,
                	""TypeId""	INTEGER,
                	""Name""	TEXT,
                	""Art""	INTEGER,
                	""MinPrice""	REAL,
                	PRIMARY KEY(""Id"" AUTOINCREMENT),
                    FOREIGN KEY(""TypeId"") REFERENCES ""Product_type""(""Id"")
                );


                create view if not exists partnersView as
                select 
                i.Id as Id,
                t.name as ""Тип"",
                i.name as ""Название"",
                i.DirectorsName as ""Директор"",
                i.Phone as ""Телефон"",
                i.Rating as ""Рейтинг""
                from Partners i
                left join partner_type t on t.Id = i.TypeId;


                CREATE VIEW if not exists ProductsView as
                select 
                p.Id,
                pt.Type as ""Тип"",
                p.name as ""Наименование"",
                p.Art as ""Артикул"",
                p.MinPrice as ""Мин. цена""
                
                FROM Products p
                join Product_type pt on pt.Id = p.TypeId";

                
                SQLiteCommand cmd = new SQLiteCommand(sqlItems, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Items> GetAll()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                SQLiteDataAdapter adapter =
                    new SQLiteDataAdapter("SELECT * FROM itemsView", conn);

                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM partnersView", conn);
                var reader = cmd.ExecuteReader();

                List<Items> items = new List<Items>();
                while (reader.Read())
                {
                    if (reader!=null)
                    {
                        items.Add(new Items()
                        {
                            //Type = new SQLiteCommand($"select Name from Types where Id = {int.Parse(reader.GetString(1))}", conn)
                            //.ExecuteReader().GetString(0),
                            Id = reader.GetInt32(0),
                            Type = new Types() { Name = reader.GetString(1) },
                            Name = reader.GetString(2),
                            Director = reader.GetString(3),
                            Phone = reader.GetString(4),
                            Rating = reader.GetInt16(5)
                        });
                    }
                }

                return items;
            }
        }

        public static List<Types> GetTypesList()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                List<Types> types = new List<Types>();

                var cmd = new SQLiteCommand("Select * from partner_type", conn);
                using (cmd)
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        types.Add(new Types()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
                    return types;
            }
        }

        public static List<ProdTypes> GetProdTypesList()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                List<ProdTypes> prodTypes = new List<ProdTypes>();

                var cmd = new SQLiteCommand("Select * from product_type", conn);
                using (cmd)
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        prodTypes.Add(new ProdTypes()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
                return prodTypes;
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
            int id, string name, int typeId, string director, string phone, int? rating)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string com =
                    $@"
                    update {table}
                    set 
                    Name = @name,
                    TypeId = @typeId,
                    DirectorsName = @director,
                    Phone = @phone,
                    Rating = @rating
                    where id = @id
                    ";
                var cmd = new SQLiteCommand(com, conn);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@typeId", typeId);
                cmd.Parameters.AddWithValue("@director", director);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@rating", rating);

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

        public static bool UpdateMats(string name, decimal percent, int Id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                if (name == null || name == "")
                {
                    MessageBox.Show("Пожалуйста, заполните столбец");
                    return false;
                }

                var cmd = new SQLiteCommand($@"update Material_type set Type = ""{name}"", DefectPerc = @percent  where Id = {Id}", conn);
                cmd.Parameters.AddWithValue("@percent", percent);
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
                while (reader.Read())
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

        public static List<Materials> GetMaterialsList()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                List<Materials> materials = new List<Materials>();

                var reader = new SQLiteCommand("select * from Material_type", connection).ExecuteReader();
                while (reader.Read())
                {
                    materials
                    .Add(new Materials()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
                return materials;
            }
        }


        public static List<Products> GetProductsList()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                List<Products> products = new List<Products>();

                var reader = new SQLiteCommand("Select * from Products", connection).ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Products() 
                    { 
                        Id = reader.GetInt32(0), 
                        TypeId = reader.GetInt32(1),
                        Name = reader.GetString(2),
                        Art = reader.GetInt32(3),
                        MinPrice = reader.GetDecimal(4)
                    });
                }
                return products;

            }
        }



        public static bool Add(Items item)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sql =
                @"INSERT INTO Partners
            (TypeId,Name,DirectorsName,Phone,Rating)
            VALUES(@type,@name,@director,@phone,@rating)";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@type", item.Type.Id);
                cmd.Parameters.AddWithValue("@director", item.Director);
                cmd.Parameters.AddWithValue("@phone", item.Phone);
                cmd.Parameters.AddWithValue("@rating", item.Rating);

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
                return true;
            }
        }

        public static bool AddMatsInBase(string name, decimal percent)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                if (name == null || name == "")
                {
                    MessageBox.Show("Пожалуйста, заполните столбец");
                    return false;
                }

                var cmd = new SQLiteCommand($@"insert into Material_type(Type, DefectPerc) values(""{name}"", @percent)", connection);
                cmd.Parameters.AddWithValue("@percent", percent);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public static bool AddProductsInBase(Products product)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                //if (name == null || name == "")
                //{
                //    MessageBox.Show("Пожалуйста, заполните столбец");
                //    return false;
                //}


                var cmd = new SQLiteCommand($@"
                insert into Products(Name, TypeId, Art, MinPrice)
                values(@name, @type, @art, @price)", connection);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@type", product.TypeId);
                cmd.Parameters.AddWithValue("@art", product.Art);
                cmd.Parameters.AddWithValue("@price", product.MinPrice);

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
        //public Types GetCollection(DBFuncs dB, string cellName)
        //{
        //    Types i = dB.;
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
