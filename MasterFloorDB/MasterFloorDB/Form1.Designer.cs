using System.Windows.Forms;

namespace MasterFloorDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.itemViewTab = new System.Windows.Forms.TabPage();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labelMainPhone = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.labelMainDirector = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.labelMainType = new System.Windows.Forms.Label();
            this.btnAddMain = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelMainName = new System.Windows.Forms.Label();
            this.funcsCmbMain = new System.Windows.Forms.ComboBox();
            this.funcsLabelMain = new System.Windows.Forms.Label();
            this.typesTab = new System.Windows.Forms.TabPage();
            this.btnDelTypes = new System.Windows.Forms.Button();
            this.btnEditTypes = new System.Windows.Forms.Button();
            this.btnAddTypes = new System.Windows.Forms.Button();
            this.txtCollsName = new System.Windows.Forms.TextBox();
            this.labelCollsName = new System.Windows.Forms.Label();
            this.funcsCmbColls = new System.Windows.Forms.ComboBox();
            this.funcsLabelColls = new System.Windows.Forms.Label();
            this.materialsTab = new System.Windows.Forms.TabPage();
            this.txtCondDef = new System.Windows.Forms.TextBox();
            this.labelCondDef = new System.Windows.Forms.Label();
            this.btnDelCond = new System.Windows.Forms.Button();
            this.btnEditCond = new System.Windows.Forms.Button();
            this.btnAddCond = new System.Windows.Forms.Button();
            this.txtCondName = new System.Windows.Forms.TextBox();
            this.labelCondName = new System.Windows.Forms.Label();
            this.funcsCmbCond = new System.Windows.Forms.ComboBox();
            this.funcsLabelCond = new System.Windows.Forms.Label();
            this.productsTab = new System.Windows.Forms.TabPage();
            this.txtStatusPrice = new System.Windows.Forms.TextBox();
            this.txtStatusArt = new System.Windows.Forms.TextBox();
            this.cmbStatusType = new System.Windows.Forms.ComboBox();
            this.labelStatusPrice = new System.Windows.Forms.Label();
            this.labelStatusArt = new System.Windows.Forms.Label();
            this.labelStatusType = new System.Windows.Forms.Label();
            this.btnDelStatus = new System.Windows.Forms.Button();
            this.btnEditStatus = new System.Windows.Forms.Button();
            this.btnAddStatus = new System.Windows.Forms.Button();
            this.txtStatusName = new System.Windows.Forms.TextBox();
            this.labelStatusName = new System.Windows.Forms.Label();
            this.funcsCmbStatus = new System.Windows.Forms.ComboBox();
            this.funcsLabelStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.itemViewTab.SuspendLayout();
            this.typesTab.SuspendLayout();
            this.materialsTab.SuspendLayout();
            this.productsTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.itemViewTab);
            this.tabControl1.Controls.Add(this.typesTab);
            this.tabControl1.Controls.Add(this.materialsTab);
            this.tabControl1.Controls.Add(this.productsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(708, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 568);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // itemViewTab
            // 
            this.itemViewTab.Controls.Add(this.delBtn);
            this.itemViewTab.Controls.Add(this.editBtn);
            this.itemViewTab.Controls.Add(this.txtRating);
            this.itemViewTab.Controls.Add(this.labelRating);
            this.itemViewTab.Controls.Add(this.txtPhone);
            this.itemViewTab.Controls.Add(this.labelMainPhone);
            this.itemViewTab.Controls.Add(this.txtDirector);
            this.itemViewTab.Controls.Add(this.labelMainDirector);
            this.itemViewTab.Controls.Add(this.cmbType);
            this.itemViewTab.Controls.Add(this.labelMainType);
            this.itemViewTab.Controls.Add(this.btnAddMain);
            this.itemViewTab.Controls.Add(this.txtName);
            this.itemViewTab.Controls.Add(this.labelMainName);
            this.itemViewTab.Controls.Add(this.funcsCmbMain);
            this.itemViewTab.Controls.Add(this.funcsLabelMain);
            this.itemViewTab.Location = new System.Drawing.Point(4, 22);
            this.itemViewTab.Name = "itemViewTab";
            this.itemViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.itemViewTab.Size = new System.Drawing.Size(376, 542);
            this.itemViewTab.TabIndex = 0;
            this.itemViewTab.Text = "Общая";
            this.itemViewTab.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(199, 456);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(123, 34);
            this.delBtn.TabIndex = 64;
            this.delBtn.Tag = "EditLine";
            this.delBtn.Text = "Удалить запись";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(70, 456);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(123, 34);
            this.editBtn.TabIndex = 63;
            this.editBtn.Tag = "EditLine";
            this.editBtn.Text = "Изменить запись";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(93, 189);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(253, 20);
            this.txtRating.TabIndex = 62;
            this.txtRating.Tag = "CreateLine, EditLine";
            this.txtRating.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(36, 192);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(51, 13);
            this.labelRating.TabIndex = 61;
            this.labelRating.Tag = "CreateLine, EditLine";
            this.labelRating.Text = "Рейтинг:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(97, 159);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 20);
            this.txtPhone.TabIndex = 58;
            this.txtPhone.Tag = "CreateLine, EditLine";
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // labelMainPhone
            // 
            this.labelMainPhone.AutoSize = true;
            this.labelMainPhone.Location = new System.Drawing.Point(36, 162);
            this.labelMainPhone.Name = "labelMainPhone";
            this.labelMainPhone.Size = new System.Drawing.Size(55, 13);
            this.labelMainPhone.TabIndex = 57;
            this.labelMainPhone.Tag = "CreateLine, EditLine";
            this.labelMainPhone.Text = "Телефон:";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(102, 128);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(245, 20);
            this.txtDirector.TabIndex = 51;
            this.txtDirector.Tag = "CreateLine, EditLine";
            // 
            // labelMainDirector
            // 
            this.labelMainDirector.AutoSize = true;
            this.labelMainDirector.Location = new System.Drawing.Point(36, 131);
            this.labelMainDirector.Name = "labelMainDirector";
            this.labelMainDirector.Size = new System.Drawing.Size(60, 13);
            this.labelMainDirector.TabIndex = 50;
            this.labelMainDirector.Tag = "CreateLine, EditLine";
            this.labelMainDirector.Text = "Директор:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(70, 69);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(276, 21);
            this.cmbType.TabIndex = 49;
            this.cmbType.Tag = "CreateLine, EditLine";
            // 
            // labelMainType
            // 
            this.labelMainType.AutoSize = true;
            this.labelMainType.Location = new System.Drawing.Point(36, 72);
            this.labelMainType.Name = "labelMainType";
            this.labelMainType.Size = new System.Drawing.Size(29, 13);
            this.labelMainType.TabIndex = 48;
            this.labelMainType.Tag = "CreateLine, EditLine";
            this.labelMainType.Text = "Тип:";
            // 
            // btnAddMain
            // 
            this.btnAddMain.Location = new System.Drawing.Point(125, 456);
            this.btnAddMain.Name = "btnAddMain";
            this.btnAddMain.Size = new System.Drawing.Size(123, 34);
            this.btnAddMain.TabIndex = 47;
            this.btnAddMain.Tag = "CreateLine";
            this.btnAddMain.Text = "Добавить запись";
            this.btnAddMain.UseVisualStyleBackColor = true;
            this.btnAddMain.Click += new System.EventHandler(this.btnAddMain_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 20);
            this.txtName.TabIndex = 46;
            this.txtName.Tag = "CreateLine, EditLine";
            // 
            // labelMainName
            // 
            this.labelMainName.AutoSize = true;
            this.labelMainName.Location = new System.Drawing.Point(36, 102);
            this.labelMainName.Name = "labelMainName";
            this.labelMainName.Size = new System.Drawing.Size(60, 13);
            this.labelMainName.TabIndex = 45;
            this.labelMainName.Tag = "CreateLine, EditLine";
            this.labelMainName.Text = "Название:";
            // 
            // funcsCmbMain
            // 
            this.funcsCmbMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcsCmbMain.FormattingEnabled = true;
            this.funcsCmbMain.Items.AddRange(new object[] {
            "Добавить строку",
            "Редактировать строку"});
            this.funcsCmbMain.Location = new System.Drawing.Point(6, 24);
            this.funcsCmbMain.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.funcsCmbMain.Name = "funcsCmbMain";
            this.funcsCmbMain.Size = new System.Drawing.Size(131, 21);
            this.funcsCmbMain.TabIndex = 40;
            this.funcsCmbMain.Tag = "base";
            // 
            // funcsLabelMain
            // 
            this.funcsLabelMain.AutoSize = true;
            this.funcsLabelMain.Location = new System.Drawing.Point(3, 7);
            this.funcsLabelMain.Name = "funcsLabelMain";
            this.funcsLabelMain.Size = new System.Drawing.Size(56, 13);
            this.funcsLabelMain.TabIndex = 39;
            this.funcsLabelMain.Tag = "base";
            this.funcsLabelMain.Text = "Функции:";
            // 
            // typesTab
            // 
            this.typesTab.Controls.Add(this.btnDelTypes);
            this.typesTab.Controls.Add(this.btnEditTypes);
            this.typesTab.Controls.Add(this.btnAddTypes);
            this.typesTab.Controls.Add(this.txtCollsName);
            this.typesTab.Controls.Add(this.labelCollsName);
            this.typesTab.Controls.Add(this.funcsCmbColls);
            this.typesTab.Controls.Add(this.funcsLabelColls);
            this.typesTab.Location = new System.Drawing.Point(4, 22);
            this.typesTab.Name = "typesTab";
            this.typesTab.Padding = new System.Windows.Forms.Padding(3);
            this.typesTab.Size = new System.Drawing.Size(376, 542);
            this.typesTab.TabIndex = 1;
            this.typesTab.Text = "Типы";
            this.typesTab.UseVisualStyleBackColor = true;
            // 
            // btnDelTypes
            // 
            this.btnDelTypes.Location = new System.Drawing.Point(188, 429);
            this.btnDelTypes.Name = "btnDelTypes";
            this.btnDelTypes.Size = new System.Drawing.Size(123, 34);
            this.btnDelTypes.TabIndex = 83;
            this.btnDelTypes.Tag = "EditLine";
            this.btnDelTypes.Text = "Удалить запись";
            this.btnDelTypes.UseVisualStyleBackColor = true;
            this.btnDelTypes.Visible = false;
            this.btnDelTypes.Click += new System.EventHandler(this.btnDelColls_Click);
            // 
            // btnEditTypes
            // 
            this.btnEditTypes.Location = new System.Drawing.Point(59, 429);
            this.btnEditTypes.Name = "btnEditTypes";
            this.btnEditTypes.Size = new System.Drawing.Size(123, 34);
            this.btnEditTypes.TabIndex = 82;
            this.btnEditTypes.Tag = "EditLine";
            this.btnEditTypes.Text = "Изменить запись";
            this.btnEditTypes.UseVisualStyleBackColor = true;
            this.btnEditTypes.Visible = false;
            this.btnEditTypes.Click += new System.EventHandler(this.btnEditColls_Click);
            // 
            // btnAddTypes
            // 
            this.btnAddTypes.Location = new System.Drawing.Point(110, 469);
            this.btnAddTypes.Name = "btnAddTypes";
            this.btnAddTypes.Size = new System.Drawing.Size(123, 34);
            this.btnAddTypes.TabIndex = 81;
            this.btnAddTypes.Tag = "CreateLine";
            this.btnAddTypes.Text = "Добавить запись";
            this.btnAddTypes.UseVisualStyleBackColor = true;
            this.btnAddTypes.Click += new System.EventHandler(this.btnAddTypes_Click);
            // 
            // txtCollsName
            // 
            this.txtCollsName.Location = new System.Drawing.Point(105, 106);
            this.txtCollsName.Name = "txtCollsName";
            this.txtCollsName.Size = new System.Drawing.Size(245, 20);
            this.txtCollsName.TabIndex = 66;
            this.txtCollsName.Tag = "CreateLine";
            // 
            // labelCollsName
            // 
            this.labelCollsName.AutoSize = true;
            this.labelCollsName.Location = new System.Drawing.Point(39, 109);
            this.labelCollsName.Name = "labelCollsName";
            this.labelCollsName.Size = new System.Drawing.Size(60, 13);
            this.labelCollsName.TabIndex = 65;
            this.labelCollsName.Tag = "CreateLine";
            this.labelCollsName.Text = "Название:";
            // 
            // funcsCmbColls
            // 
            this.funcsCmbColls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcsCmbColls.FormattingEnabled = true;
            this.funcsCmbColls.Items.AddRange(new object[] {
            "Добавить строку",
            "Редактировать строку"});
            this.funcsCmbColls.Location = new System.Drawing.Point(9, 29);
            this.funcsCmbColls.Name = "funcsCmbColls";
            this.funcsCmbColls.Size = new System.Drawing.Size(121, 21);
            this.funcsCmbColls.TabIndex = 64;
            this.funcsCmbColls.Tag = "base";
            // 
            // funcsLabelColls
            // 
            this.funcsLabelColls.AutoSize = true;
            this.funcsLabelColls.Location = new System.Drawing.Point(6, 12);
            this.funcsLabelColls.Name = "funcsLabelColls";
            this.funcsLabelColls.Size = new System.Drawing.Size(56, 13);
            this.funcsLabelColls.TabIndex = 63;
            this.funcsLabelColls.Tag = "base";
            this.funcsLabelColls.Text = "Функции:";
            // 
            // materialsTab
            // 
            this.materialsTab.Controls.Add(this.txtCondDef);
            this.materialsTab.Controls.Add(this.labelCondDef);
            this.materialsTab.Controls.Add(this.btnDelCond);
            this.materialsTab.Controls.Add(this.btnEditCond);
            this.materialsTab.Controls.Add(this.btnAddCond);
            this.materialsTab.Controls.Add(this.txtCondName);
            this.materialsTab.Controls.Add(this.labelCondName);
            this.materialsTab.Controls.Add(this.funcsCmbCond);
            this.materialsTab.Controls.Add(this.funcsLabelCond);
            this.materialsTab.Location = new System.Drawing.Point(4, 22);
            this.materialsTab.Name = "materialsTab";
            this.materialsTab.Size = new System.Drawing.Size(376, 542);
            this.materialsTab.TabIndex = 2;
            this.materialsTab.Text = "Материалы";
            this.materialsTab.UseVisualStyleBackColor = true;
            // 
            // txtCondDef
            // 
            this.txtCondDef.Location = new System.Drawing.Point(112, 143);
            this.txtCondDef.Name = "txtCondDef";
            this.txtCondDef.Size = new System.Drawing.Size(235, 20);
            this.txtCondDef.TabIndex = 85;
            this.txtCondDef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelCondDef
            // 
            this.labelCondDef.AutoSize = true;
            this.labelCondDef.Location = new System.Drawing.Point(36, 146);
            this.labelCondDef.Name = "labelCondDef";
            this.labelCondDef.Size = new System.Drawing.Size(70, 13);
            this.labelCondDef.TabIndex = 84;
            this.labelCondDef.Text = "Шанс брака:";
            // 
            // btnDelCond
            // 
            this.btnDelCond.Location = new System.Drawing.Point(201, 438);
            this.btnDelCond.Name = "btnDelCond";
            this.btnDelCond.Size = new System.Drawing.Size(123, 34);
            this.btnDelCond.TabIndex = 83;
            this.btnDelCond.Tag = "EditLine";
            this.btnDelCond.Text = "Удалить запись";
            this.btnDelCond.UseVisualStyleBackColor = true;
            this.btnDelCond.Visible = false;
            this.btnDelCond.Click += new System.EventHandler(this.btnDelCond_Click);
            // 
            // btnEditCond
            // 
            this.btnEditCond.Location = new System.Drawing.Point(72, 438);
            this.btnEditCond.Name = "btnEditCond";
            this.btnEditCond.Size = new System.Drawing.Size(123, 34);
            this.btnEditCond.TabIndex = 82;
            this.btnEditCond.Tag = "EditLine";
            this.btnEditCond.Text = "Изменить запись";
            this.btnEditCond.UseVisualStyleBackColor = true;
            this.btnEditCond.Visible = false;
            this.btnEditCond.Click += new System.EventHandler(this.btnEditCond_Click);
            // 
            // btnAddCond
            // 
            this.btnAddCond.Location = new System.Drawing.Point(134, 478);
            this.btnAddCond.Name = "btnAddCond";
            this.btnAddCond.Size = new System.Drawing.Size(123, 34);
            this.btnAddCond.TabIndex = 81;
            this.btnAddCond.Tag = "CreateLine";
            this.btnAddCond.Text = "Добавить запись";
            this.btnAddCond.UseVisualStyleBackColor = true;
            this.btnAddCond.Click += new System.EventHandler(this.btnAddCond_Click);
            // 
            // txtCondName
            // 
            this.txtCondName.Location = new System.Drawing.Point(102, 104);
            this.txtCondName.Name = "txtCondName";
            this.txtCondName.Size = new System.Drawing.Size(245, 20);
            this.txtCondName.TabIndex = 66;
            this.txtCondName.Tag = "CreateLine";
            // 
            // labelCondName
            // 
            this.labelCondName.AutoSize = true;
            this.labelCondName.Location = new System.Drawing.Point(36, 107);
            this.labelCondName.Name = "labelCondName";
            this.labelCondName.Size = new System.Drawing.Size(60, 13);
            this.labelCondName.TabIndex = 65;
            this.labelCondName.Tag = "CreateLine";
            this.labelCondName.Text = "Название:";
            // 
            // funcsCmbCond
            // 
            this.funcsCmbCond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcsCmbCond.FormattingEnabled = true;
            this.funcsCmbCond.Items.AddRange(new object[] {
            "Добавить строку",
            "Редактировать строку"});
            this.funcsCmbCond.Location = new System.Drawing.Point(6, 27);
            this.funcsCmbCond.Name = "funcsCmbCond";
            this.funcsCmbCond.Size = new System.Drawing.Size(121, 21);
            this.funcsCmbCond.TabIndex = 64;
            this.funcsCmbCond.Tag = "base";
            // 
            // funcsLabelCond
            // 
            this.funcsLabelCond.AutoSize = true;
            this.funcsLabelCond.Location = new System.Drawing.Point(3, 10);
            this.funcsLabelCond.Name = "funcsLabelCond";
            this.funcsLabelCond.Size = new System.Drawing.Size(56, 13);
            this.funcsLabelCond.TabIndex = 63;
            this.funcsLabelCond.Tag = "base";
            this.funcsLabelCond.Text = "Функции:";
            // 
            // productsTab
            // 
            this.productsTab.Controls.Add(this.txtStatusPrice);
            this.productsTab.Controls.Add(this.txtStatusArt);
            this.productsTab.Controls.Add(this.cmbStatusType);
            this.productsTab.Controls.Add(this.labelStatusPrice);
            this.productsTab.Controls.Add(this.labelStatusArt);
            this.productsTab.Controls.Add(this.labelStatusType);
            this.productsTab.Controls.Add(this.btnDelStatus);
            this.productsTab.Controls.Add(this.btnEditStatus);
            this.productsTab.Controls.Add(this.btnAddStatus);
            this.productsTab.Controls.Add(this.txtStatusName);
            this.productsTab.Controls.Add(this.labelStatusName);
            this.productsTab.Controls.Add(this.funcsCmbStatus);
            this.productsTab.Controls.Add(this.funcsLabelStatus);
            this.productsTab.Location = new System.Drawing.Point(4, 22);
            this.productsTab.Name = "productsTab";
            this.productsTab.Size = new System.Drawing.Size(376, 542);
            this.productsTab.TabIndex = 3;
            this.productsTab.Text = "Продукты";
            this.productsTab.UseVisualStyleBackColor = true;
            // 
            // txtStatusPrice
            // 
            this.txtStatusPrice.Location = new System.Drawing.Point(107, 197);
            this.txtStatusPrice.Name = "txtStatusPrice";
            this.txtStatusPrice.Size = new System.Drawing.Size(240, 20);
            this.txtStatusPrice.TabIndex = 89;
            this.txtStatusPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress_1);
            // 
            // txtStatusArt
            // 
            this.txtStatusArt.Location = new System.Drawing.Point(97, 165);
            this.txtStatusArt.Name = "txtStatusArt";
            this.txtStatusArt.Size = new System.Drawing.Size(250, 20);
            this.txtStatusArt.TabIndex = 88;
            this.txtStatusArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // cmbStatusType
            // 
            this.cmbStatusType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusType.FormattingEnabled = true;
            this.cmbStatusType.Location = new System.Drawing.Point(74, 132);
            this.cmbStatusType.Name = "cmbStatusType";
            this.cmbStatusType.Size = new System.Drawing.Size(272, 21);
            this.cmbStatusType.TabIndex = 87;
            // 
            // labelStatusPrice
            // 
            this.labelStatusPrice.AutoSize = true;
            this.labelStatusPrice.Location = new System.Drawing.Point(39, 205);
            this.labelStatusPrice.Name = "labelStatusPrice";
            this.labelStatusPrice.Size = new System.Drawing.Size(61, 13);
            this.labelStatusPrice.TabIndex = 86;
            this.labelStatusPrice.Text = "Мин. цена:";
            // 
            // labelStatusArt
            // 
            this.labelStatusArt.AutoSize = true;
            this.labelStatusArt.Location = new System.Drawing.Point(39, 173);
            this.labelStatusArt.Name = "labelStatusArt";
            this.labelStatusArt.Size = new System.Drawing.Size(51, 13);
            this.labelStatusArt.TabIndex = 85;
            this.labelStatusArt.Text = "Артикул:";
            // 
            // labelStatusType
            // 
            this.labelStatusType.AutoSize = true;
            this.labelStatusType.Location = new System.Drawing.Point(39, 140);
            this.labelStatusType.Name = "labelStatusType";
            this.labelStatusType.Size = new System.Drawing.Size(29, 13);
            this.labelStatusType.TabIndex = 84;
            this.labelStatusType.Text = "Тип:";
            // 
            // btnDelStatus
            // 
            this.btnDelStatus.Location = new System.Drawing.Point(187, 431);
            this.btnDelStatus.Name = "btnDelStatus";
            this.btnDelStatus.Size = new System.Drawing.Size(123, 34);
            this.btnDelStatus.TabIndex = 83;
            this.btnDelStatus.Tag = "EditLine";
            this.btnDelStatus.Text = "Удалить запись";
            this.btnDelStatus.UseVisualStyleBackColor = true;
            this.btnDelStatus.Visible = false;
            this.btnDelStatus.Click += new System.EventHandler(this.btnDelStatus_Click);
            // 
            // btnEditStatus
            // 
            this.btnEditStatus.Location = new System.Drawing.Point(58, 431);
            this.btnEditStatus.Name = "btnEditStatus";
            this.btnEditStatus.Size = new System.Drawing.Size(123, 34);
            this.btnEditStatus.TabIndex = 82;
            this.btnEditStatus.Tag = "EditLine";
            this.btnEditStatus.Text = "Изменить запись";
            this.btnEditStatus.UseVisualStyleBackColor = true;
            this.btnEditStatus.Visible = false;
            this.btnEditStatus.Click += new System.EventHandler(this.btnEditStatus_Click);
            // 
            // btnAddStatus
            // 
            this.btnAddStatus.Location = new System.Drawing.Point(119, 471);
            this.btnAddStatus.Name = "btnAddStatus";
            this.btnAddStatus.Size = new System.Drawing.Size(123, 34);
            this.btnAddStatus.TabIndex = 81;
            this.btnAddStatus.Tag = "CreateLine";
            this.btnAddStatus.Text = "Добавить запись";
            this.btnAddStatus.UseVisualStyleBackColor = true;
            this.btnAddStatus.Click += new System.EventHandler(this.btnAddStatus_Click);
            // 
            // txtStatusName
            // 
            this.txtStatusName.Location = new System.Drawing.Point(102, 103);
            this.txtStatusName.Name = "txtStatusName";
            this.txtStatusName.Size = new System.Drawing.Size(245, 20);
            this.txtStatusName.TabIndex = 66;
            this.txtStatusName.Tag = "CreateLine";
            // 
            // labelStatusName
            // 
            this.labelStatusName.AutoSize = true;
            this.labelStatusName.Location = new System.Drawing.Point(36, 106);
            this.labelStatusName.Name = "labelStatusName";
            this.labelStatusName.Size = new System.Drawing.Size(60, 13);
            this.labelStatusName.TabIndex = 65;
            this.labelStatusName.Tag = "CreateLine";
            this.labelStatusName.Text = "Название:";
            // 
            // funcsCmbStatus
            // 
            this.funcsCmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcsCmbStatus.FormattingEnabled = true;
            this.funcsCmbStatus.Items.AddRange(new object[] {
            "Добавить строку",
            "Редактировать строку"});
            this.funcsCmbStatus.Location = new System.Drawing.Point(6, 26);
            this.funcsCmbStatus.Name = "funcsCmbStatus";
            this.funcsCmbStatus.Size = new System.Drawing.Size(121, 21);
            this.funcsCmbStatus.TabIndex = 64;
            this.funcsCmbStatus.Tag = "base";
            // 
            // funcsLabelStatus
            // 
            this.funcsLabelStatus.AutoSize = true;
            this.funcsLabelStatus.Location = new System.Drawing.Point(3, 9);
            this.funcsLabelStatus.Name = "funcsLabelStatus";
            this.funcsLabelStatus.Size = new System.Drawing.Size(56, 13);
            this.funcsLabelStatus.TabIndex = 63;
            this.funcsLabelStatus.Tag = "base";
            this.funcsLabelStatus.Text = "Функции:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.47488F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.52512F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1095, 574);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(699, 568);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 574);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.itemViewTab.ResumeLayout(false);
            this.itemViewTab.PerformLayout();
            this.typesTab.ResumeLayout(false);
            this.typesTab.PerformLayout();
            this.materialsTab.ResumeLayout(false);
            this.materialsTab.PerformLayout();
            this.productsTab.ResumeLayout(false);
            this.productsTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage itemViewTab;
        private Button delBtn;
        private Button editBtn;
        private TextBox txtRating;
        private Label labelRating;
        private TextBox txtPhone;
        private Label labelMainPhone;
        private TextBox txtDirector;
        private Label labelMainDirector;
        private ComboBox cmbType;
        private Label labelMainType;
        private Button btnAddMain;
        private TextBox txtName;
        private Label labelMainName;
        private ComboBox funcsCmbMain;
        private Label funcsLabelMain;
        private TabPage typesTab;
        private Button btnDelTypes;
        private Button btnEditTypes;
        private Button btnAddTypes;
        private TextBox txtCollsName;
        private Label labelCollsName;
        private ComboBox funcsCmbColls;
        private Label funcsLabelColls;
        private TabPage materialsTab;
        private Button btnDelCond;
        private Button btnEditCond;
        private Button btnAddCond;
        private TextBox txtCondName;
        private Label labelCondName;
        private ComboBox funcsCmbCond;
        private Label funcsLabelCond;
        private TabPage productsTab;
        private Button btnDelStatus;
        private Button btnEditStatus;
        private Button btnAddStatus;
        private TextBox txtStatusName;
        private Label labelStatusName;
        private ComboBox funcsCmbStatus;
        private Label funcsLabelStatus;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelCondDef;
        private TextBox txtCondDef;
        private Label labelStatusPrice;
        private Label labelStatusArt;
        private Label labelStatusType;
        private TextBox txtStatusPrice;
        private TextBox txtStatusArt;
        private ComboBox cmbStatusType;
    }
}

