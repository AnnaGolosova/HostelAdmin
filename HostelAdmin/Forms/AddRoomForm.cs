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
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
            RoomNumberTB.Focus();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RoomNumberTB.Text) ||
                string.IsNullOrWhiteSpace(RoomNumberTB.Text))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Введите номер комнаты!";
                RoomNumberTB.Focus();
                return;
            }
            if (string.IsNullOrEmpty(FloorTB.Text) ||
                string.IsNullOrWhiteSpace(FloorTB.Text))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Введите этаж!";
                FloorTB.Focus();
                return;
            }
            int v1, v2;
            if (!int.TryParse(RoomNumberTB.Text, out v1))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Номер комнаты не может быть преобразован в число!";
                FloorTB.Focus();
                return;
            }
            if (!int.TryParse(FloorTB.Text, out v2))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Номер этажа не может быть преобразован в число!";
                FloorTB.Focus();
                return;
            }
            
            (Owner as OccupancyEditForm).AddRoom(DBRepository.AddRoom(v1, v2));
            Close();
        }

        private void RoomNumberTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar !='\b')
            {
                e.KeyChar = '\0';
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FloorTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.KeyChar = '\0';
            }
        }
    }
}
