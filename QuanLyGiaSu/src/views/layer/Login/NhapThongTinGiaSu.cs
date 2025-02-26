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

namespace QuanLyGiaSu.src.app.views.Login
{
    public partial class NhapThongTinGiaSu : Form
    {
        public NhapThongTinGiaSu()
        {
            InitializeComponent();
            tmCheckBtn.Start();
            btnRegister.Enabled = false;
            btnRegister.BackColor = Color.Gray;

            Locator.server.addCheckedListBoxLopHoc(clbLopDay);
            Locator.server.addCheckedListBoxMonHoc(clbMonDay);
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //  TẠO ACCOUNT
            if (Locator.server.addAccount(Locator.author))
            {
                // UPDATE THÔNG TIN

                List<string> MonHoc = new List<string>();
                

                List<string> LopHoc = new List<string>();
                
                if (!Locator.server.updateInfoTutor(
                    Locator.author.UserName,
                    tbName.Text,
                    tbCMND.Text,
                    cbGender.Text,
                    Convert.ToDateTime(dtBirthDay.Value.ToString()),
                    tbPhone.Text,
                    tbQueQuan.Text,
                    tbAddress.Text,
                    tbSchool.Text,
                    cbTrinhDo.Text,
                    tbUuDiem.Text
                ))
                {
                    
                    return;
                }
                foreach (string item in clbMonDay.CheckedItems)
                {
                    Locator.server.insertMonHocGiaSu(Locator.author.UserName, item.ToString());
                }
                foreach (string item in clbLopDay.CheckedItems)
                {
                    Locator.server.insertLopHocGiaSu(Locator.author.UserName, item.ToString());
                }
            }
            else
            {
                return;
            }


            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        bool checkButton()
        {
            if (
                tbAddress.Text.Length > 0
                && tbCMND.Text.Length > 0
                && tbName.Text.Length > 0
                && tbPhone.Text.Length > 0
                && tbQueQuan.Text.Length > 0
                && tbSchool.Text.Length > 0
                && tbUuDiem.Text.Length > 0
                && cbGender.Text.Length > 0
                && cbTrinhDo.Text.Length > 0) return true;  
            return false;
        }

        private void tmCheckBtn_Tick(object sender, EventArgs e)
        {
            if (!checkButton())
            {
                btnRegister.Enabled = false;
                btnRegister.BackColor = Color.Gray;
            }
            else
            {
                btnRegister.Enabled = true;
                btnRegister.BackColor = Color.Blue;
            }
        }

        private void NhapThongTinGiaSu_Load(object sender, EventArgs e)
        {
            
        }

    }
}
