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
    public partial class AddPaymentForm : Form, IAddOccupancy
    {
        List<Заселение> occupancyList;
        Оплата item;
        public AddPaymentForm(int? index)
        {
            InitializeComponent();
            if (index == null)
            {
                item = new Оплата();
                item.Дата = DateTime.Now;
            }
            else item = DBRepository.GetPayment((int)index);
            occupancyList = DBRepository.GetOccupancies().OrderBy(i => i.Жильцы.ФИО).ToList();
            occupancyList.ForEach(i => OccupancyCB.Items.Add(i.Комнаты.НомерКомнаты + "k. " + i.Жильцы.ФИО));

            PaymentDate.Value = item.Дата;
            PaymentTB.Text = item.Сумма.ToString();
            if (item.Заселение != null)
                OccupancyCB.SelectedIndex = occupancyList.IndexOf(item.Заселение);
            OccupancyCB.Focus();
        }

        public void AddOccupancy(Заселение item)
        {
            OccupancyCB.Items.Add(item);
            occupancyList.Add(item);
            OccupancyCB.SelectedIndex = OccupancyCB.Items.Count;
            PaymentTB.Focus();
        }

        private void AddOccupancyB_Click(object sender, EventArgs e)
        {
            OccupancyEditForm form = new OccupancyEditForm(null);
            form.Owner = this;
            form.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(PaymentTB.Text) ||
                string.IsNullOrWhiteSpace(PaymentTB.Text))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Введите сумму оплаты!";
                PaymentTB.Focus();
                return;
            }
            if(OccupancyCB.SelectedIndex == -1)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Выбериете заселение!";
                OccupancyCB.Focus();
                return;
            }
            int d;
            if(!int.TryParse(PaymentTB.Text, out d))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Значение не может быть преобразовано в число!";
                PaymentTB.Focus();
                return;
            }
            if(d <= 0)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Значение суммы должно быть больше нуля!";
                PaymentTB.Focus();
                return;
            }
            item.Дата = PaymentDate.Value;
            item.Сумма = int.Parse(PaymentTB.Text);
            item.КодЗаселения = occupancyList[OccupancyCB.SelectedIndex].Код;
            DBRepository.AddPayment(item);
            (Owner as MainForm).LoadPaymentToGrid();
            Close();
        }
    }
}
