﻿using QuanLyGiaSu.src.controller;
using QuanLyGiaSu.src.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu.src.app.views.layer
{
    public partial class UC_QuanLyGiaSu : UserControl
    {
        TRUNGTAMGIASUDataContext db;
        public UC_QuanLyGiaSu()
        {
            InitializeComponent();
            db = new TRUNGTAMGIASUDataContext();
            comboBox1.Text = comboBox1.Items[0].ToString();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Lớp Dạy")
            {
               tb_TimKiem.Hide();
                cbb_TimKiem.Visible = true;
            }
            else
            {
                cbb_TimKiem.Hide();
                tb_TimKiem.Visible = true;
            }
        }

        private void UC_QuanLyGiaSu_Load(object sender, EventArgs e)
        {
            cbb_TimKiem.Hide();
            dgvQuanLyGiaSu.DataSource=Locator.server.fetchGiaSuTable();
        }

        private void SuaThongTinGiaSu_Click(object sender, EventArgs e)
        {
            SuaGiaSu suaGiaSu1 = new SuaGiaSu();
            suaGiaSu1.ShowThongTinGiaSu(dgvQuanLyGiaSu.CurrentRow.Cells[0].Value.ToString(),
                dgvQuanLyGiaSu.CurrentRow.Cells[11].Value.ToString(),
                dgvQuanLyGiaSu.CurrentRow.Cells[2].Value.ToString(),
                dgvQuanLyGiaSu.CurrentRow.Cells[5].Value.ToString(),
                dgvQuanLyGiaSu.CurrentRow.Cells[3].Value.ToString(),
                dgvQuanLyGiaSu.CurrentRow.Cells[6].Value.ToString(),
                dgvQuanLyGiaSu.CurrentRow.Cells[4].Value.ToString(),
                dgvQuanLyGiaSu.CurrentRow.Cells[13].Value.ToString(),
                dgvQuanLyGiaSu.CurrentRow.Cells[9].Value.ToString(),
                dgvQuanLyGiaSu.CurrentRow.Cells[12].Value.ToString(),
                dgvQuanLyGiaSu.CurrentRow.Cells[10].Value.ToString()
                );
            suaGiaSu1.Show();
        }

        private void ThemGiaSu_Click(object sender, EventArgs e)
        {
            ThemAccount themAccount = new ThemAccount();
            themAccount.Show();
        }

        private void dgvQuanLyGiaSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLyGiaSu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvQuanLyGiaSu.CurrentRow.Selected = true;
            }
        }
    }
}
