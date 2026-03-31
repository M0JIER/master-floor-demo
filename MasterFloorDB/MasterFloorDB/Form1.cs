using MasterFloorDB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.Json;
using System.Security.Cryptography;

namespace MasterFloorDB
{
    public partial class Form1 : Form
    {
        DBFuncs db = new DBFuncs();

        List<Status> statuses;
        List<Conditions> conditions;
        List<Rares> rares;
        List<Collections> collections;

        Control[] baseControls;
        Control[] CreateLine;
        Control[] EditLine;
        Control[] FilterView;

        int varId;
        enum UImode
        {
            Create,
            Edit,
            Filter
        }

        enum selectedTab
        {
            Items,
            Collections,
            Conditions,
            Status,
            Rares
        }


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            assignFuncsToBase();
            LoadData(selectedTab.Items);
            startPresets();

        }
        void LoadData(selectedTab mode)
        {
            switch (mode)
            {
                case selectedTab.Items:
                    dataGridView1.DataSource = DBFuncs.GetAll();
                    break;
                case selectedTab.Collections:
                    dataGridView1.DataSource = DBFuncs.GetData("Collections");
                    break;
                case selectedTab.Conditions:
                    dataGridView1.DataSource = DBFuncs.GetData("Conditions");
                    break;
                case selectedTab.Status:
                    dataGridView1.DataSource = DBFuncs.GetData("Status");
                    break;
                case selectedTab.Rares:
                    dataGridView1.DataSource = DBFuncs.GetData("Rares");
                    break;
            }
        }

        private void startPresets()
        {
            updLists();
            updTags();
            updateUI(UImode.Create);

            foreach (ComboBox cb in baseControls.OfType<ComboBox>())
            {
                cb.SelectedIndex = 0;
            }

            foreach (Control control in itemViewTab.Controls)
            {
                if (control.Tag != null)
                    if (control.Tag.ToString().Contains("CreateLine") || control.Tag.ToString().Contains("base"))
                    {
                        control.Visible = true;
                    }
                    else { control.Visible = false; }
            }
        }

        void updCmb()
        {
            List<string> holder = new List<string>();
            foreach (Collections c in collections)
            {
                holder.Add(c.Name);
            }
            cmbCollection.DataSource = holder;
            //holder.Clear();

            List<string> holder1 = new List<string>();
            foreach (Conditions c in conditions)
            {
                holder1.Add(c.Name);
            }
            cmbCondition.DataSource = holder1;
            //holder1.Clear();

            List<string> holder2 = new List<string>();
            foreach (Rares r in rares)
            {
                holder2.Add(r.Name);
            }
            cmbRare.DataSource = holder2;
            //holder2.Clear();

            List<string> holder3 = new List<string>();
            foreach (Status s in statuses)
            {
                holder3.Add(s.Name);
            }
            cmbStatus.DataSource = holder3;

        }

        private void updLists()
        {
            baseControls = new Control[]
            {
                funcsLabelMain,
                funcsLabelColls,
                funcsLabelCond,
                funcsLabelStatus,
                funcsLabelRare,
                funcsCmbMain,
                funcsCmbColls,
                funcsCmbCond,
                funcsCmbStatus,
                funcsCmbRare
            };
            statuses = DBFuncs.GetStatusList();
            collections = DBFuncs.GetCollsList();
            conditions = DBFuncs.GetConditionsList();
            rares = DBFuncs.GetRaresList();
            updCmb();
        }

