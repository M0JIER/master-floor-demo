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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.itemViewTab = new System.Windows.Forms.TabPage();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.labelMainPlace = new System.Windows.Forms.Label();
            this.cmbRare = new System.Windows.Forms.ComboBox();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.labelMainRare = new System.Windows.Forms.Label();
            this.labelMainCond = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.labelMainYear = new System.Windows.Forms.Label();
            this.cmbCollection = new System.Windows.Forms.ComboBox();
            this.labelMainColl = new System.Windows.Forms.Label();
            this.btnAddMain = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelMainName = new System.Windows.Forms.Label();
            this.funcsCmbMain = new System.Windows.Forms.ComboBox();
            this.funcsLabelMain = new System.Windows.Forms.Label();
            this.collsTab = new System.Windows.Forms.TabPage();
            this.btnDelColls = new System.Windows.Forms.Button();
            this.btnEditColls = new System.Windows.Forms.Button();
            this.btnAddColls = new System.Windows.Forms.Button();
            this.txtCollsName = new System.Windows.Forms.TextBox();
            this.labelCollsName = new System.Windows.Forms.Label();
            this.funcsCmbColls = new System.Windows.Forms.ComboBox();
            this.funcsLabelColls = new System.Windows.Forms.Label();
            this.condTab = new System.Windows.Forms.TabPage();
            this.btnDelCond = new System.Windows.Forms.Button();
            this.btnEditCond = new System.Windows.Forms.Button();
            this.btnAddCond = new System.Windows.Forms.Button();
            this.txtCondName = new System.Windows.Forms.TextBox();
            this.labelCondName = new System.Windows.Forms.Label();
            this.funcsCmbCond = new System.Windows.Forms.ComboBox();
            this.funcsLabelCond = new System.Windows.Forms.Label();
            this.statusTab = new System.Windows.Forms.TabPage();
            this.btnDelStatus = new System.Windows.Forms.Button();
            this.btnEditStatus = new System.Windows.Forms.Button();
            this.btnAddStatus = new System.Windows.Forms.Button();
            this.txtStatusName = new System.Windows.Forms.TextBox();
            this.labelStatusName = new System.Windows.Forms.Label();
            this.funcsCmbStatus = new System.Windows.Forms.ComboBox();
            this.funcsLabelStatus = new System.Windows.Forms.Label();
            this.raresTab = new System.Windows.Forms.TabPage();
            this.btnDelRare = new System.Windows.Forms.Button();
            this.btnEditRare = new System.Windows.Forms.Button();
            this.btnAddRare = new System.Windows.Forms.Button();
            this.txtRareName = new System.Windows.Forms.TextBox();
            this.labelRareName = new System.Windows.Forms.Label();
            this.funcsCmbRare = new System.Windows.Forms.ComboBox();
            this.funcsLabelRare = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.itemViewTab.SuspendLayout();
            this.collsTab.SuspendLayout();
            this.condTab.SuspendLayout();
            this.statusTab.SuspendLayout();
            this.raresTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.47488F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.52512F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1095, 574);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(699, 568);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.itemViewTab);
            this.tabControl1.Controls.Add(this.collsTab);
            this.tabControl1.Controls.Add(this.condTab);
            this.tabControl1.Controls.Add(this.statusTab);
            this.tabControl1.Controls.Add(this.raresTab);
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
            this.itemViewTab.Controls.Add(this.txtValue);
            this.itemViewTab.Controls.Add(this.labelValue);
            this.itemViewTab.Controls.Add(this.cmbStatus);
            this.itemViewTab.Controls.Add(this.labelStatus);
            this.itemViewTab.Controls.Add(this.txtPlace);
            this.itemViewTab.Controls.Add(this.labelMainPlace);
            this.itemViewTab.Controls.Add(this.cmbRare);
            this.itemViewTab.Controls.Add(this.cmbCondition);
            this.itemViewTab.Controls.Add(this.labelMainRare);
            this.itemViewTab.Controls.Add(this.labelMainCond);
            this.itemViewTab.Controls.Add(this.txtYear);
            this.itemViewTab.Controls.Add(this.labelMainYear);
            this.itemViewTab.Controls.Add(this.cmbCollection);
            this.itemViewTab.Controls.Add(this.labelMainColl);
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
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(107, 272);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(240, 20);
            this.txtValue.TabIndex = 62;
            this.txtValue.Tag = "CreateLine, EditLine";
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(36, 275);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(65, 13);
            this.labelValue.TabIndex = 61;
            this.labelValue.Tag = "CreateLine, EditLine";
            this.labelValue.Text = "Стоимость:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(86, 240);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(260, 21);
            this.cmbStatus.TabIndex = 60;
            this.cmbStatus.Tag = "CreateLine, EditLine";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(36, 243);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 13);
            this.labelStatus.TabIndex = 59;
            this.labelStatus.Tag = "CreateLine, EditLine";
            this.labelStatus.Text = "Статус:";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(134, 212);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(213, 20);
            this.txtPlace.TabIndex = 58;
            this.txtPlace.Tag = "CreateLine, EditLine";
            // 
            // labelMainPlace
            // 
            this.labelMainPlace.AutoSize = true;
            this.labelMainPlace.Location = new System.Drawing.Point(36, 215);
            this.labelMainPlace.Name = "labelMainPlace";
            this.labelMainPlace.Size = new System.Drawing.Size(92, 13);
            this.labelMainPlace.TabIndex = 57;
            this.labelMainPlace.Tag = "CreateLine, EditLine";
            this.labelMainPlace.Text = "Место хранения:";
            // 
            // cmbRare
            // 
            this.cmbRare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRare.FormattingEnabled = true;
            this.cmbRare.Location = new System.Drawing.Point(100, 182);
            this.cmbRare.Name = "cmbRare";
            this.cmbRare.Size = new System.Drawing.Size(246, 21);
            this.cmbRare.TabIndex = 56;
            this.cmbRare.Tag = "CreateLine, EditLine";
            // 
            // cmbCondition
            // 
            this.cmbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Location = new System.Drawing.Point(106, 154);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(241, 21);
            this.cmbCondition.TabIndex = 55;
            this.cmbCondition.Tag = "CreateLine, EditLine";
            // 
            // labelMainRare
            // 
            this.labelMainRare.AutoSize = true;
            this.labelMainRare.Location = new System.Drawing.Point(36, 185);
            this.labelMainRare.Name = "labelMainRare";
            this.labelMainRare.Size = new System.Drawing.Size(58, 13);
            this.labelMainRare.TabIndex = 54;
            this.labelMainRare.Tag = "CreateLine, EditLine";
            this.labelMainRare.Text = "Редкость:";
            // 
            // labelMainCond
            // 
            this.labelMainCond.AutoSize = true;
            this.labelMainCond.Location = new System.Drawing.Point(36, 157);
            this.labelMainCond.Name = "labelMainCond";
            this.labelMainCond.Size = new System.Drawing.Size(64, 13);
            this.labelMainCond.TabIndex = 52;
            this.labelMainCond.Tag = "CreateLine, EditLine";
            this.labelMainCond.Text = "Состояние:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(70, 128);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(277, 20);
            this.txtYear.TabIndex = 51;
            this.txtYear.Tag = "CreateLine, EditLine";
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // labelMainYear
            // 
            this.labelMainYear.AutoSize = true;
            this.labelMainYear.Location = new System.Drawing.Point(36, 131);
            this.labelMainYear.Name = "labelMainYear";
            this.labelMainYear.Size = new System.Drawing.Size(28, 13);
            this.labelMainYear.TabIndex = 50;
            this.labelMainYear.Tag = "CreateLine, EditLine";
            this.labelMainYear.Text = "Год:";
            // 
            // cmbCollection
            // 
            this.cmbCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollection.FormattingEnabled = true;
            this.cmbCollection.Location = new System.Drawing.Point(107, 99);
            this.cmbCollection.Name = "cmbCollection";
            this.cmbCollection.Size = new System.Drawing.Size(239, 21);
            this.cmbCollection.TabIndex = 49;
            this.cmbCollection.Tag = "CreateLine, EditLine";
            // 
            // labelMainColl
            // 
            this.labelMainColl.AutoSize = true;
            this.labelMainColl.Location = new System.Drawing.Point(36, 102);
            this.labelMainColl.Name = "labelMainColl";
            this.labelMainColl.Size = new System.Drawing.Size(65, 13);
            this.labelMainColl.TabIndex = 48;
            this.labelMainColl.Tag = "CreateLine, EditLine";
            this.labelMainColl.Text = "Коллекция:";
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
            this.txtName.Location = new System.Drawing.Point(102, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 20);
            this.txtName.TabIndex = 46;
            this.txtName.Tag = "CreateLine, EditLine";
            // 
            // labelMainName
            // 
            this.labelMainName.AutoSize = true;
            this.labelMainName.Location = new System.Drawing.Point(36, 74);
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
            "Редактировать строку",
            "Просмотр с фильтрами"});
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
            // collsTab
            // 
            this.collsTab.Controls.Add(this.btnDelColls);
            this.collsTab.Controls.Add(this.btnEditColls);
            this.collsTab.Controls.Add(this.btnAddColls);
            this.collsTab.Controls.Add(this.txtCollsName);
            this.collsTab.Controls.Add(this.labelCollsName);
            this.collsTab.Controls.Add(this.funcsCmbColls);
            this.collsTab.Controls.Add(this.funcsLabelColls);
            this.collsTab.Location = new System.Drawing.Point(4, 22);
            this.collsTab.Name = "collsTab";
            this.collsTab.Padding = new System.Windows.Forms.Padding(3);
            this.collsTab.Size = new System.Drawing.Size(376, 542);
            this.collsTab.TabIndex = 1;
            this.collsTab.Text = "Коллекции";
            this.collsTab.UseVisualStyleBackColor = true;
            // 
            // btnDelColls
            // 
            this.btnDelColls.Location = new System.Drawing.Point(188, 429);
            this.btnDelColls.Name = "btnDelColls";
            this.btnDelColls.Size = new System.Drawing.Size(123, 34);
            this.btnDelColls.TabIndex = 83;
            this.btnDelColls.Tag = "EditLine";
            this.btnDelColls.Text = "Удалить запись";
            this.btnDelColls.UseVisualStyleBackColor = true;
            this.btnDelColls.Visible = false;
            this.btnDelColls.Click += new System.EventHandler(this.btnDelColls_Click);
            // 
            // btnEditColls
            // 
            this.btnEditColls.Location = new System.Drawing.Point(59, 429);
            this.btnEditColls.Name = "btnEditColls";
            this.btnEditColls.Size = new System.Drawing.Size(123, 34);
            this.btnEditColls.TabIndex = 82;
            this.btnEditColls.Tag = "EditLine";
            this.btnEditColls.Text = "Изменить запись";
            this.btnEditColls.UseVisualStyleBackColor = true;
            this.btnEditColls.Visible = false;
            this.btnEditColls.Click += new System.EventHandler(this.btnEditColls_Click);
            // 
            // btnAddColls
            // 
            this.btnAddColls.Location = new System.Drawing.Point(110, 469);
            this.btnAddColls.Name = "btnAddColls";
            this.btnAddColls.Size = new System.Drawing.Size(123, 34);
            this.btnAddColls.TabIndex = 81;
            this.btnAddColls.Tag = "CreateLine";
            this.btnAddColls.Text = "Добавить запись";
            this.btnAddColls.UseVisualStyleBackColor = true;
            this.btnAddColls.Click += new System.EventHandler(this.btnAddColls_Click);
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
            // condTab
            // 
            this.condTab.Controls.Add(this.btnDelCond);
            this.condTab.Controls.Add(this.btnEditCond);
            this.condTab.Controls.Add(this.btnAddCond);
            this.condTab.Controls.Add(this.txtCondName);
            this.condTab.Controls.Add(this.labelCondName);
            this.condTab.Controls.Add(this.funcsCmbCond);
            this.condTab.Controls.Add(this.funcsLabelCond);
            this.condTab.Location = new System.Drawing.Point(4, 22);
            this.condTab.Name = "condTab";
            this.condTab.Size = new System.Drawing.Size(376, 542);
            this.condTab.TabIndex = 2;
            this.condTab.Text = "Состояния";
            this.condTab.UseVisualStyleBackColor = true;
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
            "Редактировать строку",
            "Просмотр с фильтрами"});
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
            // statusTab
            // 
            this.statusTab.Controls.Add(this.btnDelStatus);
            this.statusTab.Controls.Add(this.btnEditStatus);
            this.statusTab.Controls.Add(this.btnAddStatus);
            this.statusTab.Controls.Add(this.txtStatusName);
            this.statusTab.Controls.Add(this.labelStatusName);
            this.statusTab.Controls.Add(this.funcsCmbStatus);
            this.statusTab.Controls.Add(this.funcsLabelStatus);
            this.statusTab.Location = new System.Drawing.Point(4, 22);
            this.statusTab.Name = "statusTab";
            this.statusTab.Size = new System.Drawing.Size(376, 542);
            this.statusTab.TabIndex = 3;
            this.statusTab.Text = "Статусы";
            this.statusTab.UseVisualStyleBackColor = true;
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
            "Редактировать строку",
            "Просмотр с фильтрами"});
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
            // raresTab
            // 
            this.raresTab.Controls.Add(this.btnDelRare);
            this.raresTab.Controls.Add(this.btnEditRare);
            this.raresTab.Controls.Add(this.btnAddRare);
            this.raresTab.Controls.Add(this.txtRareName);
            this.raresTab.Controls.Add(this.labelRareName);
            this.raresTab.Controls.Add(this.funcsCmbRare);
            this.raresTab.Controls.Add(this.funcsLabelRare);
            this.raresTab.Location = new System.Drawing.Point(4, 22);
            this.raresTab.Name = "raresTab";
            this.raresTab.Size = new System.Drawing.Size(376, 542);
            this.raresTab.TabIndex = 4;
            this.raresTab.Text = "Редкости";
            this.raresTab.UseVisualStyleBackColor = true;
            // 
            // btnDelRare
            // 
            this.btnDelRare.Location = new System.Drawing.Point(190, 431);
            this.btnDelRare.Name = "btnDelRare";
            this.btnDelRare.Size = new System.Drawing.Size(123, 34);
            this.btnDelRare.TabIndex = 83;
            this.btnDelRare.Tag = "EditLine";
            this.btnDelRare.Text = "Удалить запись";
            this.btnDelRare.UseVisualStyleBackColor = true;
            this.btnDelRare.Visible = false;
            this.btnDelRare.Click += new System.EventHandler(this.btnDelRare_Click);
            // 
            // btnEditRare
            // 
            this.btnEditRare.Location = new System.Drawing.Point(61, 431);
            this.btnEditRare.Name = "btnEditRare";
            this.btnEditRare.Size = new System.Drawing.Size(123, 34);
            this.btnEditRare.TabIndex = 82;
            this.btnEditRare.Tag = "EditLine";
            this.btnEditRare.Text = "Изменить запись";
            this.btnEditRare.UseVisualStyleBackColor = true;
            this.btnEditRare.Visible = false;
            this.btnEditRare.Click += new System.EventHandler(this.btnEditRare_Click);
            // 
            // btnAddRare
            // 
            this.btnAddRare.Location = new System.Drawing.Point(122, 471);
            this.btnAddRare.Name = "btnAddRare";
            this.btnAddRare.Size = new System.Drawing.Size(123, 34);
            this.btnAddRare.TabIndex = 81;
            this.btnAddRare.Tag = "CreateLine";
            this.btnAddRare.Text = "Добавить запись";
            this.btnAddRare.UseVisualStyleBackColor = true;
            this.btnAddRare.Click += new System.EventHandler(this.btnAddRare_Click);
            // 
            // txtRareName
            // 
            this.txtRareName.Location = new System.Drawing.Point(102, 103);
            this.txtRareName.Name = "txtRareName";
            this.txtRareName.Size = new System.Drawing.Size(245, 20);
            this.txtRareName.TabIndex = 66;
            this.txtRareName.Tag = "CreateLine";
            // 
            // labelRareName
            // 
            this.labelRareName.AutoSize = true;
            this.labelRareName.Location = new System.Drawing.Point(36, 106);
            this.labelRareName.Name = "labelRareName";
            this.labelRareName.Size = new System.Drawing.Size(60, 13);
            this.labelRareName.TabIndex = 65;
            this.labelRareName.Tag = "CreateLine";
            this.labelRareName.Text = "Название:";
            // 
            // funcsCmbRare
            // 
            this.funcsCmbRare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcsCmbRare.FormattingEnabled = true;
            this.funcsCmbRare.Items.AddRange(new object[] {
            "Добавить строку",
            "Редактировать строку",
            "Просмотр с фильтрами"});
            this.funcsCmbRare.Location = new System.Drawing.Point(6, 26);
            this.funcsCmbRare.Name = "funcsCmbRare";
            this.funcsCmbRare.Size = new System.Drawing.Size(121, 21);
            this.funcsCmbRare.TabIndex = 64;
            this.funcsCmbRare.Tag = "base";
            // 
            // funcsLabelRare
            // 
            this.funcsLabelRare.AutoSize = true;
            this.funcsLabelRare.Location = new System.Drawing.Point(3, 9);
            this.funcsLabelRare.Name = "funcsLabelRare";
            this.funcsLabelRare.Size = new System.Drawing.Size(56, 13);
            this.funcsLabelRare.TabIndex = 63;
            this.funcsLabelRare.Tag = "base";
            this.funcsLabelRare.Text = "Функции:";
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
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.itemViewTab.ResumeLayout(false);
            this.itemViewTab.PerformLayout();
            this.collsTab.ResumeLayout(false);
            this.collsTab.PerformLayout();
            this.condTab.ResumeLayout(false);
            this.condTab.PerformLayout();
            this.statusTab.ResumeLayout(false);
            this.statusTab.PerformLayout();
            this.raresTab.ResumeLayout(false);
            this.raresTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage itemViewTab;
        private System.Windows.Forms.Button btnAddMain;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelMainName;
        private System.Windows.Forms.ComboBox funcsCmbMain;
        private System.Windows.Forms.Label funcsLabelMain;
        private System.Windows.Forms.TabPage collsTab;
        private System.Windows.Forms.Label labelMainColl;
        private System.Windows.Forms.ComboBox cmbCollection;
        private System.Windows.Forms.Label labelMainYear;
        private System.Windows.Forms.Label labelMainCond;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label labelMainPlace;
        private System.Windows.Forms.ComboBox cmbRare;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.Label labelMainRare;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.TabPage condTab;
        private System.Windows.Forms.TabPage statusTab;
        private System.Windows.Forms.TabPage raresTab;
        private System.Windows.Forms.TextBox txtCollsName;
        private System.Windows.Forms.Label labelCollsName;
        private System.Windows.Forms.ComboBox funcsCmbColls;
        private System.Windows.Forms.Label funcsLabelColls;
        private System.Windows.Forms.TextBox txtCondName;
        private System.Windows.Forms.Label labelCondName;
        private System.Windows.Forms.ComboBox funcsCmbCond;
        private System.Windows.Forms.Label funcsLabelCond;
        private System.Windows.Forms.TextBox txtStatusName;
        private System.Windows.Forms.Label labelStatusName;
        private System.Windows.Forms.ComboBox funcsCmbStatus;
        private System.Windows.Forms.Label funcsLabelStatus;
        private System.Windows.Forms.TextBox txtRareName;
        private System.Windows.Forms.Label labelRareName;
        private System.Windows.Forms.ComboBox funcsCmbRare;
        private System.Windows.Forms.Label funcsLabelRare;
        private System.Windows.Forms.Button btnAddColls;
        private System.Windows.Forms.Button btnAddCond;
        private System.Windows.Forms.Button btnAddStatus;
        private System.Windows.Forms.Button btnAddRare;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button btnDelColls;
        private System.Windows.Forms.Button btnEditColls;
        private System.Windows.Forms.Button btnDelCond;
        private System.Windows.Forms.Button btnEditCond;
        private System.Windows.Forms.Button btnDelStatus;
        private System.Windows.Forms.Button btnEditStatus;
        private System.Windows.Forms.Button btnDelRare;
        private System.Windows.Forms.Button btnEditRare;
    }
}

