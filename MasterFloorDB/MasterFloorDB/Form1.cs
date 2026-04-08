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
using System.Runtime.InteropServices;



namespace MasterFloorDB
{
    public partial class Form1 : Form
    {

        #region ВИН 32 АПИ
        //[DllImport("user32.dll")]
        //private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        //public static class Win32Helper
        //{
        //    // Номер команды для установки баннера-подсказки
        //    private const int EM_SETCUEBANNER = 0x1501;

        //    [DllImport("user32.dll", CharSet = CharSet.Auto)]
        //    private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        //    public static void SetPlaceholder(Control control, string text)
        //    {
        //        // Отправляем сообщение: 
        //        // control.Handle — кому (ID текстового поля)
        //        // EM_SETCUEBANNER — что сделать (показать подсказку)
        //        // 1 — условие (показывать, даже когда фокус внутри)
        //        // text — саму строку
        //        SendMessage(control.Handle, EM_SETCUEBANNER, 0, text);
        //    }
        //}
        #endregion


        DBFuncs db = new DBFuncs();

        List<Products> products;
        List<Conditions> conditions;
        List<Materials> Materials;
        List<Types> types;
        List<ProdTypes> prodTypes;

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
            Types,
            Products,
            Materials
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

        void createItem()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Items i in DBFuncs.GetAll())
            {
                ReqItem item = new ReqItem(i.Id, i.Type, i.Name, i.Director, i.Phone, i.Rating.ToString());
                item.Dock = DockStyle.Top;
                item.passItem += receiveItem;

                flowLayoutPanel1.Controls.Add(item);

            }
        }

        private void receiveItem(object sender, Items item)
        {
            varId = item.Id;

            txtName.Text = item.Name;
            cmbType.SelectedIndex = cmbType.Items.IndexOf(item.Type.Name);
            txtDirector.Text = item.Director;
            txtPhone.Text = item.Phone;
            txtRating.Text = item.Rating.ToString();

        }

        void createItem(string data)
        {
            flowLayoutPanel1.Controls.Clear();
            DataGridView dataview = new DataGridView();
            dataview.DataSource = DBFuncs.GetData(data);
            dataview.AutoSize = true;
            dataview.RowHeadersVisible = false;
            dataview.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataview.MultiSelect = false;
            dataview.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataview.AllowUserToAddRows = false;
            dataview.AllowUserToDeleteRows = false;

            dataview.CellClick += cellClick;
            //dataview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //(dataview.Width, dataview.Height) = (flowLayoutPanel1.Width, flowLayoutPanel1.Height);

            flowLayoutPanel1.Controls.Add(dataview);
        }


        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dv = (DataGridView)sender;

            if (e.RowIndex <= -1 || e.ColumnIndex <= -1) return;

            varId = int.Parse(dv[0, e.RowIndex].Value.ToString());
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    txtCollsName.Text = dv[1, e.RowIndex].Value.ToString(); 
                    break;
                case 2:
                    txtCondName.Text = dv[1, e.RowIndex].Value.ToString();
                    txtCondDef.Text = dv[2, e.RowIndex].Value.ToString();
                    break;
                case 3:
                    txtStatusName.Text = dv[2, e.RowIndex].Value.ToString();
                    cmbStatusType.SelectedIndex = cmbStatusType.Items.IndexOf(dv[1,e.RowIndex].Value.ToString());
                    txtStatusArt.Text = dv[3, e.RowIndex].Value.ToString();
                    txtStatusPrice.Text = dv[4, e.RowIndex].Value.ToString();

                    break;
            }
        }



        void LoadData(selectedTab mode)
        {
            flowLayoutPanel1.Controls.Clear();
            switch (mode)
            {
                case selectedTab.Items:
                    createItem();
                    break;
                case selectedTab.Types:
                    createItem("partner_type");
                    
                    break;
                case selectedTab.Products:
                    createItem("ProductsView");
                    break;
                case selectedTab.Materials:
                    createItem("Material_type");
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

            txtCondDef.Text = "0";
            txtStatusPrice.Text = "0";
            txtStatusArt.Text = "0";

            txtCondDef.Enter += placeHolder_Enter;
            txtCondDef.Leave += placeHolder_Leave;

            txtStatusArt.Enter += placeHolder_Enter;
            txtStatusArt.Leave += placeHolder_Leave;

            txtStatusPrice.Enter += placeHolder_Enter;
            txtStatusPrice.Leave += placeHolder_Leave;

            //foreach (Control control in itemViewTab.Controls)
            //{
            //    if (control.Tag != null)
            //        if (control.Tag.ToString().Contains("CreateLine") || control.Tag.ToString().Contains("base"))
            //        {
            //            control.Visible = true;
            //        }
            //        else { control.Visible = false; }
            //}
        }

        void updCmb()
        {
            List<string> holder = new List<string>();
            foreach (Types c in types)
            {
                holder.Add(c.Name);
            }
            cmbType.DataSource = holder;

            List<string> holder1 = new List<string>();
            foreach (ProdTypes c in prodTypes)
            {
                holder1.Add(c.Name);
            }
            cmbStatusType.DataSource = holder1;

            //holder.Clear();
        }

        private void updLists()
        {
            baseControls = new Control[]
            {
                funcsLabelMain,
                funcsLabelColls,
                funcsLabelCond,
                funcsLabelStatus,
                //funcsLabelRare,
                funcsCmbMain,
                funcsCmbColls,
                funcsCmbCond,
                funcsCmbStatus,
                //funcsCmbRare
            };
            products = DBFuncs.GetProductsList();
            types = DBFuncs.GetTypesList();
            prodTypes = DBFuncs.GetProdTypesList();
            //conditions = DBFuncs.GetConditionsList();
            Materials = DBFuncs.GetMaterialsList();
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

                //,funcsLabelRare
                //,funcsCmbRare

                //Общие
                ,txtRating
                ,labelRating
                ,txtPhone
                ,labelMainPhone
                ,txtDirector
                ,labelMainDirector
                ,cmbType
                ,labelMainType
                ,btnAddMain
                ,txtName
                ,labelMainName

                //Типы
                ,labelCollsName
                ,txtCollsName
                ,btnAddTypes
                ,labelCondDef
                ,txtCondDef

                //Материалы
                ,labelCondName
                ,txtCondName
                ,btnAddCond
                ,labelCondDef
                ,txtCondDef

                //Продукты
                ,labelStatusName
                ,txtStatusName
                ,btnAddStatus
                ,labelStatusType
                ,cmbStatusType
                ,labelStatusArt
                ,txtStatusArt
                ,labelStatusPrice
                ,txtStatusPrice

                //Редкости
                //,labelRareName
                //,txtRareName
                //,btnAddRare
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

                //,funcsLabelRare
                //,funcsCmbRare



                //Общие
                ,txtRating
                ,labelRating
                ,txtPhone
                ,labelMainPhone
                ,txtDirector
                ,labelMainDirector
                ,cmbType
                ,labelMainType
                ,delBtn
                ,editBtn
                ,txtName
                ,labelMainName

                //Типы
                ,labelCollsName
                ,txtCollsName
                ,btnEditTypes
                ,btnDelTypes

                //Материалы
                ,labelCondName
                ,txtCondName
                ,btnDelCond
                ,btnEditCond
                ,labelCondDef
                ,txtCondDef


                //Продукты
                ,labelStatusName
                ,txtStatusName
                ,btnEditStatus
                ,btnDelStatus
                ,labelStatusType
                ,cmbStatusType
                ,labelStatusArt
                ,txtStatusArt
                ,labelStatusPrice
                ,txtStatusPrice


                //Редкости
                //,labelRareName
                //,txtRareName
                //,btnEditRare
                //,btnDelRare

            };
        }

        private void assignFuncsToBase()
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                foreach (ComboBox c in tabPage.Controls.OfType<ComboBox>())
                {
                    if (c.Tag?.ToString() == "base")
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
            if (table is List<Types>)
            {
                foreach (Types s in types)
                {
                    if (subj.ToLower() == s.Name.ToLower()) { MessageBox.Show("Такое поле уже существует"); return false; }
                }
            }

            if (table is List<Conditions>)
            {
                foreach (Conditions s in conditions)
                {
                    if (subj.ToLower() == s.Name.ToLower()) { MessageBox.Show("Такое поле уже существует"); return false; }
                }
            }

            if (table is List<Materials>)
            {
                foreach (Materials s in Materials)
                {
                    if (subj.ToLower() == s.Name.ToLower()) { MessageBox.Show("Такое поле уже существует"); return false; }
                }
            }

            if (table is List<Products>)
            {
                foreach (Products s in products)
                {
                    if (subj.ToLower() == s.Name.ToLower()) { MessageBox.Show("Такое поле уже существует"); return false; }
                }
            }

            return true;
            //if (table.GetType() == typeof(Types))
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



        #region KeyPress

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar==','))
            {
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    LoadData(selectedTab.Items);
                    break;
                case 1:
                    LoadData(selectedTab.Types);
                    break;
                case 2:
                    LoadData(selectedTab.Materials);
                    break;
                case 3:
                    LoadData(selectedTab.Products);
                    break;
                case 4:
                    LoadData(selectedTab.Materials);
                    break;
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int curRow = e.RowIndex;
            int curCol = e.ColumnIndex;
            if (curCol >= 0 && curRow >= 0 && tabControl1.SelectedIndex == 0)
            {
            }

            //if (curCol >= 0 && curRow >= 0 && tabControl1.SelectedIndex ==  1)
            ////else if (curCol >= 0 && curRow >= 0)
            //{
            //    int curId = int.Parse(dataGridView1[0, curRow].Value.ToString());
            //    varId = curId;

            //    string curName = dataGridView1[1, curRow].Value.ToString();

            //    txtCollsName.Text = curName;
            //}

            //if (curCol >= 0 && curRow >= 0 && tabControl1.SelectedIndex == 2)
            ////else if (curCol >= 0 && curRow >= 0)
            //{
            //    int curId = int.Parse(dataGridView1[0, curRow].Value.ToString());
            //    varId = curId;

            //    string curName = dataGridView1[1, curRow].Value.ToString();

            //    txtCondName.Text = curName;
            //}
            //if (curCol >= 0 && curRow >= 0 && tabControl1.SelectedIndex == 3)
            ////else if (curCol >= 0 && curRow >= 0)
            //{
            //    int curId = int.Parse(dataGridView1[0, curRow].Value.ToString());
            //    varId = curId;

            //    string curName = dataGridView1[1, curRow].Value.ToString();

            //    txtStatusName.Text = curName;
            //}
            //if (curCol >= 0 && curRow >= 0 && tabControl1.SelectedIndex == 4)
            ////else if (curCol >= 0 && curRow >= 0)
            //{
            //    int curId = int.Parse(dataGridView1[0, curRow].Value.ToString());
            //    varId = curId;

            //    string curName = dataGridView1[1, curRow].Value.ToString();

            //    txtRareName.Text = curName;
            //}

        }

        #region Кнопки

        private void btnAddMain_Click(object sender, EventArgs e)
        {
            Items item = new Items();

            item.Name = txtName.Text;
            if (cmbType.Text == "") { MessageBox.Show("Заполнены не все столбцы"); return; }
            item.Type = types.FirstOrDefault(type => type.Name == cmbType.Text);
            item.Director = txtDirector.Text;
            item.Phone = txtPhone.Text;
            if (txtRating.Text == "") { MessageBox.Show("Заполнены не все столбцы"); return; }
            item.Rating = null; item.Rating = int.Parse(txtRating.Text);

            if (DBFuncs.Add(item))
            {
                updLists();
                LoadData(selectedTab.Items);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int? rating;
            if (int.TryParse(txtRating.Text, out int f)) { rating = f; } else rating = null;
            if (DBFuncs.UpdateItemsData
                 ("Partners",
                 varId,
                 txtName.Text,
                 types.FirstOrDefault(c => c.Name == cmbType.Text).Id,
                 txtDirector.Text,
                 txtPhone.Text,
                 rating))
                updLists();
            LoadData(selectedTab.Items);
        }






        private void delBtn_Click(object sender, EventArgs e)
        {
            DBFuncs.DeleteData("Partners", varId);
            updLists();
            LoadData(selectedTab.Items);
        }
        private void btnAddTypes_Click(object sender, EventArgs e)
        {
            labelCollsName.Text = "1";
            if (isUnique(types, txtCollsName.Text))
                if (DBFuncs.AddDataInBase("partner_type", txtCollsName.Text))
                    updLists();
            LoadData(selectedTab.Types);
            labelCollsName.Text = "2";

        }

        private void btnEditColls_Click(object sender, EventArgs e)
        {
            if (DBFuncs.UpdateData("partner_type", txtCollsName.Text, varId))
            updLists();
            LoadData(selectedTab.Types);
        }

        private void btnDelColls_Click(object sender, EventArgs e)
        {
            DBFuncs.DeleteData("partner_type", varId);
            updLists();
            LoadData(selectedTab.Types);
        }

        private void btnAddCond_Click(object sender, EventArgs e)
        {
            if (isUnique(conditions, txtCondName.Text))
            {
                decimal.TryParse(txtCondDef.Text, out decimal perc);
                if (DBFuncs.AddMatsInBase(txtCondName.Text, perc))
                updLists();
                LoadData(selectedTab.Materials);
            }
        }

        private void btnEditCond_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtCondDef.Text, out decimal perc);
            if (DBFuncs.UpdateMats(txtCondName.Text, perc, varId))
            updLists();
            LoadData(selectedTab.Materials);
        }

        private void btnDelCond_Click(object sender, EventArgs e)
        {
            DBFuncs.DeleteData("Material_type", varId);
            updLists();
            LoadData(selectedTab.Materials);
        }

        private void btnAddStatus_Click(object sender, EventArgs e)
        {
            Products product = new Products();

            product.TypeId = prodTypes.FirstOrDefault(t=> t.Name==cmbStatusType.Text).Id;
            product.Name = txtStatusName.Text;
            int.TryParse(txtStatusArt.Text, out int i);
            product.Art = i;
            decimal.TryParse(txtStatusPrice.Text, out decimal f);
            product.MinPrice = f;
            //if (isUnique(products, txtStatusName.Text))
            if (DBFuncs.AddProductsInBase(product))
            updLists();
            LoadData(selectedTab.Products);
        }

        private void btnEditStatus_Click(object sender, EventArgs e)
        {
            if (DBFuncs.UpdateData("Products", txtStatusName.Text,varId))
            updLists();
            LoadData(selectedTab.Products);
        }

        private void btnDelStatus_Click(object sender, EventArgs e)
        {
            DBFuncs.DeleteData("Products", varId);
            updLists();
            LoadData(selectedTab.Products);
        }

        //private void btnAddRare_Click(object sender, EventArgs e)
        //{
        //    if(isUnique(Materials, txtRareName.Text))
        //    if (DBFuncs.AddDataInBase("Materials", txtRareName.Text))
        //    updLists();
        //    LoadData(selectedTab.Materials);
        //}

        //private void btnEditRare_Click(object sender, EventArgs e)
        //{
        //    if (DBFuncs.UpdateData("Materials", txtRareName.Text, varId))
        //    updLists();
        //    LoadData(selectedTab.Materials);
        //}

        //private void btnDelRare_Click(object sender, EventArgs e)
        //{
        //    DBFuncs.DeleteData("Materials", varId);
        //    updLists();
        //    LoadData(selectedTab.Materials);
        //}

        #endregion

        private void placeHolder_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text != "0" && txt.Text != "") return;
            txt.Text = "";
        }

        private void placeHolder_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text != "0" && txt.Text != "") return;
            txt.Text = "0";
        }
    }
}
