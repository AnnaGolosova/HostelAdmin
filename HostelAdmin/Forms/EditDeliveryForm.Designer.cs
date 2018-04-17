namespace HostelAdmin.Forms
{
    partial class EditDeliveryForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.SaveB = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.AddLiverB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LiversCB = new System.Windows.Forms.ComboBox();
            this.InventoryCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeCB = new System.Windows.Forms.ComboBox();
            this.AddinventoryB = new System.Windows.Forms.Button();
            this.AddEpmloyeeB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddTransferDate = new System.Windows.Forms.CheckBox();
            this.DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.TransferDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Purple;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(737, 54);
            this.label3.TabIndex = 10;
            this.label3.Text = "Редактирование выдачи инвентаря";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveB
            // 
            this.SaveB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveB.BackColor = System.Drawing.Color.Purple;
            this.SaveB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveB.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveB.Location = new System.Drawing.Point(539, 301);
            this.SaveB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(183, 29);
            this.SaveB.TabIndex = 9;
            this.SaveB.Text = "Сохранить";
            this.SaveB.UseVisualStyleBackColor = false;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.BackColor = System.Drawing.Color.Purple;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.Location = new System.Drawing.Point(15, 301);
            this.Cancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(183, 29);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddLiverB
            // 
            this.AddLiverB.BackColor = System.Drawing.Color.Purple;
            this.AddLiverB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddLiverB.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLiverB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddLiverB.Location = new System.Drawing.Point(547, 72);
            this.AddLiverB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddLiverB.Name = "AddLiverB";
            this.AddLiverB.Size = new System.Drawing.Size(183, 29);
            this.AddLiverB.TabIndex = 1;
            this.AddLiverB.Text = "Добавить";
            this.AddLiverB.UseVisualStyleBackColor = false;
            this.AddLiverB.Click += new System.EventHandler(this.AddLiverB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выберите заселение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Выберите инвентарь";
            // 
            // LiversCB
            // 
            this.LiversCB.FormattingEnabled = true;
            this.LiversCB.Location = new System.Drawing.Point(229, 72);
            this.LiversCB.Name = "LiversCB";
            this.LiversCB.Size = new System.Drawing.Size(309, 28);
            this.LiversCB.TabIndex = 0;
            // 
            // InventoryCB
            // 
            this.InventoryCB.FormattingEnabled = true;
            this.InventoryCB.Location = new System.Drawing.Point(229, 106);
            this.InventoryCB.Name = "InventoryCB";
            this.InventoryCB.Size = new System.Drawing.Size(309, 28);
            this.InventoryCB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Выберите сотрудника";
            // 
            // EmployeeCB
            // 
            this.EmployeeCB.FormattingEnabled = true;
            this.EmployeeCB.Location = new System.Drawing.Point(229, 140);
            this.EmployeeCB.Name = "EmployeeCB";
            this.EmployeeCB.Size = new System.Drawing.Size(309, 28);
            this.EmployeeCB.TabIndex = 4;
            // 
            // AddinventoryB
            // 
            this.AddinventoryB.BackColor = System.Drawing.Color.Purple;
            this.AddinventoryB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddinventoryB.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddinventoryB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddinventoryB.Location = new System.Drawing.Point(547, 106);
            this.AddinventoryB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddinventoryB.Name = "AddinventoryB";
            this.AddinventoryB.Size = new System.Drawing.Size(183, 29);
            this.AddinventoryB.TabIndex = 3;
            this.AddinventoryB.Text = "Добавить";
            this.AddinventoryB.UseVisualStyleBackColor = false;
            this.AddinventoryB.Click += new System.EventHandler(this.AddinventoryB_Click);
            // 
            // AddEpmloyeeB
            // 
            this.AddEpmloyeeB.BackColor = System.Drawing.Color.Purple;
            this.AddEpmloyeeB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddEpmloyeeB.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEpmloyeeB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddEpmloyeeB.Location = new System.Drawing.Point(547, 140);
            this.AddEpmloyeeB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddEpmloyeeB.Name = "AddEpmloyeeB";
            this.AddEpmloyeeB.Size = new System.Drawing.Size(183, 29);
            this.AddEpmloyeeB.TabIndex = 5;
            this.AddEpmloyeeB.Text = "Добавить";
            this.AddEpmloyeeB.UseVisualStyleBackColor = false;
            this.AddEpmloyeeB.Click += new System.EventHandler(this.AddEpmloyeeB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Выберите дату выдачи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Выберите дату сдачи";
            this.label6.Visible = false;
            // 
            // AddTransferDate
            // 
            this.AddTransferDate.AutoSize = true;
            this.AddTransferDate.Location = new System.Drawing.Point(16, 229);
            this.AddTransferDate.Name = "AddTransferDate";
            this.AddTransferDate.Size = new System.Drawing.Size(215, 24);
            this.AddTransferDate.TabIndex = 7;
            this.AddTransferDate.Text = "Добавить дату сдачи";
            this.AddTransferDate.UseVisualStyleBackColor = true;
            this.AddTransferDate.CheckedChanged += new System.EventHandler(this.AddTransferDate_CheckedChanged);
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DeliveryDate.Location = new System.Drawing.Point(229, 192);
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Size = new System.Drawing.Size(309, 28);
            this.DeliveryDate.TabIndex = 6;
            // 
            // TransferDate
            // 
            this.TransferDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TransferDate.Location = new System.Drawing.Point(229, 259);
            this.TransferDate.Name = "TransferDate";
            this.TransferDate.Size = new System.Drawing.Size(309, 28);
            this.TransferDate.TabIndex = 8;
            this.TransferDate.Visible = false;
            // 
            // EditDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(737, 344);
            this.Controls.Add(this.TransferDate);
            this.Controls.Add(this.DeliveryDate);
            this.Controls.Add(this.AddTransferDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddEpmloyeeB);
            this.Controls.Add(this.AddinventoryB);
            this.Controls.Add(this.EmployeeCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InventoryCB);
            this.Controls.Add(this.LiversCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddLiverB);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditDeliveryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddLiverB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LiversCB;
        private System.Windows.Forms.ComboBox InventoryCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EmployeeCB;
        private System.Windows.Forms.Button AddinventoryB;
        private System.Windows.Forms.Button AddEpmloyeeB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox AddTransferDate;
        private System.Windows.Forms.DateTimePicker DeliveryDate;
        private System.Windows.Forms.DateTimePicker TransferDate;
    }
}