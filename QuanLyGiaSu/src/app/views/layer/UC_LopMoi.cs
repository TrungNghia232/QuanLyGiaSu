﻿using System;
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
    public partial class UC_LopMoi : UserControl
    {
        public UC_LopMoi()
        {
            InitializeComponent();
        }

        private void đăngKýDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKyDay dangKyDay = new DangKyDay();
            dangKyDay.Show();
        }
    }
}
