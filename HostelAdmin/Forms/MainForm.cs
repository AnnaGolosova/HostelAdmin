using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostelAdmin.Models;
using HostelAdmin.Services;

namespace HostelAdmin.Forms
{
    public partial class MainForm : Form, IAddOccupancy, IAddEmployee, IAddDelivery
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void LoadDeliveryToGrid()
        {
            InventoryDGV.Visible = false;
            RoomDGV.Visible = false;
            PositionsDGV.Visible = false;
            ViolationDGV.Visible = false;
            LiversDGV.Visible = false;
            EmployeersDGV.Visible = false;
            OccupancyDGV.Visible = false;
            AddB.Visible = true;
            DeliveryDGV.Visible = true;
            DeliveryDGV.Rows.Clear();
            List<DeliveryFull> list = DBRepository.GetDeliveryFull();
            foreach (DeliveryFull d in list)
                DeliveryDGV.Rows.Add(d.Код, d.ФИО, d.Название, d.ФиоСотрудника, d.Количества, 
                    d.ДатаВыдачи.ToShortDateString(), 
                    d.ДатаСдачи == null ? "" : (d.ДатаСдачи.Value.ToShortDateString()));

        }
        public void LoadInventorytoGrig()
        {
            InventoryDGV.Visible = true;
            ViolationDGV.Visible = false;
            EmployeersDGV.Visible = false;
            RoomDGV.Visible = false;
            PositionsDGV.Visible = false;
            DeliveryDGV.Visible = false;
            LiversDGV.Visible = false;
            OccupancyDGV.Visible = false;
            this.инвентарьTableAdapter.Fill(this.hostelDataSet.Инвентарь);
            AddB.Visible = false;
        }

        public void LoadOccupancyToGrid()
        {
            List<OccupancyFull> list = DBRepository.GetОccupancy();
            OccupancyDGV.Rows.Clear();
            RoomDGV.Visible = false;
            DeliveryDGV.Visible = false;
            ViolationDGV.Visible = false;
            PositionsDGV.Visible = false;
            EmployeersDGV.Visible = false;
            InventoryDGV.Visible = false;
            LiversDGV.Visible = false;
            AddB.Visible = true;
            OccupancyDGV.Visible = true;
            foreach (OccupancyFull full in list)
            {
                Bitmap editImage = new Bitmap(Resources.ic_mode_edit_black_18dp_1x);
                Bitmap deleteImage = new Bitmap(Resources.ic_delete_forever_black_18dp_1x);
                OccupancyDGV.Rows.Add(full.Код, full.КодКомнаты, full.НомерКомнаты, full.ФИО, full.Этаж, full.Адрес, full.Пол,
                    full.ДатаЗаселения.ToShortDateString(), full.ДатаВыселения == null ? "" : ((DateTime)full.ДатаВыселения).ToShortDateString(), editImage, deleteImage);
            }
        }

        public void LoadLiversToDrid()
        {
            this.жильцыTableAdapter.Fill(this.hostelDataSet.Жильцы);
            LiversDGV.Columns[0].Visible = false;

            RoomDGV.Visible = false;
            LiversDGV.Visible = true;
            InventoryDGV.Visible = false;
            DeliveryDGV.Visible = false;
            ViolationDGV.Visible = false;
            EmployeersDGV.Visible = false;
            PositionsDGV.Visible = false;
            OccupancyDGV.Visible = false;
            AddB.Visible = false;
        }

        public void LoadPositionToGrid()
        {
            PositionsDGV.Visible = true;
            DeliveryDGV.Visible = false;
            ViolationDGV.Visible = false;
            LiversDGV.Visible = false;
            EmployeersDGV.Visible = false;
            InventoryDGV.Visible = false;
            RoomDGV.Visible = false;
            OccupancyDGV.Visible = false;
            AddB.Visible = false;

            this.должностиTableAdapter.Fill(this.hostelDataSet.Должности);
        }

