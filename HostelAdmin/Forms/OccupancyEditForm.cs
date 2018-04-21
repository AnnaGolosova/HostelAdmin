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
    public partial class OccupancyEditForm : Form, IAddLiver
    {
        private Заселение item;
        private List<Жильцы> livers;
        private List<Комнаты> rooms;

        public OccupancyEditForm(int? index)
        {
            InitializeComponent();
            if(index == null)
            {
                item = new Заселение();
                item.ДатаЗаселения = DateTime.Now;
            } else
                item = DBRepository.GetOccupancy((int)index);
            rooms = DBRepository.GetRooms().OrderBy(i => i.НомерКомнаты).ToList();
            livers = DBRepository.GetLivers().OrderBy(i => i.ФИО).ToList();

            rooms.ForEach(i => RoomCB.Items.Add(i.Этаж + " эт. " + i.НомерКомнаты));
            livers.ForEach(i => LiverCB.Items.Add(i.ФИО));
            OccupyDate.Value = item.ДатаЗаселения;
            if(item.ДатаВыселения != null)
            {
                AddLeaveCB.Checked = true;
                LeaveDate.Visible = true;
                LeaveDate.Value = (DateTime)item.ДатаВыселения;
                label5.Visible = true;
            }
            if(item.Комнаты != null)
                RoomCB.SelectedIndex = rooms.IndexOf(item.Комнаты);
            if(item.Жильцы != null)
                LiverCB.SelectedIndex = livers.IndexOf(item.Жильцы);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }


        private void AddLeaveCB_CheckedChanged(object sender, EventArgs e)
        {
            LeaveDate.Visible = AddLeaveCB.Checked;
            label5.Visible = AddLeaveCB.Checked;
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            item.КодЖильца = livers[LiverCB.SelectedIndex].Код;
            item.КодКомнаты = rooms[RoomCB.SelectedIndex].Код;
            item.ДатаЗаселения = OccupyDate.Value;
            item.ДатаВыселения = AddLeaveCB.Checked ? LeaveDate.Value : null as DateTime?;
            DBRepository.ChangeOrAddOccupancy(item);
            (Owner as IAddOccupancy).AddOccupancy(item);
            Close();
        }

        private void AddLiverB_Click(object sender, EventArgs e)
        {
            AddLiverForm form = new AddLiverForm(null);
            form.Owner = this;
            form.Show(); 
        }

        public void AddLiver(Жильцы item)
        {
            LiverCB.Items.Add(item.ФИО);
            livers.Add(item);
            LiverCB.SelectedIndex = LiverCB.Items.Count - 1;
        }

        private void AddRoomB_Click(object sender, EventArgs e)
        {
            AddRoomForm form = new AddRoomForm();
            form.Owner = this;
            form.Show();
        }

        public void AddRoom(Комнаты item)
        {
            RoomCB.Items.Add(item.Этаж + " эт. " + item.НомерКомнаты);
            RoomCB.SelectedIndex = RoomCB.Items.Count - 1;
            rooms.Add(item);
        }
    }
}
