﻿namespace QuanLyGiaSu.src.views.layer.tutors
{
    partial class UC_LopMoiChoGiaSu
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
            this.btn_Tim = new System.Windows.Forms.Button();
            this.cbb_TimTheo = new System.Windows.Forms.ComboBox();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTHONGTINLOPMOI = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DangKyDayHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_TimKiem = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHONGTINLOPMOI)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(1109, 22);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 33);
            this.btn_Tim.TabIndex = 27;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_TimLM_Click);
            // 
            // cbb_TimTheo
            // 
            this.cbb_TimTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TimTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimTheo.FormattingEnabled = true;
            this.cbb_TimTheo.Items.AddRange(new object[] {
            "Mã Lớp",
            "Môn Học",
            "Lớp Học",
            "Tất Cả"});
            this.cbb_TimTheo.Location = new System.Drawing.Point(625, 22);
            this.cbb_TimTheo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_TimTheo.Name = "cbb_TimTheo";
            this.cbb_TimTheo.Size = new System.Drawing.Size(192, 33);
            this.cbb_TimTheo.TabIndex = 25;
            this.cbb_TimTheo.SelectedIndexChanged += new System.EventHandler(this.cbb_TimTheoLM_SelectedIndexChanged);
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem.Location = new System.Drawing.Point(823, 23);
            this.tb_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(256, 30);
            this.tb_TimKiem.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tìm Theo :";
            // 
            // dgvTHONGTINLOPMOI
            // 
            this.dgvTHONGTINLOPMOI.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTHONGTINLOPMOI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTHONGTINLOPMOI.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTHONGTINLOPMOI.Location = new System.Drawing.Point(16, 60);
            this.dgvTHONGTINLOPMOI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTHONGTINLOPMOI.Name = "dgvTHONGTINLOPMOI";
            this.dgvTHONGTINLOPMOI.RowHeadersWidth = 51;
            this.dgvTHONGTINLOPMOI.RowTemplate.Height = 24;
            this.dgvTHONGTINLOPMOI.Size = new System.Drawing.Size(1277, 453);
            this.dgvTHONGTINLOPMOI.TabIndex = 22;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DangKyDayHoc});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 28);
            // 
            // DangKyDayHoc
            // 
            this.DangKyDayHoc.Name = "DangKyDayHoc";
            this.DangKyDayHoc.Size = new System.Drawing.Size(163, 24);
            this.DangKyDayHoc.Text = "Đăng Ký Dạy";
            this.DangKyDayHoc.Click += new System.EventHandler(this.DangKyDayHoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "LỚP MỚI";
            // 
            // cbb_TimKiem
            // 
            this.cbb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimKiem.FormattingEnabled = true;
            this.cbb_TimKiem.Items.AddRange(new object[] {
            "Lớp 1",
            "Lớp 2",
            "Lớp 3",
            "Lớp 4",
            "Lớp 5",
            "Lớp 6",
            "Lớp 7",
            "Lớp 8",
            "Lớp 9",
            "Lớp 10",
            "Lớp 11",
            "Lớp 12"});
            this.cbb_TimKiem.Location = new System.Drawing.Point(823, 22);
            this.cbb_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_TimKiem.Name = "cbb_TimKiem";
            this.cbb_TimKiem.Size = new System.Drawing.Size(256, 33);
            this.cbb_TimKiem.TabIndex = 29;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_LopMoiChoGiaSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.cbb_TimKiem);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.cbb_TimTheo);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTHONGTINLOPMOI);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_LopMoiChoGiaSu";
            this.Size = new System.Drawing.Size(1309, 533);
            this.Load += new System.EventHandler(this.UC_LopMoiChoGiaSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHONGTINLOPMOI)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.ComboBox cbb_TimTheo;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTHONGTINLOPMOI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DangKyDayHoc;
        private System.Windows.Forms.ComboBox cbb_TimKiem;
        private System.Windows.Forms.Timer timer1;
    }
}