        public void LoadRoomToGrid()
        {
            RoomDGV.Visible = true;
            InventoryDGV.Visible = false;
            LiversDGV.Visible = false;
            DeliveryDGV.Visible = false;
            PositionsDGV.Visible = false;
            ViolationDGV.Visible = false;
            EmployeersDGV.Visible = false;
            OccupancyDGV.Visible = false;
            AddB.Visible = false;

            this.комнатыTableAdapter.Fill(this.hostelDataSet.Комнаты);
        }

        public void LoadEmployeeToGrid()
        {
            RoomDGV.Visible = false;
            InventoryDGV.Visible = false;
            LiversDGV.Visible = false;
            DeliveryDGV.Visible = false;
            ViolationDGV.Visible = false;
            PositionsDGV.Visible = false;
            OccupancyDGV.Visible = false;
            AddB.Visible = true;

            EmployeersDGV.Visible = true;
            EmployeersDGV.Rows.Clear();
            List<Сотрудники> list = DBRepository.GetEmployees();
            list.ForEach(i => EmployeersDGV.Rows.Add(i.Код, i.ФИО, i.Должности.Название, i.Адрес));
        }

        public void LoadViolationToGrid()
        {
            RoomDGV.Visible = false;
            InventoryDGV.Visible = false;
            LiversDGV.Visible = false;
            DeliveryDGV.Visible = false;
            PositionsDGV.Visible = false;
            OccupancyDGV.Visible = false;
            AddB.Visible = true;

            ViolationDGV.Visible = true;
            ViolationDGV.Rows.Clear();
            List<Нарушения> list = DBRepository.GetViolation();
            list.ForEach(i => ViolationDGV.Rows.Add(i.Код, i.Заселение.Жильцы.ФИО, i.СоставНарушения, i.Отработано, i.ДатаОтработки));
        }

