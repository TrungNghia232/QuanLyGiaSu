﻿namespace QuanLyGiaSu.src.app.views.Login
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.llb_DangKyGiaSu = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.llb_DangKyPhuHuynh = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCannotLogin = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // llb_DangKyGiaSu
            // 
            this.llb_DangKyGiaSu.AutoSize = true;
            this.llb_DangKyGiaSu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_DangKyGiaSu.LinkColor = System.Drawing.Color.Black;
            this.llb_DangKyGiaSu.Location = new System.Drawing.Point(743, 532);
            this.llb_DangKyGiaSu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llb_DangKyGiaSu.Name = "llb_DangKyGiaSu";
            this.llb_DangKyGiaSu.Size = new System.Drawing.Size(109, 21);
            this.llb_DangKyGiaSu.TabIndex = 44;
            this.llb_DangKyGiaSu.TabStop = true;
            this.llb_DangKyGiaSu.Text = "Đăng ký ngay!";
            this.llb_DangKyGiaSu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_DangKyGiaSu_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(520, 534);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Đăng ký làm gia sư ==>";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(437, 412);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(467, 2);
            this.label4.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(436, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(467, 2);
            this.label3.TabIndex = 41;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Blue;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(493, 489);
            this.button_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(357, 42);
            this.button_Login.TabIndex = 39;
            this.button_Login.Text = "Đăng nhập";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Gray;
            this.tbPassword.Location = new System.Drawing.Point(493, 388);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(404, 20);
            this.tbPassword.TabIndex = 36;
            this.tbPassword.Text = "Password";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Click += new System.EventHandler(this.textBox_Password_Click);
            this.tbPassword.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbUserName
            // 
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.Color.Gray;
            this.tbUserName.Location = new System.Drawing.Point(493, 338);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(404, 20);
            this.tbUserName.TabIndex = 34;
            this.tbUserName.Tag = "";
            this.tbUserName.Text = "Username";
            this.tbUserName.Click += new System.EventHandler(this.textBox_User_Click);
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(429, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 33);
            this.label2.TabIndex = 35;
            this.label2.Text = "ĐĂNG NHẬP";
            // 
            // llb_DangKyPhuHuynh
            // 
            this.llb_DangKyPhuHuynh.AutoSize = true;
            this.llb_DangKyPhuHuynh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_DangKyPhuHuynh.LinkColor = System.Drawing.Color.Black;
            this.llb_DangKyPhuHuynh.Location = new System.Drawing.Point(743, 564);
            this.llb_DangKyPhuHuynh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llb_DangKyPhuHuynh.Name = "llb_DangKyPhuHuynh";
            this.llb_DangKyPhuHuynh.Size = new System.Drawing.Size(109, 21);
            this.llb_DangKyPhuHuynh.TabIndex = 49;
            this.llb_DangKyPhuHuynh.TabStop = true;
            this.llb_DangKyPhuHuynh.Text = "Đăng ký ngay!";
            this.llb_DangKyPhuHuynh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_DangKyPhuHuynh_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(520, 564);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Đăng ký tài khoản phụ huynh ==>";
            // 
            // lbCannotLogin
            // 
            this.lbCannotLogin.AutoSize = true;
            this.lbCannotLogin.ForeColor = System.Drawing.Color.Red;
            this.lbCannotLogin.Location = new System.Drawing.Point(491, 418);
            this.lbCannotLogin.Name = "lbCannotLogin";
            this.lbCannotLogin.Size = new System.Drawing.Size(261, 16);
            this.lbCannotLogin.TabIndex = 50;
            this.lbCannotLogin.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
            this.lbCannotLogin.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::QuanLyGiaSu.Properties.Resources.password_24px1;
            this.pictureBox3.Location = new System.Drawing.Point(440, 384);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::QuanLyGiaSu.Properties.Resources.user_male_30px1;
            this.pictureBox2.Location = new System.Drawing.Point(440, 332);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.button_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 625);
            this.Controls.Add(this.lbCannotLogin);
            this.Controls.Add(this.llb_DangKyPhuHuynh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llb_DangKyGiaSu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Vào Trung Tâm Gia Sư Anh Em";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llb_DangKyGiaSu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llb_DangKyPhuHuynh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCannotLogin;
    }
}