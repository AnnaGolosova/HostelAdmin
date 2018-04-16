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
            //List<Жильцы> livers = DBRepository.GetLivers();
            LiversDGV.Visible = true;
            //LiversDGV.Rows.Clear();
            //foreach (Жильцы i in livers)
            //{
            //    LiversDGV.Rows.Add(i.Код, i.ФИО, i.Адрес, i.Пол ? "женский" : "мужской");
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hostelDataSet.Жильцы' table. You can move, or remove it, as needed.
            this.жильцыTableAdapter.Fill(this.hostelDataSet.Жильцы);

        }

        private void LiversDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
