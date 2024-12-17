namespace KasYayasan
{
    partial class Rekapitulasi
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            dgRecap = new DataGridView();
            panel1 = new Panel();
            dtFrom = new DateTimePicker();
            label2 = new Label();
            panel2 = new Panel();
            dtTo = new DateTimePicker();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgRecap).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 26);
            label1.Name = "label1";
            label1.Size = new Size(348, 39);
            label1.TabIndex = 0;
            label1.Text = "Rekapitulasi Data Donasi";
            // 
            // dgRecap
            // 
            dgRecap.AllowUserToAddRows = false;
            dgRecap.AllowUserToDeleteRows = false;
            dgRecap.AllowUserToResizeColumns = false;
            dgRecap.AllowUserToResizeRows = false;
            dgRecap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgRecap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRecap.BackgroundColor = Color.White;
            dgRecap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgRecap.DefaultCellStyle = dataGridViewCellStyle3;
            dgRecap.Location = new Point(12, 127);
            dgRecap.Margin = new Padding(3, 2, 3, 2);
            dgRecap.Name = "dgRecap";
            dgRecap.ReadOnly = true;
            dgRecap.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgRecap.RowHeadersVisible = false;
            dgRecap.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dgRecap.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgRecap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgRecap.Size = new Size(776, 312);
            dgRecap.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dtFrom);
            panel1.Controls.Add(label2);
            panel1.ForeColor = SystemColors.WindowText;
            panel1.Location = new Point(12, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 42);
            panel1.TabIndex = 16;
            // 
            // dtFrom
            // 
            dtFrom.CustomFormat = "";
            dtFrom.Format = DateTimePickerFormat.Short;
            dtFrom.Location = new Point(116, 9);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(97, 23);
            dtFrom.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 12);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 17;
            label2.Text = "Dari tanggal :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dtTo);
            panel2.Controls.Add(label3);
            panel2.ForeColor = SystemColors.WindowText;
            panel2.Location = new Point(255, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 42);
            panel2.TabIndex = 19;
            // 
            // dtTo
            // 
            dtTo.CustomFormat = "";
            dtTo.Format = DateTimePickerFormat.Short;
            dtTo.Location = new Point(136, 9);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(97, 23);
            dtTo.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 12);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 17;
            label3.Text = "Sampai tanggal :";
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(522, 80);
            button1.Name = "button1";
            button1.Size = new Size(114, 42);
            button1.TabIndex = 20;
            button1.Text = "Tampilkan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Rekapitulasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 75, 243);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgRecap);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Rekapitulasi";
            Text = "Rekapitulasi";
            ((System.ComponentModel.ISupportInitialize)dgRecap).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgRecap;
        private Panel panel1;
        private DateTimePicker dtFrom;
        private Label label2;
        private Panel panel2;
        private DateTimePicker dtTo;
        private Label label3;
        private Button button1;
    }
}