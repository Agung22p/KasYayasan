namespace KasYayasan
{
    partial class Statistik_Donasi
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblToday = new Label();
            lblYesterday = new Label();
            lblThisWeek = new Label();
            lblThisMonth = new Label();
            lblTotal = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblThisMonth);
            panel1.Controls.Add(lblThisWeek);
            panel1.Controls.Add(lblYesterday);
            panel1.Controls.Add(lblToday);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 296);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 15);
            label1.Name = "label1";
            label1.Size = new Size(203, 36);
            label1.TabIndex = 0;
            label1.Text = "Statistik Donasi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 79);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 1;
            label2.Text = "Hari ini                :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 119);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 2;
            label3.Text = "Kemarin              :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 159);
            label4.Name = "label4";
            label4.Size = new Size(135, 23);
            label4.TabIndex = 3;
            label4.Text = "Minggu ini          :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 199);
            label5.Name = "label5";
            label5.Size = new Size(136, 23);
            label5.TabIndex = 4;
            label5.Text = "Bulan ini              :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(82, 240);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 5;
            label6.Text = "Total Donatur :";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblToday
            // 
            lblToday.AutoSize = true;
            lblToday.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToday.Location = new Point(201, 79);
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(30, 23);
            lblToday.TabIndex = 6;
            lblToday.Text = "00";
            lblToday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblYesterday
            // 
            lblYesterday.AutoSize = true;
            lblYesterday.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYesterday.Location = new Point(201, 119);
            lblYesterday.Name = "lblYesterday";
            lblYesterday.Size = new Size(30, 23);
            lblYesterday.TabIndex = 7;
            lblYesterday.Text = "00";
            lblYesterday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblThisWeek
            // 
            lblThisWeek.AutoSize = true;
            lblThisWeek.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThisWeek.Location = new Point(201, 159);
            lblThisWeek.Name = "lblThisWeek";
            lblThisWeek.Size = new Size(30, 23);
            lblThisWeek.TabIndex = 8;
            lblThisWeek.Text = "00";
            lblThisWeek.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblThisMonth
            // 
            lblThisMonth.AutoSize = true;
            lblThisMonth.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThisMonth.Location = new Point(201, 199);
            lblThisMonth.Name = "lblThisMonth";
            lblThisMonth.Size = new Size(30, 23);
            lblThisMonth.TabIndex = 9;
            lblThisMonth.Text = "00";
            lblThisMonth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(214, 240);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(30, 23);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "00";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Statistik_Donasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 75, 243);
            ClientSize = new Size(422, 351);
            Controls.Add(panel1);
            Name = "Statistik_Donasi";
            Text = "Statistik_Donasi";
            Load += Statistik_Donasi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblTotal;
        private Label lblThisMonth;
        private Label lblThisWeek;
        private Label lblYesterday;
        private Label lblToday;
    }
}