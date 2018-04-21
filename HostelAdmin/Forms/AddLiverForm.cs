using HostelAdmin.Models;
using HostelAdmin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelAdmin.Forms
{
    public partial class AddLiverForm : Form
    {
        Жильцы item;
        public AddLiverForm(int? index)
        {
            InitializeComponent();
            if (item == null)
            {
                item = new Жильцы();
            }
            else item = DBRepository.GetLiver((int)index);

            NameTB.Text = item.ФИО;
            AddressTB.Text = item.Адрес;
            if (item.Пол == true)
            {
                FemaleCB.Checked = true;
            }
            else MaleCB.Checked = true;
            NameTB.Focus();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(NameTB.Text))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "";
                NameTB.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(AddressTB.Text))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "";
                AddressTB.Focus();
                return;
            }
            item.ФИО = NameTB.Text;
            item.Адрес = AddressTB.Text;
            item.Пол = FemaleCB.Checked;
            DBRepository.ChangeOrAddLiver(item);
            (Owner as IAddLiver).AddLiver(item);
            Close();
        }
    }
}
