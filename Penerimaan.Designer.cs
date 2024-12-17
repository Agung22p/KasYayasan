namespace KasYayasan
{
    partial class Penerimaan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penerimaan));
            panel1 = new Panel();
            btnClear = new Button();
            btnTambah = new Button();
            txtNoHp = new TextBox();
            label4 = new Label();
            txtJumlah = new TextBox();
            label3 = new Label();
            txtAlamat = new TextBox();
            label2 = new Label();
            txtNamaDonatur = new TextBox();
            label1 = new Label();
            dgPenerimaan = new DataGridView();
            panel2 = new Panel();
            lblDonatur = new Label();
            label9 = new Label();
            panel3 = new Panel();
            lblJumlah = new Label();
            label12 = new Label();
            btnView = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPenerimaan).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(txtNoHp);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtJumlah);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAlamat);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNamaDonatur);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 704);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.BackColor = Color.LightCoral;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Image = Properties.Resources.eraser;
            btnClear.Location = new Point(171, 637);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 49);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnTambah
            // 
            btnTambah.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTambah.BackColor = Color.FromArgb(72, 75, 243);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.ForeColor = Color.White;
            btnTambah.Image = Properties.Resources.plus__1_;
            btnTambah.Location = new Point(21, 637);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(144, 49);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "Tambah";
            btnTambah.TextAlign = ContentAlignment.MiddleRight;
            btnTambah.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // txtNoHp
            // 
            txtNoHp.BorderStyle = BorderStyle.None;
            txtNoHp.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoHp.Location = new Point(21, 269);
            txtNoHp.Multiline = true;
            txtNoHp.Name = "txtNoHp";
            txtNoHp.Size = new Size(243, 32);
            txtNoHp.TabIndex = 3;
            txtNoHp.KeyPress += txtNoHp_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 235);
            label4.Name = "label4";
            label4.Size = new Size(106, 24);
            label4.TabIndex = 6;
            label4.Text = "Nomor Hp :";
            // 
            // txtJumlah
            // 
            txtJumlah.BorderStyle = BorderStyle.None;
            txtJumlah.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJumlah.Location = new Point(21, 200);
            txtJumlah.Multiline = true;
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(243, 32);
            txtJumlah.TabIndex = 2;
            txtJumlah.TextChanged += txtJumlah_TextChanged;
            txtJumlah.KeyPress += txtJumlah_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 165);
            label3.Name = "label3";
            label3.Size = new Size(79, 24);
            label3.TabIndex = 4;
            label3.Text = "Jumlah :";
            // 
            // txtAlamat
            // 
            txtAlamat.BorderStyle = BorderStyle.None;
            txtAlamat.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAlamat.Location = new Point(21, 131);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(243, 32);
            txtAlamat.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 97);
            label2.Name = "label2";
            label2.Size = new Size(80, 24);
            label2.TabIndex = 2;
            label2.Text = "Alamat :";
            // 
            // txtNamaDonatur
            // 
            txtNamaDonatur.BorderStyle = BorderStyle.None;
            txtNamaDonatur.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamaDonatur.Location = new Point(21, 61);
            txtNamaDonatur.Multiline = true;
            txtNamaDonatur.Name = "txtNamaDonatur";
            txtNamaDonatur.Size = new Size(243, 32);
            txtNamaDonatur.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 28);
            label1.Name = "label1";
            label1.Size = new Size(161, 24);
            label1.TabIndex = 0;
            label1.Text = "Nama Pendonasi :";
            // 
            // dgPenerimaan
            // 
            dgPenerimaan.AllowUserToAddRows = false;
            dgPenerimaan.AllowUserToDeleteRows = false;
            dgPenerimaan.AllowUserToResizeColumns = false;
            dgPenerimaan.AllowUserToResizeRows = false;
            dgPenerimaan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgPenerimaan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPenerimaan.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgPenerimaan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgPenerimaan.DefaultCellStyle = dataGridViewCellStyle1;
            dgPenerimaan.Location = new Point(304, 13);
            dgPenerimaan.Name = "dgPenerimaan";
            dgPenerimaan.ReadOnly = true;
            dgPenerimaan.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgPenerimaan.RowHeadersVisible = false;
            dgPenerimaan.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dgPenerimaan.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgPenerimaan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPenerimaan.Size = new Size(822, 591);
            dgPenerimaan.TabIndex = 14;
            dgPenerimaan.CellContentClick += dgPenerimaan_CellContentClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(lblDonatur);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(750, 631);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 85);
            panel2.TabIndex = 23;
            // 
            // lblDonatur
            // 
            lblDonatur.AutoSize = true;
            lblDonatur.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonatur.Location = new Point(14, 44);
            lblDonatur.Name = "lblDonatur";
            lblDonatur.Size = new Size(43, 35);
            lblDonatur.TabIndex = 1;
            lblDonatur.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 11);
            label9.Name = "label9";
            label9.Size = new Size(153, 24);
            label9.TabIndex = 0;
            label9.Text = "Jumlah Donatur :";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(lblJumlah);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(941, 631);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 85);
            panel3.TabIndex = 24;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlah.Location = new Point(14, 44);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(136, 35);
            lblJumlah.TabIndex = 1;
            lblJumlah.Text = "Rp. 00.000";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(14, 11);
            label12.Name = "label12";
            label12.Size = new Size(79, 24);
            label12.TabIndex = 0;
            label12.Text = "Jumlah :";
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnView.Image = Properties.Resources.report;
            btnView.Location = new Point(304, 609);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 105);
            btnView.TabIndex = 25;
            btnView.Text = "View All Items";
            btnView.TextAlign = ContentAlignment.BottomCenter;
            btnView.TextImageRelation = TextImageRelation.ImageAboveText;
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnViewStock_Click;
            // 
            // Penerimaan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 728);
            Controls.Add(btnView);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dgPenerimaan);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1154, 764);
            Name = "Penerimaan";
            Text = "Stock";
            Load += Penerimaan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPenerimaan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNamaDonatur;
        private Label label1;
        private TextBox txtAlamat;
        private Label label2;
        private TextBox txtNoHp;
        private Label label4;
        private TextBox txtJumlah;
        private Label label3;
        private Button btnTambah;
        private Button btnClear;
        private DataGridView dgPenerimaan;
        private Panel panel2;
        private Label lblDonatur;
        private Label label9;
        private Panel panel3;
        private Label lblJumlah;
        private Label label12;
        private Button btnView;
    }
}