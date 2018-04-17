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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainDGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Debug.WriteLine($"MainDGV_RowsAdded {e.RowIndex}/{e.RowCount}");
        }

        private void MainDGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Debug.WriteLine($"MainDGV_RowsRemoved {e.RowIndex}/{e.RowCount}");
        }

        private void MainDGV_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            Debug.WriteLine($"MainDGV_RowValidating {e.ColumnIndex}/{e.RowIndex}");
            
        }

        private void MainDGV_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine($"MainDGV_RowValidated {e.ColumnIndex}/{e.RowIndex}");
        }

        public void LoadOccupancyToGrid()
        {
            List<OccupancyFull> list = DBRepository.GetОccupancy();
            OccupancyDGV.Rows.Clear();
            RoomDGV.Visible = false;
            LiversDGV.Visible = false;
            OccupancyDGV.Visible = true;
            foreach (OccupancyFull full in list)
            {
                Bitmap editImage = new Bitmap(Resources.ic_mode_edit_black_18dp_1x);
                Bitmap deleteImage = new Bitmap(Resources.ic_delete_forever_black_18dp_1x);
                OccupancyDGV.Rows.Add(full.Код, full.КодКомнаты, full.НомерКомнаты, full.ФИО, full.Этаж, full.Адрес, full.Пол,
                    full.ДатаЗаселения.ToShortDateString(), full.ДатаВыселения == null ? "" : ((DateTime)full.ДатаВыселения).ToShortDateString(), editImage, deleteImage);
            }
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
            // TODO: This line of code loads data into the 'hostelDataSet.Комнаты' table. You can move, or remove it, as needed.

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

                DBRepository.ChangeLiver(item);
            }
        }

        private void LiversDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (LiversDGV.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == 4)
            {
                e.Value = Resources.ic_delete_forever_black_18dp_1x;
            }
        }

        public void LoadLiversToDrid()
        {
            this.жильцыTableAdapter.Fill(this.hostelDataSet.Жильцы);
            LiversDGV.Columns[0].Visible = false;

            RoomDGV.Visible = false;
            LiversDGV.Visible = true;
            OccupancyDGV.Visible = false;
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
            RoomDGV.Visible = true;
            LiversDGV.Visible = false;
            OccupancyDGV.Visible = false;

            this.комнатыTableAdapter.Fill(this.hostelDataSet.Комнаты);
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
    }
}
