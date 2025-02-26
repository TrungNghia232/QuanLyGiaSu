﻿namespace QuanLyGiaSu.src.views.layer.admin
{
    partial class UC_QuanLyAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbb_TimTheoAccount = new System.Windows.Forms.ComboBox();
            this.tb_TimKiemAccount = new System.Windows.Forms.TextBox();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.dgvQLyAccount = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NapTien = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.btn_TimAccount = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLyAccount)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_TimTheoAccount
            // 
            this.cbb_TimTheoAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TimTheoAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimTheoAccount.FormattingEnabled = true;
            this.cbb_TimTheoAccount.Items.AddRange(new object[] {
            "User Name",
            "Account ID",
            "Tất Cả"});
            this.cbb_TimTheoAccount.Location = new System.Drawing.Point(504, 15);
            this.cbb_TimTheoAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_TimTheoAccount.Name = "cbb_TimTheoAccount";
            this.cbb_TimTheoAccount.Size = new System.Drawing.Size(145, 28);
            this.cbb_TimTheoAccount.TabIndex = 25;
            this.cbb_TimTheoAccount.SelectedIndexChanged += new System.EventHandler(this.cbbTimTheoAcount_SelectedIndexChanged);
            // 
            // tb_TimKiemAccount
            // 
            this.tb_TimKiemAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiemAccount.Location = new System.Drawing.Point(662, 17);
            this.tb_TimKiemAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_TimKiemAccount.Name = "tb_TimKiemAccount";
            this.tb_TimKiemAccount.Size = new System.Drawing.Size(193, 26);
            this.tb_TimKiemAccount.TabIndex = 24;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiem.Location = new System.Drawing.Point(419, 18);
            this.lbTimKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(82, 20);
            this.lbTimKiem.TabIndex = 23;
            this.lbTimKiem.Text = "Tìm Theo :";
            // 
            // dgvQLyAccount
            // 
            this.dgvQLyAccount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQLyAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLyAccount.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvQLyAccount.Location = new System.Drawing.Point(12, 50);
            this.dgvQLyAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvQLyAccount.Name = "dgvQLyAccount";
            this.dgvQLyAccount.RowHeadersWidth = 51;
            this.dgvQLyAccount.RowTemplate.Height = 24;
            this.dgvQLyAccount.Size = new System.Drawing.Size(958, 368);
            this.dgvQLyAccount.TabIndex = 22;
            this.dgvQLyAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLyAccount_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NapTien,
            this.removeAccount,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 70);
            // 
            // NapTien
            // 
            this.NapTien.Name = "NapTien";
            this.NapTien.Size = new System.Drawing.Size(121, 22);
            this.NapTien.Text = "Nạp Tiền";
            this.NapTien.Click += new System.EventHandler(this.NapTien_Click);
            // 
            // removeAccount
            // 
            this.removeAccount.Name = "removeAccount";
            this.removeAccount.Size = new System.Drawing.Size(121, 22);
            this.removeAccount.Text = "Xóa";
            this.removeAccount.Click += new System.EventHandler(this.removeAccount_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(21, 16);
            this.lbTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(276, 31);
            this.lbTieuDe.TabIndex = 21;
            this.lbTieuDe.Text = "QUẢN LÝ ACCOUNT";
            // 
            // btn_TimAccount
            // 
            this.btn_TimAccount.Location = new System.Drawing.Point(880, 18);
            this.btn_TimAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TimAccount.Name = "btn_TimAccount";
            this.btn_TimAccount.Size = new System.Drawing.Size(69, 24);
            this.btn_TimAccount.TabIndex = 26;
            this.btn_TimAccount.Text = "Tìm";
            this.btn_TimAccount.UseVisualStyleBackColor = true;
            this.btn_TimAccount.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_QuanLyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_TimAccount);
            this.Controls.Add(this.cbb_TimTheoAccount);
            this.Controls.Add(this.tb_TimKiemAccount);
            this.Controls.Add(this.lbTimKiem);
            this.Controls.Add(this.dgvQLyAccount);
            this.Controls.Add(this.lbTieuDe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_QuanLyAccount";
            this.Size = new System.Drawing.Size(982, 433);
            this.Load += new System.EventHandler(this.UC_QuanLyAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLyAccount)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_TimTheoAccount;
        private System.Windows.Forms.TextBox tb_TimKiemAccount;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.DataGridView dgvQLyAccount;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Button btn_TimAccount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NapTien;
        private System.Windows.Forms.ToolStripMenuItem removeAccount;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}
