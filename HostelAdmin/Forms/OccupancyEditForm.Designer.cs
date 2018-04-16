namespace HostelAdmin.Forms
{
    partial class OccupancyEditForm
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
            this.AddLiverB = new System.Windows.Forms.Button();
            this.SaveB = new System.Windows.Forms.Button();
            this.AddRoomB = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddLeaveCB = new System.Windows.Forms.CheckBox();
            this.RoomCB = new System.Windows.Forms.ComboBox();
            this.LiverCB = new System.Windows.Forms.ComboBox();
            this.OccupyDate = new System.Windows.Forms.DateTimePicker();
            this.LeaveDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddLiverB
            // 
            this.AddLiverB.BackColor = System.Drawing.Color.Purple;
            this.AddLiverB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddLiverB.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLiverB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddLiverB.Location = new System.Drawing.Point(613, 72);
            this.AddLiverB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddLiverB.Name = "AddLiverB";
            this.AddLiverB.Size = new System.Drawing.Size(183, 29);
            this.AddLiverB.TabIndex = 4;
            this.AddLiverB.Text = "Добавить";
            this.AddLiverB.UseVisualStyleBackColor = false;
            this.AddLiverB.Click += new System.EventHandler(this.AddLiverB_Click);
            // 
            // SaveB
            // 
            this.SaveB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveB.BackColor = System.Drawing.Color.Purple;
            this.SaveB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveB.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveB.Location = new System.Drawing.Point(607, 298);
            this.SaveB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(183, 29);
            this.SaveB.TabIndex = 6;
            this.SaveB.Text = "Сохранить";
            this.SaveB.UseVisualStyleBackColor = false;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // AddRoomB
            // 
            this.AddRoomB.BackColor = System.Drawing.Color.Purple;
            this.AddRoomB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddRoomB.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRoomB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddRoomB.Location = new System.Drawing.Point(613, 118);
            this.AddRoomB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddRoomB.Name = "AddRoomB";
            this.AddRoomB.Size = new System.Drawing.Size(183, 29);
            this.AddRoomB.TabIndex = 7;
            this.AddRoomB.Text = "Добавить";
            this.AddRoomB.UseVisualStyleBackColor = false;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.BackColor = System.Drawing.Color.Purple;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.Location = new System.Drawing.Point(15, 298);
            this.Cancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(183, 29);
            this.Cancel.TabIndex = 8;
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
            this.label3.Size = new System.Drawing.Size(805, 54);
            this.label3.TabIndex = 9;
            this.label3.Text = "Редактирование заселения";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddLeaveCB
            // 
            this.AddLeaveCB.AutoSize = true;
            this.AddLeaveCB.Location = new System.Drawing.Point(17, 211);
            this.AddLeaveCB.Margin = new System.Windows.Forms.Padding(4);
            this.AddLeaveCB.Name = "AddLeaveCB";
            this.AddLeaveCB.Size = new System.Drawing.Size(260, 24);
            this.AddLeaveCB.TabIndex = 10;
            this.AddLeaveCB.Text = "Добавить дату выселения";
            this.AddLeaveCB.UseVisualStyleBackColor = true;
            this.AddLeaveCB.CheckedChanged += new System.EventHandler(this.AddLeaveCB_CheckedChanged);
            // 
            // RoomCB
            // 
            this.RoomCB.FormattingEnabled = true;
            this.RoomCB.Location = new System.Drawing.Point(199, 118);
            this.RoomCB.Margin = new System.Windows.Forms.Padding(4);
            this.RoomCB.Name = "RoomCB";
            this.RoomCB.Size = new System.Drawing.Size(404, 28);
            this.RoomCB.TabIndex = 11;
            // 
            // LiverCB
            // 
            this.LiverCB.FormattingEnabled = true;
            this.LiverCB.Location = new System.Drawing.Point(199, 73);
            this.LiverCB.Margin = new System.Windows.Forms.Padding(4);
            this.LiverCB.Name = "LiverCB";
            this.LiverCB.Size = new System.Drawing.Size(404, 28);
            this.LiverCB.TabIndex = 12;
            // 
            // OccupyDate
            // 
            this.OccupyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OccupyDate.Location = new System.Drawing.Point(329, 174);
            this.OccupyDate.Margin = new System.Windows.Forms.Padding(4);
            this.OccupyDate.Name = "OccupyDate";
            this.OccupyDate.Size = new System.Drawing.Size(274, 28);
            this.OccupyDate.TabIndex = 13;
            // 
            // LeaveDate
            // 
            this.LeaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LeaveDate.Location = new System.Drawing.Point(329, 253);
            this.LeaveDate.Margin = new System.Windows.Forms.Padding(4);
            this.LeaveDate.Name = "LeaveDate";
            this.LeaveDate.Size = new System.Drawing.Size(274, 28);
            this.LeaveDate.TabIndex = 14;
            this.LeaveDate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Выберите жильца";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Выберите комнату";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Выберите дату заселения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Выберите дату выселения";
            this.label5.Visible = false;
            // 
            // OccupancyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(805, 341);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeaveDate);
            this.Controls.Add(this.OccupyDate);
            this.Controls.Add(this.LiverCB);
            this.Controls.Add(this.RoomCB);
            this.Controls.Add(this.AddLeaveCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddRoomB);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.AddLiverB);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OccupancyEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddLiverB;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Button AddRoomB;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox AddLeaveCB;
        private System.Windows.Forms.ComboBox RoomCB;
        private System.Windows.Forms.ComboBox LiverCB;
        private System.Windows.Forms.DateTimePicker OccupyDate;
        private System.Windows.Forms.DateTimePicker LeaveDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}