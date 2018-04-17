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
    public partial class EditDeliveryForm : Form, IAddOccupancy, IAddEmployee
    {
        ВыдачаИнвентаря item;
        List<Инвентарь> inventoryList;
        List<Заселение> occupancyList;
        List<Сотрудники> employeeList;
            
        public EditDeliveryForm(ВыдачаИнвентаря item)
        {
            InitializeComponent();
            if (item == null)
            {
                item = new ВыдачаИнвентаря();
                item.ДатаВыдачи = DateTime.Now;
                label3.Text = "Добавление выдачи инвентаря";
            } else label3.Text = "Редактирование выдачи инвентаря";
            this.item = item;
            occupancyList = DBRepository.GetOccupancies().OrderBy(i => i.Жильцы.ФИО).ToList();
            inventoryList = DBRepository.GetInventories().OrderBy(i => i.Название).ToList();
            employeeList = DBRepository.GetEmployees().OrderBy(i => i.ФИО).ToList();
            occupancyList.ForEach(i => LiversCB.Items.Add(i.Комнаты.НомерКомнаты + "k. " + i.Жильцы.ФИО));
            inventoryList.ForEach(i => InventoryCB.Items.Add(i.Название));
            employeeList.ForEach(i => EmployeeCB.Items.Add(i.ФИО));

            if(item.Заселение != null)
                LiversCB.SelectedIndex = item.КодЗаселения == 0 ? 0 : occupancyList.IndexOf(item.Заселение);
            if(item.Сотрудники != null)
                EmployeeCB.SelectedIndex = item.КодСотрудника == 0 ? 0 : employeeList.IndexOf(item.Сотрудники);
            if(item.Инвентарь != null)
                InventoryCB.SelectedIndex = item.КодИнвентаря == 0 ? 0 : inventoryList.IndexOf(item.Инвентарь);

            DeliveryDate.Value = item.ДатаВыдачи;
            if (item.ДатаСдачи != null)
            {
                AddTransferDate.Checked = true;
                TransferDate.Value = (DateTime)item.ДатаСдачи;
            }
        }

        private void AddTransferDate_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = AddTransferDate.Checked;
            TransferDate.Visible = AddTransferDate.Checked;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            item.КодЗаселения = occupancyList[LiversCB.SelectedIndex].Код;
            item.КодИнвентаря = inventoryList[InventoryCB.SelectedIndex].Код;
            item.КодСотрудника = employeeList[EmployeeCB.SelectedIndex].Код;
            item.ДатаВыдачи = DeliveryDate.Value;
            item.ДатаСдачи = AddTransferDate.Checked ? TransferDate.Value : null as DateTime?;
            DBRepository.ChangeDelivery(item);
            System.Threading.Thread.Sleep(100);
            (Owner as IAddDelivery).AddDelivery(item);
            Close();
        }

        private void AddLiverB_Click(object sender, EventArgs e)
        {
            OccupancyEditForm form = new OccupancyEditForm(null);
            form.Owner = this;
            form.Show();
        }

        public void AddOccupancy(Заселение item)
        {
            occupancyList.Add(item);
            LiversCB.Items.Add(item.Комнаты.НомерКомнаты + "k. " + item.Жильцы.ФИО);
            LiversCB.SelectedIndex = LiversCB.Items.Count - 1;
        }

        private void AddinventoryB_Click(object sender, EventArgs e)
        {
            AddInventoryForm form = new AddInventoryForm();
            form.Owner = this;
            form.Show();
        }

        public void AddInventory(Инвентарь item)
        {
            InventoryCB.Items.Add(item.Название);
            inventoryList.Add(item);
            InventoryCB.SelectedIndex = InventoryCB.Items.Count - 1;
        }

        private void AddEpmloyeeB_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm(null);
            form.Owner = this;
            form.Show();
        }

        void IAddEmployee.AddEmployee(Сотрудники item)
        {
            employeeList.Add(item);
            EmployeeCB.Items.Add(item.ФИО);
            EmployeeCB.SelectedIndex = EmployeeCB.Items.Count - 1;
        }
    }
}
