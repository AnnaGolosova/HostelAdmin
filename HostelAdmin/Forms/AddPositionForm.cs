using HostelAdmin.Models;
using HostelAdmin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelAdmin.Forms
{
    public partial class AddPositionForm : Form
    {
        public AddPositionForm()
        {
            InitializeComponent();
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(NameTB.Text)||
                string.IsNullOrWhiteSpace(NameTB.Text))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Введите название!";
                NameTB.Focus();
                return;
            }
            Должности item = new Должности();
            item.Название = NameTB.Text;
            DBRepository.AddPosition(item);

            (Owner as AddEmployeeForm).AddPosition(item);
            Close();
        }
    }
}