        private void updTags()
        {
            CreateLine = new Control[]
            {
                //base
                funcsCmbMain
                ,funcsLabelMain

                ,funcsLabelColls
                ,funcsCmbColls

                ,funcsLabelCond
                ,funcsCmbCond

                ,funcsLabelStatus
                ,funcsCmbStatus

                ,funcsLabelRare
                ,funcsCmbRare

                //Общие
                ,txtValue
                ,labelValue
                ,cmbStatus
                ,labelStatus
                ,txtPlace
                ,labelMainPlace
                ,cmbRare
                ,cmbCondition
                ,labelMainRare
                ,labelMainCond
                ,txtYear
                ,labelMainYear
                ,cmbCollection
                ,labelMainColl
                ,btnAddMain
                ,txtName
                ,labelMainName

                //Коллекции
                ,labelCollsName
                ,txtCollsName
                ,btnAddColls

                //Состояния
                ,labelCondName
                ,txtCondName
                ,btnAddCond

                //Статусы
                ,labelStatusName
                ,txtStatusName
                ,btnAddStatus

                //Редкости
                ,labelRareName
                ,txtRareName
                ,btnAddRare
            };

            EditLine = new Control[]
            {
                //base
                funcsCmbMain
                ,funcsLabelMain

                ,funcsLabelColls
                ,funcsCmbColls

                ,funcsLabelCond
                ,funcsCmbCond

                ,funcsLabelStatus
                ,funcsCmbStatus

                ,funcsLabelRare
                ,funcsCmbRare



                //Общие
                ,txtValue
                ,labelValue
                ,cmbStatus
                ,labelStatus
                ,txtPlace
                ,labelMainPlace
                ,cmbRare
                ,cmbCondition
                ,labelMainRare
                ,labelMainCond
                ,txtYear
                ,labelMainYear
                ,cmbCollection
                ,labelMainColl
                ,delBtn
                ,editBtn
                ,txtName
                ,labelMainName

                //Коллекции
                ,labelCollsName
                ,txtCollsName
                ,btnEditColls
                ,btnDelColls

                //Состояния
                ,labelCondName
                ,txtCondName
                ,btnDelCond
                ,btnEditCond

                //Статусы
                ,labelStatusName
                ,txtStatusName
                ,btnEditStatus
                ,btnDelStatus

                //Редкости
                ,labelRareName
                ,txtRareName
                ,btnEditRare
                ,btnDelRare

            };
        }

