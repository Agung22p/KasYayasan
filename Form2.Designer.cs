namespace KasYayasan
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnPayments = new Button();
            btnCustomers = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            lblJumlahDonatur = new Label();
            label8 = new Label();
            panel3 = new Panel();
            lblJumlahPengeluaran = new Label();
            label4 = new Label();
            panel2 = new Panel();
            lblJumlahPenerimaan = new Label();
            label1 = new Label();
            btnRefresh = new Button();
            btnExit = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnPayments
            // 
            btnPayments.BackColor = Color.WhiteSmoke;
            btnPayments.Font = new Font("Calibri", 9F);
            btnPayments.Image = Properties.Resources.credit_card;
            btnPayments.Location = new Point(141, 31);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(97, 103);
            btnPayments.TabIndex = 3;
            btnPayments.Text = "Pengeluaran";
            btnPayments.TextAlign = ContentAlignment.BottomCenter;
            btnPayments.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPayments.UseVisualStyleBackColor = false;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.WhiteSmoke;
            btnCustomers.Font = new Font("Calibri", 9F);
            btnCustomers.Image = Properties.Resources.value;
            btnCustomers.Location = new Point(35, 31);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(97, 103);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "Penerimaan";
            btnCustomers.TextAlign = ContentAlignment.BottomCenter;
            btnCustomers.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(165, 189, 255);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(669, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 512);
            panel1.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblJumlahDonatur);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(22, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 91);
            panel5.TabIndex = 2;
            // 
            // lblJumlahDonatur
            // 
            lblJumlahDonatur.AutoSize = true;
            lblJumlahDonatur.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahDonatur.ForeColor = Color.FromArgb(72, 75, 243);
            lblJumlahDonatur.Location = new Point(11, 39);
            lblJumlahDonatur.Name = "lblJumlahDonatur";
            lblJumlahDonatur.Size = new Size(43, 35);
            lblJumlahDonatur.TabIndex = 1;
            lblJumlahDonatur.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(11, 15);
            label8.Name = "label8";
            label8.Size = new Size(153, 24);
            label8.TabIndex = 0;
            label8.Text = "Jumlah Donatur :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblJumlahPengeluaran);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(22, 229);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 91);
            panel3.TabIndex = 2;
            // 
            // lblJumlahPengeluaran
            // 
            lblJumlahPengeluaran.AutoSize = true;
            lblJumlahPengeluaran.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahPengeluaran.ForeColor = Color.FromArgb(72, 75, 243);
            lblJumlahPengeluaran.Location = new Point(11, 39);
            lblJumlahPengeluaran.Name = "lblJumlahPengeluaran";
            lblJumlahPengeluaran.Size = new Size(136, 35);
            lblJumlahPengeluaran.TabIndex = 1;
            lblJumlahPengeluaran.Text = "Rp. 00.000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 15);
            label4.Name = "label4";
            label4.Size = new Size(193, 24);
            label4.TabIndex = 0;
            label4.Text = "Jumlah Pengeluaran : ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblJumlahPenerimaan);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(22, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 91);
            panel2.TabIndex = 0;
            // 
            // lblJumlahPenerimaan
            // 
            lblJumlahPenerimaan.AutoSize = true;
            lblJumlahPenerimaan.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahPenerimaan.ForeColor = Color.FromArgb(72, 75, 243);
            lblJumlahPenerimaan.Location = new Point(11, 39);
            lblJumlahPenerimaan.Name = "lblJumlahPenerimaan";
            lblJumlahPenerimaan.Size = new Size(136, 35);
            lblJumlahPenerimaan.TabIndex = 1;
            lblJumlahPenerimaan.Text = "Rp. 00.000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(189, 24);
            label1.TabIndex = 0;
            label1.Text = "Jumlah Penerimaan : ";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefresh.BackColor = Color.WhiteSmoke;
            btnRefresh.Font = new Font("Calibri", 9F);
            btnRefresh.Image = Properties.Resources.reload__1_;
            btnRefresh.Location = new Point(37, 465);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 31);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.BackColor = Color.WhiteSmoke;
            btnExit.Font = new Font("Calibri", 9F);
            btnExit.Image = Properties.Resources.reject;
            btnExit.Location = new Point(128, 465);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Calibri", 9F);
            button1.Image = Properties.Resources.invoice;
            button1.Location = new Point(246, 31);
            button1.Name = "button1";
            button1.Size = new Size(97, 103);
            button1.TabIndex = 7;
            button1.Text = "Statistik Donasi";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.Font = new Font("Calibri", 9F);
            button2.Image = Properties.Resources.summary;
            button2.Location = new Point(351, 31);
            button2.Name = "button2";
            button2.Size = new Size(97, 103);
            button2.TabIndex = 8;
            button2.Text = "Rekapitulasi";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(955, 516);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            Controls.Add(btnCustomers);
            Controls.Add(btnPayments);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(971, 552);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Workstation";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnPayments;
        private Button btnCustomers;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel5;
        private Label lblJumlahDonatur;
        private Label label8;
        private Panel panel3;
        private Label lblJumlahPengeluaran;
        private Label label4;
        private Label lblJumlahPenerimaan;
        private Button btnRefresh;
        private Button btnExit;
        private Button button1;
        private Button button2;
    }
}