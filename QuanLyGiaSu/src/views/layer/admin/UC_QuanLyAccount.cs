﻿using QuanLyGiaSu.src.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaSu.src.views.layer.admin
{
    public partial class UC_QuanLyAccount : UserControl
    {
        public UC_QuanLyAccount()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void UC_QuanLyAccount_Load(object sender, EventArgs e)
        {
            dgvQLyAccount.DataSource = Locator.server.fetchAccount();
            dgvQLyAccount.Columns["ACCID"].Width = 60;
            dgvQLyAccount.Columns["PhanQuyen"].Width = 100;
            dgvQLyAccount.Columns["Username"].Width = 150;
            dgvQLyAccount.Columns["Password"].Width = 150;
            dgvQLyAccount.Columns["Email"].Width = 250;
            dgvQLyAccount.Columns["NganSach"].Width = 200;
        }

        private void NapTien_Click(object sender, EventArgs e)
        {
            NapTienAdmin napTienAdmin1 = new NapTienAdmin();
            napTienAdmin1.ShowThongTinNapTien(dgvQLyAccount.CurrentRow.Cells[2].Value.ToString());
            napTienAdmin1.FormClosing += new FormClosingEventHandler(this.NapTienAdmin_FormClosing);
            napTienAdmin1.Show();
        }

        private void dgvQLyAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQLyAccount.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvQLyAccount.CurrentRow.Selected = true;
            }
        }
      
        private void cbbTimTheoAcount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TimTheoAccount.Text == "Tất Cả")
            {
                tb_TimKiemAccount.Text = "";
                tb_TimKiemAccount.Enabled = false;
                dgvQLyAccount.DataSource = Locator.server.fetchAccount();
            }
            else
                tb_TimKiemAccount.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbb_TimTheoAccount.Text == "User Name")
            {
                dgvQLyAccount.DataSource = Locator.server.TimKiem_Account_UserName(tb_TimKiemAccount.Text);
            }
            else if (cbb_TimTheoAccount.Text == "Account ID")
            {
                dgvQLyAccount.DataSource = Locator.server.TimKiem_Account_ACCID(Convert.ToInt32(tb_TimKiemAccount.Text));
            }
        }

        private void removeAccount_Click(object sender, EventArgs e)
        {
            Locator.server.removeAccount(Int32.Parse(dgvQLyAccount.CurrentRow.Cells[0].Value.ToString()));
            UC_QuanLyAccount_Load(sender, e);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QuanLyAccount_Load(sender, e);
            //MessageBox.Show("Load");
        }
        private void NapTienAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            UC_QuanLyAccount_Load(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvQLyAccount.Rows.Count - 1; i++)
            {
                if (dgvQLyAccount.Rows[i].Cells[1].Value.ToString() == "Gia sư")
                {
                    dgvQLyAccount.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(0, 255, 255);
                }
                else
                {
                    dgvQLyAccount.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 228, 181);

                }
            }
        }
    }
}