        private void assignFuncsToBase()
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                foreach (ComboBox c in tabPage.Controls.OfType<ComboBox>())
                {
                    if (c.Tag.ToString() == "base")
                    {
                        c.SelectedIndexChanged += comboBox_GlobalBase;
                    }
                }
            }
        }

        void comboBox_GlobalBase(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedIndex == 0)
            {
                updateUI(UImode.Create);
            }

            if (cb.SelectedIndex == 1)
            {
                updateUI(UImode.Edit);
            }

            if (cb.SelectedIndex == 2)
            {
                updateUI(UImode.Filter);
            }
        }

        private void updateUI(UImode mode)
        {
            Control[] depends = null;
                switch (mode)
            {
                case UImode.Create:
                    depends = CreateLine;
                    break;
                case UImode.Edit: 
                    depends = EditLine; 
                    break;
                case UImode.Filter:
                    depends = FilterView;
                    break;
            }
            foreach (Control c in tabControl1.SelectedTab.Controls)
            {
                if (depends?.Contains(c) == true)
                {
                    c.Visible = true;
                }
                else c.Visible = false;
            }
        }

        private bool isUnique(object table, string subj)
        {
            if (table is List<Collections>)
            {
                foreach (Collections s in collections)
                {
                    if (subj.ToLower() == s.Name.ToLower()) MessageBox.Show("Такое поле уже существует"); return false;
                }
            }

            if (table is List<Conditions>)
            {
                foreach (Conditions s in conditions)
                {
                    if (subj.ToLower() == s.Name.ToLower()) MessageBox.Show("Такое поле уже существует"); return false;
                }
            }

            if (table is List<Rares>)
            {
                foreach (Rares s in rares)
                {
                    if (subj.ToLower() == s.Name.ToLower()) MessageBox.Show("Такое поле уже существует"); return false;
                }
            }

            if (table is List<Status>)
            {
                foreach (Status s in statuses)
                {
                    if (subj.ToLower() == s.Name.ToLower()) MessageBox.Show("Такое поле уже существует"); return false;
                }
            }

            return true;
            //if (table.GetType() == typeof(Collections))
        }


        //private void btnFilter_Click(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource =
        //        db.FilterByStatus(cmbFilterStatus.Text);
        //}

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    double price = Convert.ToDouble(txtSearchPrice.Text);

        //    dataGridView1.DataSource =
        //        db.Search(cmbSearchType.Text, price);
        //}


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = DBFuncs.GetAll();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = DBFuncs.GetData("Collections");
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = DBFuncs.GetData("Conditions");
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                dataGridView1.DataSource = DBFuncs.GetData("Status");
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                dataGridView1.DataSource = DBFuncs.GetData("Rares");
            }
        }

        private void btnAddMain_Click(object sender, EventArgs e)
        {
            Items item = new Items();

            item.CollectionType = collections.FirstOrDefault(c => c.Name == cmbCollection.Text);
            item.Name = txtName.Text;
            if (txtYear.Text == null|| txtYear.Text == "") item.Year = null; else item.Year = int.Parse(txtYear.Text);
            item.Condition = conditions.FirstOrDefault(con => con.Name == cmbCondition.Text);
            item.Rare = rares.FirstOrDefault(rare => rare.Name == cmbRare.Text);
            item.StoragePlace = txtPlace.Text;
            if (txtValue.Text == null || txtValue.Text == "") item.Price = null; else item.Price = Convert.ToDouble(txtValue.Text);
            item.Status = statuses.FirstOrDefault(stat => stat.Name == cmbStatus.Text);

            if (DBFuncs.Add(item))
            updLists();
            LoadData(selectedTab.Items);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int? year;
            int? value;
            if (int.TryParse(txtYear.Text, out int i)) { year = i; } else year = null;
            if(int.TryParse(txtValue.Text, out int f)) { value = f; } else value = null;
            if (DBFuncs.UpdateItemsData
                 ("Items",
                 varId,
                 txtName.Text,
                 collections.FirstOrDefault(c => c.Name == cmbCollection.Text).Id,
                 year,
                 conditions.FirstOrDefault(con => con.Name == cmbCondition.Text).Id,
                 rares.FirstOrDefault(c => c.Name == cmbRare.Text).Id,
                 txtPlace.Text,
                 statuses.FirstOrDefault(c => c.Name == cmbStatus.Text).Id,
                 value))
            updLists();
            LoadData(selectedTab.Items);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int curRow = e.RowIndex;
            int curCol = e.ColumnIndex;
            if (curCol >= 0 && curRow >= 0 && tabControl1.SelectedIndex == 0)
            {
                int curId = int.Parse(dataGridView1[0, curRow].Value.ToString());
                varId = curId;
                string curName = dataGridView1[1, curRow].Value.ToString();
                
                //int curCollId = collections.FirstOrDefault(c => c.Name == dataGridView1[2, curRow].Value.ToString()).Id;
                //collId = curCollId;
                string curColl = dataGridView1[2, curRow].Value.ToString();

                int curYear = int.Parse(dataGridView1[3, curRow].Value.ToString());

                string curCond = dataGridView1[4, curRow].Value.ToString();

                string curRare = dataGridView1[5, curRow].Value.ToString();
                
                string curPlace = dataGridView1[6, curRow].Value.ToString();

                string curStatus = dataGridView1[7, curRow].Value.ToString();

                string curValue = dataGridView1[8, curRow].Value.ToString();


                txtName.Text = curName;
                cmbCollection.SelectedIndex = cmbCollection.Items.IndexOf(curColl);
                txtYear.Text = curYear.ToString();
                cmbCondition.SelectedIndex = cmbCondition.Items.IndexOf(curCond);
                cmbRare.SelectedIndex = cmbRare.Items.IndexOf(curRare);
                txtPlace.Text = curPlace.ToString();
                cmbStatus.SelectedIndex = cmbStatus.Items.IndexOf(curStatus);
                txtValue.Text = curValue;
            }

            if (curCol >= 0 && curRow >= 0 && tabControl1.SelectedIndex ==  1)
            //else if (curCol >= 0 && curRow >= 0)
            {
                int curId = int.Parse(dataGridView1[0, curRow].Value.ToString());
                varId = curId;
                
                string curName = dataGridView1[1, curRow].Value.ToString();

                txtCollsName.Text = curName;
            }

            if (curCol >= 0 && curRow >= 0 && tabControl1.SelectedIndex == 2)
            //else if (curCol >= 0 && curRow >= 0)
            {
                int curId = int.Parse(dataGridView1[0, curRow].Value.ToString());
                varId = curId;

                string curName = dataGridView1[1, curRow].Value.ToString();

                txtCondName.Text = curName;
            }
            if (curCol >= 0 && curRow >= 0 && tabControl1.SelectedIndex == 3)
            //else if (curCol >= 0 && curRow >= 0)
            {
                int curId = int.Parse(dataGridView1[0, curRow].Value.ToString());
                varId = curId;

                string curName = dataGridView1[1, curRow].Value.ToString();

                txtStatusName.Text = curName;
            }
            if (curCol >= 0 && curRow >= 0 && tabControl1.SelectedIndex == 4)
            //else if (curCol >= 0 && curRow >= 0)
            {
                int curId = int.Parse(dataGridView1[0, curRow].Value.ToString());
                varId = curId;

                string curName = dataGridView1[1, curRow].Value.ToString();

                txtRareName.Text = curName;
            }

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DBFuncs.DeleteData("Items", varId);
            updLists();
            LoadData(selectedTab.Items);
        }

        private void btnAddColls_Click(object sender, EventArgs e)
        {
            if (isUnique(collections, txtCollsName.Text))
            if (DBFuncs.AddDataInBase("Collections", txtCollsName.Text))
            updLists();
            LoadData(selectedTab.Collections);
        }

        private void btnEditColls_Click(object sender, EventArgs e)
        {
            if (DBFuncs.UpdateData("Collections", txtCollsName.Text, varId))
            updLists();
            LoadData(selectedTab.Collections);
        }

        private void btnDelColls_Click(object sender, EventArgs e)
        {
            DBFuncs.DeleteData("Collections", varId);
            updLists();
            LoadData(selectedTab.Collections);
        }

        private void btnAddCond_Click(object sender, EventArgs e)
        {
            if (isUnique(conditions, txtCondName.Text))
            if (DBFuncs.AddDataInBase("Conditions", txtCondName.Text))
            updLists();
            LoadData(selectedTab.Conditions);
        }

        private void btnEditCond_Click(object sender, EventArgs e)
        {
            if (DBFuncs.UpdateData("Conditions", txtCondName.Text, varId))
            updLists();
            LoadData(selectedTab.Conditions);
        }

        private void btnDelCond_Click(object sender, EventArgs e)
        {
            DBFuncs.DeleteData("Conditions", varId);
            updLists();
            LoadData(selectedTab.Conditions);
        }

        private void btnAddStatus_Click(object sender, EventArgs e)
        {
            if (isUnique(statuses, txtStatusName.Text))
            if (DBFuncs.AddDataInBase("Status", txtStatusName.Text))
            updLists();
            LoadData(selectedTab.Status);
        }

        private void btnEditStatus_Click(object sender, EventArgs e)
        {
            if (DBFuncs.UpdateData("Status", txtStatusName.Text,varId))
            updLists();
            LoadData(selectedTab.Status);
        }

        private void btnDelStatus_Click(object sender, EventArgs e)
        {
            DBFuncs.DeleteData("Status", varId);
            updLists();
            LoadData(selectedTab.Status);
        }

        private void btnAddRare_Click(object sender, EventArgs e)
        {
            if(isUnique(rares, txtRareName.Text))
            if (DBFuncs.AddDataInBase("Rares", txtRareName.Text))
            updLists();
            LoadData(selectedTab.Rares);
        }

        private void btnEditRare_Click(object sender, EventArgs e)
        {
            if (DBFuncs.UpdateData("Rares", txtRareName.Text, varId))
            updLists();
            LoadData(selectedTab.Rares);
        }

        private void btnDelRare_Click(object sender, EventArgs e)
        {
            DBFuncs.DeleteData("Rares", varId);
            updLists();
            LoadData(selectedTab.Rares);
        }
    }
}
