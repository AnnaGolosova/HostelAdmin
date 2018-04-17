namespace HostelAdmin.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem комнатыMenuItem1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.просмотрДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заселениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жильцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инвентарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдачаИнвентаряToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменениеДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OccupancyDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерКомнаты = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Этаж = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пол = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаЗаселения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаВыселения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.LiversDGV = new System.Windows.Forms.DataGridView();
            this.Код = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.жильцыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDataSet = new HostelAdmin.HostelDataSet();
            this.RoomDGV = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.этажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комнатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PositionsDGV = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.жильцыTableAdapter = new HostelAdmin.HostelDataSetTableAdapters.ЖильцыTableAdapter();
            this.комнатыTableAdapter = new HostelAdmin.HostelDataSetTableAdapters.КомнатыTableAdapter();
            this.должностиTableAdapter = new HostelAdmin.HostelDataSetTableAdapters.ДолжностиTableAdapter();
            this.InventoryDGV = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количестваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.инвентарьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.инвентарьTableAdapter = new HostelAdmin.HostelDataSetTableAdapters.ИнвентарьTableAdapter();
            this.DeliveryDGV = new System.Windows.Forms.DataGridView();
            this.IdDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФиоЖильца = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФиоСотрудника = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаВыдачи = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаСдачи = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddB = new System.Windows.Forms.Button();
            this.EmployeersDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИОСотрудника2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.АдресСот = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViolationDGV = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нарушенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditDelivery = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteDelivery = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteInventory = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeletePosition = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteRoom = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteLiver = new System.Windows.Forms.DataGridViewImageColumn();
            комнатыMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OccupancyDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiversDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жильцыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.комнатыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.инвентарьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViolationDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // комнатыMenuItem1
            // 
            комнатыMenuItem1.Name = "комнатыMenuItem1";
            комнатыMenuItem1.Size = new System.Drawing.Size(249, 26);
            комнатыMenuItem1.Text = "Комнаты";
            комнатыMenuItem1.Click += new System.EventHandler(this.комнатыMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Purple;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрДанныхToolStripMenuItem,
            this.изменениеДанныхToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1130, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // просмотрДанныхToolStripMenuItem
            // 
            this.просмотрДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заселениеToolStripMenuItem,
            this.жильцыToolStripMenuItem,
            комнатыMenuItem1,
            this.должностиToolStripMenuItem,
            this.инвентарьToolStripMenuItem,
            this.выдачаИнвентаряToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.нарушенияToolStripMenuItem});
            this.просмотрДанныхToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.просмотрДанныхToolStripMenuItem.Name = "просмотрДанныхToolStripMenuItem";
            this.просмотрДанныхToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.просмотрДанныхToolStripMenuItem.Text = "Просмотр данных";
            // 
            // заселениеToolStripMenuItem
            // 
            this.заселениеToolStripMenuItem.Name = "заселениеToolStripMenuItem";
            this.заселениеToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.заселениеToolStripMenuItem.Text = "Заселения";
            this.заселениеToolStripMenuItem.Click += new System.EventHandler(this.заселениеToolStripMenuItem_Click);
            // 
            // жильцыToolStripMenuItem
            // 
            this.жильцыToolStripMenuItem.Name = "жильцыToolStripMenuItem";
            this.жильцыToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.жильцыToolStripMenuItem.Text = "Жильцы";
            this.жильцыToolStripMenuItem.Click += new System.EventHandler(this.жильцыToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // инвентарьToolStripMenuItem
            // 
            this.инвентарьToolStripMenuItem.Name = "инвентарьToolStripMenuItem";
            this.инвентарьToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.инвентарьToolStripMenuItem.Text = "Инвентарь";
            this.инвентарьToolStripMenuItem.Click += new System.EventHandler(this.инвентарьToolStripMenuItem_Click);
            // 
            // выдачаИнвентаряToolStripMenuItem
            // 
            this.выдачаИнвентаряToolStripMenuItem.Name = "выдачаИнвентаряToolStripMenuItem";
            this.выдачаИнвентаряToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.выдачаИнвентаряToolStripMenuItem.Text = "Выдача инвентаря";
            this.выдачаИнвентаряToolStripMenuItem.Click += new System.EventHandler(this.выдачаИнвентаряToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // изменениеДанныхToolStripMenuItem
            // 
            this.изменениеДанныхToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.изменениеДанныхToolStripMenuItem.Name = "изменениеДанныхToolStripMenuItem";
            this.изменениеДанныхToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.изменениеДанныхToolStripMenuItem.Text = "Изменение данных";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро пожаловать в ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(521, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Систему управления работы общежития";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(539, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дня начала работы выберите один из пунктов меню сверху";
            // 
            // OccupancyDGV
            // 
            this.OccupancyDGV.AllowUserToAddRows = false;
            this.OccupancyDGV.AllowUserToDeleteRows = false;
            this.OccupancyDGV.AllowUserToResizeRows = false;
            this.OccupancyDGV.BackgroundColor = System.Drawing.Color.Azure;
            this.OccupancyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OccupancyDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdRoom,
            this.НомерКомнаты,
            this.ФИО,
            this.Этаж,
            this.Адрес,
            this.Пол,
            this.ДатаЗаселения,
            this.ДатаВыселения,
            this.Edit,
            this.Delete});
            this.OccupancyDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OccupancyDGV.GridColor = System.Drawing.Color.Azure;
            this.OccupancyDGV.Location = new System.Drawing.Point(0, 28);
            this.OccupancyDGV.Name = "OccupancyDGV";
            this.OccupancyDGV.RowTemplate.Height = 24;
            this.OccupancyDGV.Size = new System.Drawing.Size(1130, 518);
            this.OccupancyDGV.TabIndex = 4;
            this.OccupancyDGV.Visible = false;
            this.OccupancyDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OccupancyDGV_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // IdRoom
            // 
            this.IdRoom.HeaderText = "IdRoom";
            this.IdRoom.Name = "IdRoom";
            this.IdRoom.Visible = false;
            // 
            // НомерКомнаты
            // 
            this.НомерКомнаты.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.НомерКомнаты.HeaderText = "Номер Комнаты";
            this.НомерКомнаты.Name = "НомерКомнаты";
            this.НомерКомнаты.ReadOnly = true;
            this.НомерКомнаты.Width = 162;
            // 
            // ФИО
            // 
            this.ФИО.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            this.ФИО.ReadOnly = true;
            // 
            // Этаж
            // 
            this.Этаж.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Этаж.HeaderText = "Этаж";
            this.Этаж.Name = "Этаж";
            this.Этаж.ReadOnly = true;
            this.Этаж.Width = 82;
            // 
            // Адрес
            // 
            this.Адрес.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Адрес.HeaderText = "Адрес";
            this.Адрес.Name = "Адрес";
            this.Адрес.ReadOnly = true;
            // 
            // Пол
            // 
            this.Пол.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Пол.HeaderText = "Пол";
            this.Пол.Name = "Пол";
            this.Пол.ReadOnly = true;
            this.Пол.Width = 72;
            // 
            // ДатаЗаселения
            // 
            this.ДатаЗаселения.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ДатаЗаселения.HeaderText = "Дата Заселения";
            this.ДатаЗаселения.Name = "ДатаЗаселения";
            this.ДатаЗаселения.ReadOnly = true;
            // 
            // ДатаВыселения
            // 
            this.ДатаВыселения.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ДатаВыселения.HeaderText = "Дата Выселения";
            this.ДатаВыселения.Name = "ДатаВыселения";
            this.ДатаВыселения.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 50;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 50;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 50;
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.BackColor = System.Drawing.Color.Aquamarine;
            this.SuccessLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SuccessLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuccessLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.SuccessLabel.Location = new System.Drawing.Point(0, 516);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(1130, 30);
            this.SuccessLabel.TabIndex = 5;
            this.SuccessLabel.Text = "Приложение готово к работе";
            this.SuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SuccessLabel.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BackColor = System.Drawing.Color.LightPink;
            this.ErrorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrorLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorLabel.Location = new System.Drawing.Point(0, 486);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(1130, 30);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.Text = "Приложение готово к работе";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // LiversDGV
            // 
            this.LiversDGV.AutoGenerateColumns = false;
            this.LiversDGV.BackgroundColor = System.Drawing.Color.Azure;
            this.LiversDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LiversDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код,
            this.фИОDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1,
            this.DeleteLiver});
            this.LiversDGV.DataSource = this.жильцыBindingSource;
            this.LiversDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LiversDGV.Location = new System.Drawing.Point(0, 28);
            this.LiversDGV.Name = "LiversDGV";
            this.LiversDGV.RowTemplate.Height = 24;
            this.LiversDGV.Size = new System.Drawing.Size(1130, 458);
            this.LiversDGV.TabIndex = 7;
            this.LiversDGV.VirtualMode = true;
            this.LiversDGV.Visible = false;
            this.LiversDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LiversDGV_CellClick);
            this.LiversDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.LiversDGV_CellFormatting);
            this.LiversDGV.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.LiversDGV_RowValidating);
            // 
            // Код
            // 
            this.Код.DataPropertyName = "Код";
            this.Код.HeaderText = "Код";
            this.Код.Name = "Код";
            this.Код.ReadOnly = true;
            this.Код.Visible = false;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Пол";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Пол";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // жильцыBindingSource
            // 
            this.жильцыBindingSource.DataMember = "Жильцы";
            this.жильцыBindingSource.DataSource = this.hostelDataSet;
            // 
            // hostelDataSet
            // 
            this.hostelDataSet.DataSetName = "HostelDataSet";
            this.hostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RoomDGV
            // 
            this.RoomDGV.AutoGenerateColumns = false;
            this.RoomDGV.BackgroundColor = System.Drawing.Color.Azure;
            this.RoomDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.этажDataGridViewTextBoxColumn,
            this.номерКомнатыDataGridViewTextBoxColumn,
            this.DeleteRoom});
            this.RoomDGV.DataSource = this.комнатыBindingSource;
            this.RoomDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomDGV.Location = new System.Drawing.Point(0, 28);
            this.RoomDGV.Name = "RoomDGV";
            this.RoomDGV.RowTemplate.Height = 24;
            this.RoomDGV.Size = new System.Drawing.Size(1130, 458);
            this.RoomDGV.TabIndex = 8;
            this.RoomDGV.VirtualMode = true;
            this.RoomDGV.Visible = false;
            this.RoomDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomDGV_CellClick);
            this.RoomDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.LiversDGV_CellFormatting);
            this.RoomDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.RoomDGV_DataError);
            this.RoomDGV.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.RoomDGV_RowValidating);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Visible = false;
            // 
            // этажDataGridViewTextBoxColumn
            // 
            this.этажDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.этажDataGridViewTextBoxColumn.DataPropertyName = "Этаж";
            this.этажDataGridViewTextBoxColumn.HeaderText = "Этаж";
            this.этажDataGridViewTextBoxColumn.Name = "этажDataGridViewTextBoxColumn";
            // 
            // номерКомнатыDataGridViewTextBoxColumn
            // 
            this.номерКомнатыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.номерКомнатыDataGridViewTextBoxColumn.DataPropertyName = "НомерКомнаты";
            this.номерКомнатыDataGridViewTextBoxColumn.HeaderText = "НомерКомнаты";
            this.номерКомнатыDataGridViewTextBoxColumn.Name = "номерКомнатыDataGridViewTextBoxColumn";
            // 
            // комнатыBindingSource
            // 
            this.комнатыBindingSource.DataMember = "Комнаты";
            this.комнатыBindingSource.DataSource = this.hostelDataSet;
            // 
            // PositionsDGV
            // 
            this.PositionsDGV.AutoGenerateColumns = false;
            this.PositionsDGV.BackgroundColor = System.Drawing.Color.Azure;
            this.PositionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PositionsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn,
            this.DeletePosition});
            this.PositionsDGV.DataSource = this.должностиBindingSource;
            this.PositionsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionsDGV.Location = new System.Drawing.Point(0, 28);
            this.PositionsDGV.Name = "PositionsDGV";
            this.PositionsDGV.RowTemplate.Height = 24;
            this.PositionsDGV.Size = new System.Drawing.Size(1130, 458);
            this.PositionsDGV.TabIndex = 9;
            this.PositionsDGV.Visible = false;
            this.PositionsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PositionsDGV_CellClick);
            this.PositionsDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.LiversDGV_CellFormatting);
            this.PositionsDGV.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.PositionsDGV_CellValidating);
            this.PositionsDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.PositionsDGV_DataError);
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            this.кодDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn1.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.hostelDataSet;
            // 
            // жильцыTableAdapter
            // 
            this.жильцыTableAdapter.ClearBeforeFill = true;
            // 
            // комнатыTableAdapter
            // 
            this.комнатыTableAdapter.ClearBeforeFill = true;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryDGV
            // 
            this.InventoryDGV.AutoGenerateColumns = false;
            this.InventoryDGV.BackgroundColor = System.Drawing.Color.Azure;
            this.InventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn2,
            this.названиеDataGridViewTextBoxColumn1,
            this.количестваDataGridViewTextBoxColumn,
            this.DeleteInventory});
            this.InventoryDGV.DataSource = this.инвентарьBindingSource;
            this.InventoryDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryDGV.Location = new System.Drawing.Point(0, 28);
            this.InventoryDGV.Name = "InventoryDGV";
            this.InventoryDGV.RowTemplate.Height = 24;
            this.InventoryDGV.Size = new System.Drawing.Size(1130, 458);
            this.InventoryDGV.TabIndex = 10;
            this.InventoryDGV.VirtualMode = true;
            this.InventoryDGV.Visible = false;
            this.InventoryDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.InventoryDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.LiversDGV_CellFormatting);
            this.InventoryDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.PositionsDGV_DataError);
            this.InventoryDGV.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.InventoryDGV_RowValidating);
            // 
            // кодDataGridViewTextBoxColumn2
            // 
            this.кодDataGridViewTextBoxColumn2.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn2.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn2.Name = "кодDataGridViewTextBoxColumn2";
            this.кодDataGridViewTextBoxColumn2.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn2.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            // 
            // количестваDataGridViewTextBoxColumn
            // 
            this.количестваDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.количестваDataGridViewTextBoxColumn.DataPropertyName = "Количества";
            this.количестваDataGridViewTextBoxColumn.HeaderText = "Количества";
            this.количестваDataGridViewTextBoxColumn.Name = "количестваDataGridViewTextBoxColumn";
            // 
            // инвентарьBindingSource
            // 
            this.инвентарьBindingSource.DataMember = "Инвентарь";
            this.инвентарьBindingSource.DataSource = this.hostelDataSet;
            // 
            // инвентарьTableAdapter
            // 
            this.инвентарьTableAdapter.ClearBeforeFill = true;
            // 
            // DeliveryDGV
            // 
            this.DeliveryDGV.AllowUserToAddRows = false;
            this.DeliveryDGV.AllowUserToDeleteRows = false;
            this.DeliveryDGV.BackgroundColor = System.Drawing.Color.Azure;
            this.DeliveryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDelivery,
            this.ФиоЖильца,
            this.Название,
            this.ФиоСотрудника,
            this.Количество,
            this.ДатаВыдачи,
            this.ДатаСдачи,
            this.EditDelivery,
            this.DeleteDelivery});
            this.DeliveryDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeliveryDGV.Location = new System.Drawing.Point(0, 28);
            this.DeliveryDGV.Name = "DeliveryDGV";
            this.DeliveryDGV.ReadOnly = true;
            this.DeliveryDGV.RowTemplate.Height = 24;
            this.DeliveryDGV.Size = new System.Drawing.Size(1130, 458);
            this.DeliveryDGV.TabIndex = 11;
            this.DeliveryDGV.Visible = false;
            this.DeliveryDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeliveryDGV_CellClick);
            // 
            // IdDelivery
            // 
            this.IdDelivery.HeaderText = "";
            this.IdDelivery.MinimumWidth = 50;
            this.IdDelivery.Name = "IdDelivery";
            this.IdDelivery.ReadOnly = true;
            this.IdDelivery.Visible = false;
            this.IdDelivery.Width = 50;
            // 
            // ФиоЖильца
            // 
            this.ФиоЖильца.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ФиоЖильца.HeaderText = "Фио Жильца";
            this.ФиоЖильца.Name = "ФиоЖильца";
            this.ФиоЖильца.ReadOnly = true;
            // 
            // Название
            // 
            this.Название.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Название.HeaderText = "Название инвентаря";
            this.Название.Name = "Название";
            this.Название.ReadOnly = true;
            this.Название.Width = 199;
            // 
            // ФиоСотрудника
            // 
            this.ФиоСотрудника.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ФиоСотрудника.HeaderText = "Фио Сотрудника";
            this.ФиоСотрудника.Name = "ФиоСотрудника";
            this.ФиоСотрудника.ReadOnly = true;
            // 
            // Количество
            // 
            this.Количество.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Количество.HeaderText = "Количество";
            this.Количество.Name = "Количество";
            this.Количество.ReadOnly = true;
            this.Количество.Width = 139;
            // 
            // ДатаВыдачи
            // 
            this.ДатаВыдачи.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ДатаВыдачи.HeaderText = "Дата Выдачи";
            this.ДатаВыдачи.Name = "ДатаВыдачи";
            this.ДатаВыдачи.ReadOnly = true;
            this.ДатаВыдачи.Width = 140;
            // 
            // ДатаСдачи
            // 
            this.ДатаСдачи.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ДатаСдачи.HeaderText = "Дата Сдачи";
            this.ДатаСдачи.Name = "ДатаСдачи";
            this.ДатаСдачи.ReadOnly = true;
            this.ДатаСдачи.Width = 127;
            // 
            // AddB
            // 
            this.AddB.BackColor = System.Drawing.Color.Purple;
            this.AddB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddB.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddB.Location = new System.Drawing.Point(954, 503);
            this.AddB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(161, 29);
            this.AddB.TabIndex = 12;
            this.AddB.Text = "Добавить";
            this.AddB.UseVisualStyleBackColor = false;
            this.AddB.Visible = false;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // EmployeersDGV
            // 
            this.EmployeersDGV.AllowUserToAddRows = false;
            this.EmployeersDGV.AllowUserToDeleteRows = false;
            this.EmployeersDGV.BackgroundColor = System.Drawing.Color.Azure;
            this.EmployeersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ФИОСотрудника2,
            this.Position,
            this.АдресСот,
            this.Column2,
            this.Column3});
            this.EmployeersDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeersDGV.Location = new System.Drawing.Point(0, 28);
            this.EmployeersDGV.Name = "EmployeersDGV";
            this.EmployeersDGV.ReadOnly = true;
            this.EmployeersDGV.RowTemplate.Height = 24;
            this.EmployeersDGV.Size = new System.Drawing.Size(1130, 458);
            this.EmployeersDGV.TabIndex = 13;
            this.EmployeersDGV.Visible = false;
            this.EmployeersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeersDGV_CellClick);
            this.EmployeersDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.EmployeersDGV_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // ФИОСотрудника2
            // 
            this.ФИОСотрудника2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ФИОСотрудника2.HeaderText = "ФИО";
            this.ФИОСотрудника2.Name = "ФИОСотрудника2";
            this.ФИОСотрудника2.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Position.HeaderText = "Должность";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 134;
            // 
            // АдресСот
            // 
            this.АдресСот.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.АдресСот.HeaderText = "Адрес";
            this.АдресСот.Name = "АдресСот";
            this.АдресСот.ReadOnly = true;
            // 
            // ViolationDGV
            // 
            this.ViolationDGV.AllowUserToAddRows = false;
            this.ViolationDGV.AllowUserToDeleteRows = false;
            this.ViolationDGV.AllowUserToResizeColumns = false;
            this.ViolationDGV.AllowUserToResizeRows = false;
            this.ViolationDGV.BackgroundColor = System.Drawing.Color.Azure;
            this.ViolationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViolationDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.ViolationDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViolationDGV.Location = new System.Drawing.Point(0, 28);
            this.ViolationDGV.Name = "ViolationDGV";
            this.ViolationDGV.RowTemplate.Height = 24;
            this.ViolationDGV.Size = new System.Drawing.Size(1130, 458);
            this.ViolationDGV.TabIndex = 14;
            this.ViolationDGV.Visible = false;
            this.ViolationDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViolationDGV_CellClick);
            this.ViolationDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ViolationDGV_CellFormatting);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "ФИО";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Состав нарушения";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Отработано";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 139;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Дата отработки";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 158;
            // 
            // нарушенияToolStripMenuItem
            // 
            this.нарушенияToolStripMenuItem.Name = "нарушенияToolStripMenuItem";
            this.нарушенияToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.нарушенияToolStripMenuItem.Text = "Нарушения";
            this.нарушенияToolStripMenuItem.Click += new System.EventHandler(this.нарушенияToolStripMenuItem_Click);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "null";
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.HeaderText = "";
            this.dataGridViewImageColumn5.Image = global::HostelAdmin.Resources.ic_mode_edit_black_18dp_1x;
            this.dataGridViewImageColumn5.MinimumWidth = 50;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.Width = 50;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.HeaderText = "";
            this.dataGridViewImageColumn6.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.dataGridViewImageColumn6.MinimumWidth = 50;
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.Width = 50;
            // 
            // dataGridViewImageColumn7
            // 
            this.dataGridViewImageColumn7.HeaderText = "";
            this.dataGridViewImageColumn7.Image = global::HostelAdmin.Resources.ic_mode_edit_black_18dp_1x;
            this.dataGridViewImageColumn7.MinimumWidth = 50;
            this.dataGridViewImageColumn7.Name = "dataGridViewImageColumn7";
            this.dataGridViewImageColumn7.Width = 50;
            // 
            // dataGridViewImageColumn8
            // 
            this.dataGridViewImageColumn8.HeaderText = "";
            this.dataGridViewImageColumn8.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.dataGridViewImageColumn8.MinimumWidth = 50;
            this.dataGridViewImageColumn8.Name = "dataGridViewImageColumn8";
            this.dataGridViewImageColumn8.Width = 50;
            // 
            // dataGridViewImageColumn9
            // 
            this.dataGridViewImageColumn9.HeaderText = "";
            this.dataGridViewImageColumn9.Image = global::HostelAdmin.Resources.ic_mode_edit_black_18dp_1x;
            this.dataGridViewImageColumn9.Name = "dataGridViewImageColumn9";
            this.dataGridViewImageColumn9.ReadOnly = true;
            // 
            // dataGridViewImageColumn10
            // 
            this.dataGridViewImageColumn10.HeaderText = "";
            this.dataGridViewImageColumn10.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.dataGridViewImageColumn10.Name = "dataGridViewImageColumn10";
            this.dataGridViewImageColumn10.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "";
            this.Column9.Image = global::HostelAdmin.Resources.ic_mode_edit_black_18dp_1x;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "";
            this.Column10.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Image = global::HostelAdmin.Resources.ic_mode_edit_black_18dp_1x;
            this.Column2.MinimumWidth = 50;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.Column3.MinimumWidth = 50;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // EditDelivery
            // 
            this.EditDelivery.HeaderText = "";
            this.EditDelivery.Image = global::HostelAdmin.Resources.ic_mode_edit_black_18dp_1x;
            this.EditDelivery.MinimumWidth = 50;
            this.EditDelivery.Name = "EditDelivery";
            this.EditDelivery.ReadOnly = true;
            this.EditDelivery.Width = 50;
            // 
            // DeleteDelivery
            // 
            this.DeleteDelivery.HeaderText = "";
            this.DeleteDelivery.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.DeleteDelivery.MinimumWidth = 50;
            this.DeleteDelivery.Name = "DeleteDelivery";
            this.DeleteDelivery.ReadOnly = true;
            this.DeleteDelivery.Width = 50;
            // 
            // DeleteInventory
            // 
            this.DeleteInventory.HeaderText = "";
            this.DeleteInventory.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.DeleteInventory.Name = "DeleteInventory";
            // 
            // DeletePosition
            // 
            this.DeletePosition.HeaderText = "";
            this.DeletePosition.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.DeletePosition.Name = "DeletePosition";
            // 
            // DeleteRoom
            // 
            this.DeleteRoom.HeaderText = "";
            this.DeleteRoom.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.DeleteRoom.Name = "DeleteRoom";
            this.DeleteRoom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteRoom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DeleteLiver
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "null";
            this.DeleteLiver.DefaultCellStyle = dataGridViewCellStyle1;
            this.DeleteLiver.HeaderText = "";
            this.DeleteLiver.Image = global::HostelAdmin.Resources.ic_delete_forever_black_18dp_1x;
            this.DeleteLiver.MinimumWidth = 50;
            this.DeleteLiver.Name = "DeleteLiver";
            this.DeleteLiver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteLiver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteLiver.Width = 50;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1130, 546);
            this.Controls.Add(this.ViolationDGV);
            this.Controls.Add(this.EmployeersDGV);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.DeliveryDGV);
            this.Controls.Add(this.InventoryDGV);
            this.Controls.Add(this.PositionsDGV);
            this.Controls.Add(this.RoomDGV);
            this.Controls.Add(this.LiversDGV);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SuccessLabel);
            this.Controls.Add(this.OccupancyDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Система управления работы общежития";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OccupancyDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiversDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жильцыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.комнатыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.инвентарьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViolationDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem просмотрДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменениеДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView OccupancyDGV;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ToolStripMenuItem заселениеToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерКомнаты;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Этаж;
        private System.Windows.Forms.DataGridViewTextBoxColumn Адрес;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пол;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаЗаселения;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаВыселения;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.ToolStripMenuItem жильцыToolStripMenuItem;
        private System.Windows.Forms.DataGridView LiversDGV;
        private HostelDataSet hostelDataSet;
        private System.Windows.Forms.BindingSource жильцыBindingSource;
        private HostelDataSetTableAdapters.ЖильцыTableAdapter жильцыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn DeleteLiver;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView RoomDGV;
        private System.Windows.Forms.BindingSource комнатыBindingSource;
        private HostelDataSetTableAdapters.КомнатыTableAdapter комнатыTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.DataGridView PositionsDGV;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private HostelDataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn этажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeletePosition;
        private System.Windows.Forms.DataGridView InventoryDGV;
        private System.Windows.Forms.BindingSource инвентарьBindingSource;
        private HostelDataSetTableAdapters.ИнвентарьTableAdapter инвентарьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количестваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteInventory;
        private System.Windows.Forms.ToolStripMenuItem инвентарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдачаИнвентаряToolStripMenuItem;
        private System.Windows.Forms.DataGridView DeliveryDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФиоЖильца;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФиоСотрудника;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаВыдачи;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаСдачи;
        private System.Windows.Forms.DataGridViewImageColumn EditDelivery;
        private System.Windows.Forms.DataGridViewImageColumn DeleteDelivery;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.DataGridView EmployeersDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИОСотрудника2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn АдресСот;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridView ViolationDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Column10;
        private System.Windows.Forms.ToolStripMenuItem нарушенияToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn10;
    }
}