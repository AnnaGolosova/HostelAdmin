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
    public partial class AddEmployeeForm : Form
    {
        Сотрудники item;
        List<Должности> positionList;
        public AddEmployeeForm(int? index)
        {
            InitializeComponent();
            if (index == null)
            {
                item = new Сотрудники();
            }
            else item = DBRepository.GetEmployee((int)index);

            positionList = DBRepository.GetPositions();
            positionList.ForEach(i => PositionCB.Items.Add(i.Название));

            if (item.Должности != null)
                PositionCB.SelectedIndex = positionList.IndexOf(item.Должности);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void AddPosition(Должности item)
        {
            PositionCB.Items.Add(item.Название);
            positionList.Add(item);
            PositionCB.SelectedIndex = PositionCB.Items.Count - 1;
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(NameTB.Text) || 
                string.IsNullOrWhiteSpace(NameTB.Text))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Введите имя сотрудника!";
                NameTB.Focus();
                return;
            }
            if(PositionCB.SelectedIndex == -1)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Выберите должность!";
                PositionCB.Focus();
                return;
            }
            item.ФИО = NameTB.Text;
            item.КодДолжности = positionList[PositionCB.SelectedIndex].Код;
            DBRepository.AddEmployee(item);
            (Owner as EditDeliveryForm).AddEmployee(item);
            Close();
        }

        private void AddinventoryB_Click(object sender, EventArgs e)
        {
            AddPositionForm form = new AddPositionForm();
            form.Owner = this;
            form.Show();
        }
    }
}
