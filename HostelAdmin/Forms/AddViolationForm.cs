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
using HostelAdmin.Models;

namespace HostelAdmin.Forms
{
    public partial class AddViolationForm : Form, IAddOccupancy
    {
        Нарушения item;
        List<Заселение> occupancyList;
        public AddViolationForm(int? index)
        {
            InitializeComponent();
            if (index == null)
            {
                item = new Нарушения();
                label3.Text = "Добавление нарушения";
                item.Отработано = false;
            }
            else
            {
                item = DBRepository.GetViolation((int)index);
                label3.Text = "Редактирование нарушения";
            }
            occupancyList = DBRepository.GetOccupancies();
            occupancyList.ForEach(i => OccupancyCB.Items.Add(i.Комнаты.НомерКомнаты + "k. " + i.Жильцы.ФИО));

            ViolationTB.Text = item.СоставНарушения;
            IsBreach.Checked = (bool)item.Отработано;
            if(item.ДатаОтработки != null)
                BreachTime.Value = (DateTime)item.ДатаОтработки;

            if (item.Заселение != null)
                OccupancyCB.SelectedIndex = occupancyList.IndexOf(item.Заселение);
        }

        public void AddOccupancy(Заселение item)
        {
            throw new NotImplementedException();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ViolationTB.Text) ||
                string.IsNullOrWhiteSpace(ViolationTB.Text))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Введите состав нарушения!";
                ViolationTB.Focus();
                return;
            }
            if(OccupancyCB.SelectedIndex == -1)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Выберите заселение!";
                ViolationTB.Focus();
                return;
            }
            item.ДатаОтработки = IsBreach.Checked ? BreachTime.Value : null as DateTime?;
            item.Отработано = IsBreach.Checked;
            item.СоставНарушения = ViolationTB.Text;
            item.КодЗаселения = occupancyList[OccupancyCB.SelectedIndex].Код;
            DBRepository.ChangeOrAddCiolation(item);
            (Owner as MainForm).LoadViolationToGrid();
            Close();
        }

        private void IsBreach_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = IsBreach.Checked;
            BreachTime.Visible = IsBreach.Checked;
        }
    }
}
