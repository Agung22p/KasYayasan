namespace KasYayasan
{
    partial class Pengeluaran
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
            panel1 = new Panel();
            btnClear = new Button();
            btnTambah = new Button();
            txtJumlah = new TextBox();
            label3 = new Label();
            txtKeterangan = new TextBox();
            label1 = new Label();
            dgPengeluaran = new DataGridView();
            panel3 = new Panel();
            lblTotal = new Label();
            label12 = new Label();
            btnView = new Button();
            panel2 = new Panel();
            lblpengeluaran = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPengeluaran).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(txtJumlah);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtKeterangan);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 528);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.BackColor = Color.LightCoral;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Image = Properties.Resources.eraser;
            btnClear.Location = new Point(150, 478);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 37);
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
            btnTambah.Location = new Point(18, 478);
            btnTambah.Margin = new Padding(3, 2, 3, 2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(126, 37);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "Tambah";
            btnTambah.TextAlign = ContentAlignment.MiddleRight;
            btnTambah.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // txtJumlah
            // 
            txtJumlah.BorderStyle = BorderStyle.None;
            txtJumlah.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJumlah.Location = new Point(18, 101);
            txtJumlah.Margin = new Padding(3, 2, 3, 2);
            txtJumlah.Multiline = true;
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(213, 24);
            txtJumlah.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 76);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 4;
            label3.Text = "Jumlah :";
            // 
            // txtKeterangan
            // 
            txtKeterangan.BorderStyle = BorderStyle.None;
            txtKeterangan.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKeterangan.Location = new Point(18, 46);
            txtKeterangan.Margin = new Padding(3, 2, 3, 2);
            txtKeterangan.Multiline = true;
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(213, 24);
            txtKeterangan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(176, 19);
            label1.TabIndex = 0;
            label1.Text = "Keterangan Pengeluaran :";
            // 
            // dgPengeluaran
            // 
            dgPengeluaran.AllowUserToAddRows = false;
            dgPengeluaran.AllowUserToDeleteRows = false;
            dgPengeluaran.AllowUserToResizeColumns = false;
            dgPengeluaran.AllowUserToResizeRows = false;
            dgPengeluaran.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgPengeluaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPengeluaran.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgPengeluaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgPengeluaran.DefaultCellStyle = dataGridViewCellStyle1;
            dgPengeluaran.Location = new Point(266, 10);
            dgPengeluaran.Margin = new Padding(3, 2, 3, 2);
            dgPengeluaran.Name = "dgPengeluaran";
            dgPengeluaran.ReadOnly = true;
            dgPengeluaran.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgPengeluaran.RowHeadersVisible = false;
            dgPengeluaran.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dgPengeluaran.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgPengeluaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPengeluaran.Size = new Size(719, 443);
            dgPengeluaran.TabIndex = 14;
            dgPengeluaran.CellContentClick += dgPengeluaran_CellContentClick;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(789, 473);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(196, 64);
            panel3.TabIndex = 24;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(12, 33);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(108, 27);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Rp. 00.000";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 8);
            label12.Name = "label12";
            label12.Size = new Size(134, 19);
            label12.TabIndex = 0;
            label12.Text = "Total Pengeluaran :";
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnView.Image = Properties.Resources.report;
            btnView.Location = new Point(266, 457);
            btnView.Margin = new Padding(3, 2, 3, 2);
            btnView.Name = "btnView";
            btnView.Size = new Size(82, 79);
            btnView.TabIndex = 25;
            btnView.Text = "View All Items";
            btnView.TextAlign = ContentAlignment.BottomCenter;
            btnView.TextImageRelation = TextImageRelation.ImageAboveText;
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(lblpengeluaran);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(621, 472);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 64);
            panel2.TabIndex = 26;
            // 
            // lblpengeluaran
            // 
            lblpengeluaran.AutoSize = true;
            lblpengeluaran.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpengeluaran.Location = new Point(12, 33);
            lblpengeluaran.Name = "lblpengeluaran";
            lblpengeluaran.Size = new Size(34, 27);
            lblpengeluaran.TabIndex = 1;
            lblpengeluaran.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 8);
            label9.Name = "label9";
            label9.Size = new Size(147, 19);
            label9.TabIndex = 0;
            label9.Text = "Jumlah Pengeluaran :";
            // 
            // Pengeluaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 546);
            Controls.Add(panel2);
            Controls.Add(btnView);
            Controls.Add(panel3);
            Controls.Add(dgPengeluaran);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1012, 585);
            Name = "Pengeluaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock";
            Load += Pengeluaran_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPengeluaran).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtKeterangan;
        private Label label1;
        private TextBox txtJumlah;
        private Label label3;
        private Button btnTambah;
        private Button btnClear;
        private DataGridView dgPengeluaran;
        private Panel panel3;
        private Label lblTotal;
        private Label label12;
        private Button btnView;
        private Panel panel2;
        private Label lblpengeluaran;
        private Label label9;
    }
}