        private void заселениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadOccupancyToGrid();
        }

        private void OccupancyDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 9)
            {
                OccupancyEditForm form = new OccupancyEditForm(((int)OccupancyDGV[0, e.RowIndex].Value));
                form.Owner = this;
                form.Show();
            }
            if(e.ColumnIndex == 10)
            {
                int index = (int)OccupancyDGV[0, e.RowIndex].Value;
                DeleteState state = DBRepository.TryDeleteOccupancy(index);
                if (state == DeleteState.HasInventory)
                {
                    if (MessageBox.Show("У этого заселения есть несданный инвентарь. Отметить инвентарь ка ксданный сегодня и удалить засление?", "Удалить засление?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DBRepository.TryDeleteOccupancy(index, true);
                    }
                }
                if (state == DeleteState.HasReferences)
                {
                    if (MessageBox.Show("На эту запись имеются ссылки из других таблиц. Удалить все равно? Связные записи будут удалены, либо заменениы на стандартые значения.", "Удалить запись?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DBRepository.TryDeleteOccupancy(index, true);
                    }
                }
                LoadOccupancyToGrid();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void жильцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLiversToDrid();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void LiversDGV_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex == LiversDGV.Rows.Count - 1)
                return;
            if((int)LiversDGV[0, e.RowIndex].Value < 0)
            {
                if (string.IsNullOrEmpty(LiversDGV[1, e.RowIndex].Value as string) ||
                    string.IsNullOrWhiteSpace(LiversDGV[1, e.RowIndex].Value as string))
                {
                    LiversDGV[1, e.RowIndex].Style.BackColor = Color.LightPink;
                    e.Cancel = true;
                    return;
                }
                else if (string.IsNullOrEmpty(LiversDGV[2, e.RowIndex].Value as string) ||
                  string.IsNullOrWhiteSpace(LiversDGV[2, e.RowIndex].Value as string))
                {
                    LiversDGV[2, e.RowIndex].Style.BackColor = Color.LightPink;
                    e.Cancel = true;
                    return;
                }
                Жильцы item = new Жильцы();
                item.ФИО = LiversDGV[1, e.RowIndex].Value as string;
                item.Адрес = LiversDGV[2, e.RowIndex].Value as string;
                item.Пол = LiversDGV[3, e.RowIndex].Value as bool? ?? false;
                DBRepository.AddLiver(item);

                LiversDGV[0, e.RowIndex].Value = item.Код;
            }
            else
            {
                if (string.IsNullOrEmpty(LiversDGV[1, e.RowIndex].Value as string) ||
                    string.IsNullOrWhiteSpace(LiversDGV[1, e.RowIndex].Value as string))
                {
                    LiversDGV[1, e.RowIndex].Style.BackColor = Color.LightPink;
                    return;
                }
                else
                    LiversDGV[1, e.RowIndex].Style.BackColor = Color.White;
                if (string.IsNullOrEmpty(LiversDGV[2, e.RowIndex].Value as string) ||
                  string.IsNullOrWhiteSpace(LiversDGV[2, e.RowIndex].Value as string))
                {
                    LiversDGV[2, e.RowIndex].Style.BackColor = Color.LightPink;
                    return;
                }
                else
                    LiversDGV[2, e.RowIndex].Style.BackColor = Color.White;
                Жильцы item = DBRepository.GetLiver((int)LiversDGV[0, e.RowIndex].Value);
                item.ФИО = LiversDGV[1, e.RowIndex].Value as string;
                item.Адрес = LiversDGV[2, e.RowIndex].Value as string;
                item.Пол = LiversDGV[3, e.RowIndex].Value as bool? ?? false;

                DBRepository.ChangeOrAddLiver(item);
            }
        }

        private void LiversDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.ColumnIndex == dgv.Columns.Count - 1)
            {
                e.Value = Resources.ic_delete_forever_black_18dp_1x;
            }
        }

        private void LiversDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4 && !LiversDGV.Rows[e.RowIndex].IsNewRow)
            {
                int index = (int)LiversDGV[0, e.RowIndex].Value;
                DeleteState state = DBRepository.TryDeleteLiver(index);
                if (state == DeleteState.HasReferences)
                {
                    if (MessageBox.Show("На эту запись имеются ссылки из других таблиц. Удалить все равно? Связные записи будут удалены, либо заменениы на стандартые значения.", "Удалить запись?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DBRepository.TryDeleteLiver(index, true);
                        LoadLiversToDrid();
                    }
                }
                LoadLiversToDrid();
            }
        }

        private void комнатыMenuItem1_Click(object sender, EventArgs e)
        {
            LoadRoomToGrid();
        }
        
        private void RoomDGV_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex == RoomDGV.Rows.Count - 1)
                return;
            Комнаты item = new Комнаты();
            item.Этаж = int.Parse(RoomDGV[1, e.RowIndex].Value.ToString());
            item.НомерКомнаты = int.Parse(RoomDGV[2, e.RowIndex].Value.ToString());
            if ((int)RoomDGV[0, e.RowIndex].Value < 0)
            {
                DBRepository.AddRoom(item);
                RoomDGV[0, e.RowIndex].Value = item.Код;
            }
            else
            {
                item.Код = (int)RoomDGV[0, e.RowIndex].Value;
                DBRepository.ChangeRoom(item);
            }
        }

        private void RoomDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            RoomDGV[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.LightPink;
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPositionToGrid();
        }

        private void RoomDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && !RoomDGV.Rows[e.RowIndex].IsNewRow)
            {
                int index = (int)RoomDGV[0, e.RowIndex].Value;
                DeleteState state = DBRepository.TryDeleteRoom(index);
                if (state == DeleteState.HasReferences)
                {
                    if (MessageBox.Show("На эту запись имеются ссылки из других таблиц. Удалить все равно? Связные записи будут удалены, либо заменениы на стандартые значения.", 
                        "Удалить запись?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DBRepository.TryDeleteRoom(index, true);
                    }
                }
                LoadRoomToGrid();
            }
        }

        private void PositionsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && !PositionsDGV.Rows[e.RowIndex].IsNewRow)
            {
                int index = (int)PositionsDGV[0, e.RowIndex].Value;
                DeleteState state = DBRepository.TryDeletePosition(index);
                if (state == DeleteState.HasReferences)
                {
                    if (MessageBox.Show("На эту запись имеются ссылки из других таблиц. Удалить все равно? Связные записи будут удалены, либо заменениы на стандартые значения.",
                        "Удалить запись?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DBRepository.TryDeletePosition(index, true);
                    }
                }
                LoadPositionToGrid();
            }
        }

        private void PositionsDGV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex == PositionsDGV.Rows.Count - 1)
                return;
            Должности item = new Должности();
            item.Название = e.FormattedValue.ToString();
            for(int i = 0; i < PositionsDGV.Rows.Count - 1; i ++)
            {
                if(PositionsDGV[1, i].Value.ToString().CompareTo(e.FormattedValue) == 0 && i != e.RowIndex)
                {
                    ErrorLabel.Text = "Названия должностей не могут повторяться!";
                    ErrorLabel.Visible = true;
                    e.Cancel = true;
                    return;
                }
            }
            if ((int)PositionsDGV[0, e.RowIndex].Value < 0)
            {
                DBRepository.AddPosition(item);
                PositionsDGV[0, e.RowIndex].Value = item.Код;
            }
            else
            {
                item.Код = (int)PositionsDGV[0, e.RowIndex].Value;
                DBRepository.ChangePosition(item);
            }
            ErrorLabel.Visible = false;
        }

        private void PositionsDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ErrorLabel.Visible = true;
            ErrorLabel.Text = e.Exception.Message;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && !InventoryDGV.Rows[e.RowIndex].IsNewRow)
            {
                int index = (int)InventoryDGV[0, e.RowIndex].Value;
                DeleteState state = DBRepository.TryDeleteInventory(index);
                if (state == DeleteState.HasReferences)
                {
                    if (MessageBox.Show("На эту запись имеются ссылки из других таблиц. Удалить все равно? Связные записи будут удалены, либо заменениы на стандартые значения.",
                        "Удалить запись?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DBRepository.TryDeleteInventory(index, true);
                    }
                }
                LoadInventorytoGrig();
            }
        }

        private void InventoryDGV_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex == InventoryDGV.Rows.Count - 1)
                return;
            if ((string.IsNullOrEmpty(InventoryDGV[1, e.RowIndex].Value.ToString()) ||
                string.IsNullOrWhiteSpace(InventoryDGV[1, e.RowIndex].Value.ToString())))
            {
                InventoryDGV[1, e.RowIndex].Style.BackColor = Color.LightPink;
                InventoryDGV[2, e.RowIndex].Style.BackColor = Color.LightPink;
                return;
            }
            if ((string.IsNullOrEmpty(InventoryDGV[2, e.RowIndex].Value.ToString()) ||
                string.IsNullOrWhiteSpace(InventoryDGV[2, e.RowIndex].Value.ToString())))
            {
                InventoryDGV[1, e.RowIndex].Style.BackColor = Color.LightPink;
                InventoryDGV[2, e.RowIndex].Style.BackColor = Color.LightPink;
                return;
            }
            InventoryDGV[1, e.RowIndex].Style.BackColor = Color.White;
            InventoryDGV[2, e.RowIndex].Style.BackColor = Color.White;
            Инвентарь item = new Инвентарь();
            item.Название = InventoryDGV[1, e.RowIndex].Value.ToString();
            item.Количества = int.Parse(InventoryDGV[2, e.RowIndex].Value.ToString());
            if ((int)InventoryDGV[0, e.RowIndex].Value < 0)
            {
                DBRepository.AddInventory(item);
                LoadInventorytoGrig();
            }
            else
            {
                item.Код = (int)InventoryDGV[0, e.RowIndex].Value;
                DBRepository.ChangeInventory(item);
                LoadInventorytoGrig();
            }
            ErrorLabel.Visible = false;
        }

        private void инвентарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadInventorytoGrig();
        }

        private void выдачаИнвентаряToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDeliveryToGrid();
        }

        private void DeliveryDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7)
            {
                EditDeliveryForm form = new EditDeliveryForm(DBRepository.GetDelivery((int)DeliveryDGV[0, e.RowIndex].Value));
                form.Owner = this;
                form.Show();
            }
            if (e.ColumnIndex == 8)
            {
                int index = (int)DeliveryDGV[0, e.RowIndex].Value;
                DeleteState state = DBRepository.TryDeleteDelivery(index);
                if (state == DeleteState.HasInventory)
                {
                    if (MessageBox.Show("Инвентарь не сдан. Все равно удалить?", "Удалить запись?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DBRepository.TryDeleteDelivery(index, true);
                    }
                }
                LoadDeliveryToGrid();
            }
        }

        public void AddOccupancy(Заселение item)
        {
            LoadOccupancyToGrid();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadEmployeeToGrid();
        }

        private void EmployeersDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 4)
                e.Value = Resources.ic_mode_edit_black_18dp_1x;
            if(e.ColumnIndex == 5)
                e.Value = Resources.ic_delete_forever_black_18dp_1x;
        }

        private void EmployeersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                AddEmployeeForm form = new AddEmployeeForm((int)EmployeersDGV[0, e.RowIndex].Value);
                form.Owner = this;
                form.Show();
            }
            if(e.ColumnIndex == 5)
            {
                int index = (int)EmployeersDGV[0, e.RowIndex].Value;
                DeleteState state = DBRepository.TryDeleteEmployee(index);
                if (state == DeleteState.HasReferences)
                {
                    if (MessageBox.Show("На эту запись имеются ссылки из других таблиц. Удалить все равно? Связные записи будут удалены, либо заменениы на стандартые значения.", 
                        "Удалить запись?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DBRepository.TryDeleteEmployee(index, true);
                    }
                }
                LoadEmployeeToGrid();
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if(EmployeersDGV.Visible == true)
            {
                AddEmployeeForm form = new AddEmployeeForm(null);
                form.Owner = this;
                form.Show();
            }
            if(OccupancyDGV.Visible == true)
            {
                OccupancyEditForm form = new OccupancyEditForm(null);
                form.Owner = this;
                form.Show();
            }
            if(DeliveryDGV.Visible == true)
            {
                EditDeliveryForm form = new EditDeliveryForm(null);
                form.Owner = this;
                form.Show();
            }
            if(ViolationDGV.Visible)
            {
                AddViolationForm form = new AddViolationForm(null);
                form.Owner = this;
                form.Show();
            }
        }

        public void AddEmployee(Сотрудники item)
        {
            LoadEmployeeToGrid();
        }

        public void AddDelivery(ВыдачаИнвентаря item)
        {
            LoadDeliveryToGrid();
        }

        private void ViolationDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
                e.Value = Resources.ic_mode_edit_black_18dp_1x;
            if (e.ColumnIndex == 6)
                e.Value = Resources.ic_delete_forever_black_18dp_1x;
        }

        private void ViolationDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                AddViolationForm form = new AddViolationForm((int)ViolationDGV[0, e.RowIndex].Value);
                form.Owner = this;
                form.Show();
            }
            if(e.ColumnIndex == 6)
            {
                int index = (int)ViolationDGV[0, e.RowIndex].Value;
                DeleteState state = DBRepository.TryDeleteViolation(index);
                LoadViolationToGrid();
            }
        }

        private void нарушенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadViolationToGrid();
        }
    }
}
