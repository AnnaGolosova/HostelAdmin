namespace HostelAdmin.Forms
{
    partial class AddEmployeeForm
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveB = new System.Windows.Forms.Button();
            this.PositionCB = new System.Windows.Forms.ComboBox();
            this.AddinventoryB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BackColor = System.Drawing.Color.LavenderBlush;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 145);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(738, 30);
            this.ErrorLabel.TabIndex = 30;
            this.ErrorLabel.Text = "Текст ошибки";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(245, 70);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(313, 28);
            this.NameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Выберите должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Введите имя сотрудника";
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.BackColor = System.Drawing.Color.Purple;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.Location = new System.Drawing.Point(15, 184);
            this.Cancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(183, 29);
            this.Cancel.TabIndex = 5;
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
            this.label3.Size = new System.Drawing.Size(765, 54);
            this.label3.TabIndex = 21;
            this.label3.Text = "Добавление сотрудника";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveB
            // 
            this.SaveB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveB.BackColor = System.Drawing.Color.Purple;
            this.SaveB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveB.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveB.Location = new System.Drawing.Point(567, 184);
            this.SaveB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(183, 29);
            this.SaveB.TabIndex = 4;
            this.SaveB.Text = "Сохранить";
            this.SaveB.UseVisualStyleBackColor = false;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // PositionCB
            // 
            this.PositionCB.FormattingEnabled = true;
            this.PositionCB.Location = new System.Drawing.Point(245, 111);
            this.PositionCB.Name = "PositionCB";
            this.PositionCB.Size = new System.Drawing.Size(313, 28);
            this.PositionCB.TabIndex = 2;
            // 
            // AddinventoryB
            // 
            this.AddinventoryB.BackColor = System.Drawing.Color.Purple;
            this.AddinventoryB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddinventoryB.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddinventoryB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddinventoryB.Location = new System.Drawing.Point(567, 111);
            this.AddinventoryB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddinventoryB.Name = "AddinventoryB";
            this.AddinventoryB.Size = new System.Drawing.Size(183, 29);
            this.AddinventoryB.TabIndex = 3;
            this.AddinventoryB.Text = "Добавить";
            this.AddinventoryB.UseVisualStyleBackColor = false;
            this.AddinventoryB.Click += new System.EventHandler(this.AddinventoryB_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(765, 227);
            this.Controls.Add(this.AddinventoryB);
            this.Controls.Add(this.PositionCB);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveB);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.ComboBox PositionCB;
        private System.Windows.Forms.Button AddinventoryB;
    }
}