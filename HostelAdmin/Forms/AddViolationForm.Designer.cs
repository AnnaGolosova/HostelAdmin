namespace HostelAdmin.Forms
{
    partial class AddViolationForm
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ViolationTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OccupancyCB = new System.Windows.Forms.ComboBox();
            this.AddOccupancyB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IsBreach = new System.Windows.Forms.CheckBox();
            this.BreachTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BackColor = System.Drawing.Color.LavenderBlush;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(11, 224);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(715, 30);
            this.ErrorLabel.TabIndex = 28;
            this.ErrorLabel.Text = "Текст ошибки";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // ViolationTB
            // 
            this.ViolationTB.Location = new System.Drawing.Point(266, 108);
            this.ViolationTB.Name = "ViolationTB";
            this.ViolationTB.Size = new System.Drawing.Size(269, 28);
            this.ViolationTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Введите состав нарушения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Выберите заселение";
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.Purple;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save.Location = new System.Drawing.Point(543, 271);
            this.Save.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(183, 29);
            this.Save.TabIndex = 6;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.BackColor = System.Drawing.Color.Purple;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.Location = new System.Drawing.Point(15, 271);
            this.Cancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(183, 29);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
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
            this.label3.Size = new System.Drawing.Size(741, 54);
            this.label3.TabIndex = 25;
            this.label3.Text = "Редактирование нарушения";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OccupancyCB
            // 
            this.OccupancyCB.FormattingEnabled = true;
            this.OccupancyCB.Location = new System.Drawing.Point(266, 66);
            this.OccupancyCB.Name = "OccupancyCB";
            this.OccupancyCB.Size = new System.Drawing.Size(269, 28);
            this.OccupancyCB.TabIndex = 0;
            // 
            // AddOccupancyB
            // 
            this.AddOccupancyB.BackColor = System.Drawing.Color.Purple;
            this.AddOccupancyB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddOccupancyB.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOccupancyB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddOccupancyB.Location = new System.Drawing.Point(545, 66);
            this.AddOccupancyB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddOccupancyB.Name = "AddOccupancyB";
            this.AddOccupancyB.Size = new System.Drawing.Size(183, 29);
            this.AddOccupancyB.TabIndex = 1;
            this.AddOccupancyB.Text = "Добавить";
            this.AddOccupancyB.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Отработано ли нарушение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Выберите дату отработки";
            this.label5.Visible = false;
            // 
            // IsBreach
            // 
            this.IsBreach.AutoSize = true;
            this.IsBreach.Location = new System.Drawing.Point(266, 158);
            this.IsBreach.Name = "IsBreach";
            this.IsBreach.Size = new System.Drawing.Size(18, 17);
            this.IsBreach.TabIndex = 4;
            this.IsBreach.UseVisualStyleBackColor = true;
            this.IsBreach.CheckedChanged += new System.EventHandler(this.IsBreach_CheckedChanged);
            // 
            // BreachTime
            // 
            this.BreachTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BreachTime.Location = new System.Drawing.Point(266, 186);
            this.BreachTime.Name = "BreachTime";
            this.BreachTime.Size = new System.Drawing.Size(269, 28);
            this.BreachTime.TabIndex = 5;
            this.BreachTime.Visible = false;
            // 
            // AddViolationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(741, 314);
            this.Controls.Add(this.BreachTime);
            this.Controls.Add(this.IsBreach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddOccupancyB);
            this.Controls.Add(this.OccupancyCB);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ViolationTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddViolationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox ViolationTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OccupancyCB;
        private System.Windows.Forms.Button AddOccupancyB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox IsBreach;
        private System.Windows.Forms.DateTimePicker BreachTime;
    }
}