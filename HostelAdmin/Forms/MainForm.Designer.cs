﻿namespace HostelAdmin.Forms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.просмотрДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заселениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жильцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посещенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нарушенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оплатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дежурстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдачаИнвентаряToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.жильцыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDataSet = new HostelAdmin.HostelDataSet();
            this.жильцыTableAdapter = new HostelAdmin.HostelDataSetTableAdapters.ЖильцыTableAdapter();
            this.Код = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OccupancyDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiversDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жильцыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.посещенияToolStripMenuItem,
            this.нарушенияToolStripMenuItem,
            this.оплатаToolStripMenuItem,
            this.дежурстваToolStripMenuItem,
            this.toolStripMenuItem2,
            this.сотрудникикToolStripMenuItem,
            this.выдачаИнвентаряToolStripMenuItem,
            this.hrToolStripMenuItem});
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
            // посещенияToolStripMenuItem
            // 
            this.посещенияToolStripMenuItem.Name = "посещенияToolStripMenuItem";
            this.посещенияToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.посещенияToolStripMenuItem.Text = "Посещения";
            // 
            // нарушенияToolStripMenuItem
            // 
            this.нарушенияToolStripMenuItem.Name = "нарушенияToolStripMenuItem";
            this.нарушенияToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.нарушенияToolStripMenuItem.Text = "Нарушения";
            // 
            // оплатаToolStripMenuItem
            // 
            this.оплатаToolStripMenuItem.Name = "оплатаToolStripMenuItem";
            this.оплатаToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.оплатаToolStripMenuItem.Text = "Оплата";
            // 
            // дежурстваToolStripMenuItem
            // 
            this.дежурстваToolStripMenuItem.Name = "дежурстваToolStripMenuItem";
            this.дежурстваToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.дежурстваToolStripMenuItem.Text = "Дежурства";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(249, 26);
            this.toolStripMenuItem2.Text = "Инвентарь";
            // 
            // сотрудникикToolStripMenuItem
            // 
            this.сотрудникикToolStripMenuItem.Name = "сотрудникикToolStripMenuItem";
            this.сотрудникикToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.сотрудникикToolStripMenuItem.Text = "Сотрудники";
            // 
            // выдачаИнвентаряToolStripMenuItem
            // 
            this.выдачаИнвентаряToolStripMenuItem.Name = "выдачаИнвентаряToolStripMenuItem";
            this.выдачаИнвентаряToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.выдачаИнвентаряToolStripMenuItem.Text = "Выдача инвентаря";
            // 
            // hrToolStripMenuItem
            // 
            this.hrToolStripMenuItem.Name = "hrToolStripMenuItem";
            this.hrToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.hrToolStripMenuItem.Text = "Пользователи";
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
            this.OccupancyDGV.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.MainDGV_RowsAdded);
            this.OccupancyDGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.MainDGV_RowsRemoved);
            this.OccupancyDGV.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDGV_RowValidated);
            this.OccupancyDGV.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.MainDGV_RowValidating);
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
            this.LiversDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LiversDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код,
            this.фИОDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1});
            this.LiversDGV.DataSource = this.жильцыBindingSource;
            this.LiversDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LiversDGV.Location = new System.Drawing.Point(0, 28);
            this.LiversDGV.Name = "LiversDGV";
            this.LiversDGV.RowTemplate.Height = 24;
            this.LiversDGV.Size = new System.Drawing.Size(1130, 458);
            this.LiversDGV.TabIndex = 7;
            this.LiversDGV.VirtualMode = true;
            this.LiversDGV.Visible = false;
            this.LiversDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.LiversDGV_CellEndEdit);
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
            // жильцыTableAdapter
            // 
            this.жильцыTableAdapter.ClearBeforeFill = true;
            // 
            // Код
            // 
            this.Код.DataPropertyName = "Код";
            this.Код.HeaderText = "Код";
            this.Код.Name = "Код";
            this.Код.ReadOnly = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1130, 546);
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
        private System.Windows.Forms.ToolStripMenuItem посещенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нарушенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оплатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дежурстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem сотрудникикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдачаИнвентаряToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hrToolStripMenuItem;
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
    }
}