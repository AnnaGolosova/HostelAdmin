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
    public partial class AddInventoryForm : Form
    {
        public AddInventoryForm()
        {
            InitializeComponent();
        }

        private void CountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
                e.KeyChar = '\0';
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTB.Text) ||
                string.IsNullOrWhiteSpace(NameTB.Text))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Введите имя инвентаря!";
                NameTB.Focus();
                return;
            }
            if (string.IsNullOrEmpty(CountTB.Text) ||
                string.IsNullOrWhiteSpace(CountTB.Text))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Введите количество инвентаря!";
                CountTB.Focus();
                return;
            }
            Инвентарь item = new Инвентарь();
            item.Количества = int.Parse(CountTB.Text);
            item.Название = NameTB.Text;
            DBRepository.AddInventory(item);
            (Owner as EditDeliveryForm).AddInventory(item);
            Close();

        }
    }
}
