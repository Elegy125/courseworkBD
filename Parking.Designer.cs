namespace ParkingLot
{
    partial class Parking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parking));
            this.ParkingDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowTagBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TagTb = new System.Windows.Forms.TextBox();
            this.Place = new System.Windows.Forms.ComboBox();
            this.Cars = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.BookBtn = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DurationTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ParkingDGV
            // 
            this.ParkingDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ParkingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParkingDGV.Location = new System.Drawing.Point(3, 294);
            this.ParkingDGV.Name = "ParkingDGV";
            this.ParkingDGV.RowHeadersWidth = 51;
            this.ParkingDGV.RowTemplate.Height = 24;
            this.ParkingDGV.Size = new System.Drawing.Size(1345, 427);
            this.ParkingDGV.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(458, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Система керування автостоянкою 1.0";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(36, 641);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 69);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1354, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 731);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.ShowTagBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TagTb);
            this.panel2.Controls.Add(this.Place);
            this.panel2.Controls.Add(this.Cars);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Controls.Add(this.BookBtn);
            this.panel2.Controls.Add(this.Date);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.AmountTb);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.DurationTb);
            this.panel2.Controls.Add(this.ParkingDGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(156, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1419, 731);
            this.panel2.TabIndex = 17;
            // 
            // ShowTagBtn
            // 
            this.ShowTagBtn.BackColor = System.Drawing.Color.IndianRed;
            this.ShowTagBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.ShowTagBtn.FlatAppearance.BorderSize = 0;
            this.ShowTagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowTagBtn.ForeColor = System.Drawing.Color.White;
            this.ShowTagBtn.Location = new System.Drawing.Point(753, 196);
            this.ShowTagBtn.Name = "ShowTagBtn";
            this.ShowTagBtn.Size = new System.Drawing.Size(229, 68);
            this.ShowTagBtn.TabIndex = 40;
            this.ShowTagBtn.Text = "Показати за номером працівника";
            this.ShowTagBtn.UseVisualStyleBackColor = false;
            this.ShowTagBtn.Click += new System.EventHandler(this.ShowTagBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(849, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 52);
            this.label4.TabIndex = 39;
            this.label4.Text = "Номер \r\nпрацівника";
            // 
            // TagTb
            // 
            this.TagTb.Location = new System.Drawing.Point(845, 128);
            this.TagTb.Name = "TagTb";
            this.TagTb.Size = new System.Drawing.Size(137, 34);
            this.TagTb.TabIndex = 38;
            // 
            // Place
            // 
            this.Place.FormattingEnabled = true;
            this.Place.Items.AddRange(new object[] {
            "Чоловіча",
            "Жіноча",
            "M"});
            this.Place.Location = new System.Drawing.Point(1038, 124);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(138, 34);
            this.Place.TabIndex = 37;
            this.Place.Text = "Місце";
            // 
            // Cars
            // 
            this.Cars.FormattingEnabled = true;
            this.Cars.Items.AddRange(new object[] {
            "Чоловіча",
            "Жіноча",
            "M"});
            this.Cars.Location = new System.Drawing.Point(1038, 70);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(138, 34);
            this.Cars.TabIndex = 36;
            this.Cars.Text = "Авто";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(436, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 26);
            this.label9.TabIndex = 32;
            this.label9.Text = "Забронювати місце на парковці";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.IndianRed;
            this.CancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(1221, 225);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(112, 39);
            this.CancelBtn.TabIndex = 32;
            this.CancelBtn.Text = "Оновити ";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // BookBtn
            // 
            this.BookBtn.BackColor = System.Drawing.Color.Teal;
            this.BookBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BookBtn.FlatAppearance.BorderSize = 0;
            this.BookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookBtn.ForeColor = System.Drawing.Color.White;
            this.BookBtn.Location = new System.Drawing.Point(1040, 225);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(136, 39);
            this.BookBtn.TabIndex = 33;
            this.BookBtn.Text = "Бронювати";
            this.BookBtn.UseVisualStyleBackColor = false;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // Date
            // 
            this.Date.CalendarForeColor = System.Drawing.Color.White;
            this.Date.CalendarMonthBackground = System.Drawing.Color.White;
            this.Date.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(29, 60);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 34);
            this.Date.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1205, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 26);
            this.label7.TabIndex = 34;
            this.label7.Text = "Сума(грн)";
            // 
            // AmountTb
            // 
            this.AmountTb.Location = new System.Drawing.Point(1210, 158);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(138, 34);
            this.AmountTb.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1205, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 52);
            this.label6.TabIndex = 30;
            this.label6.Text = "Тривалість\r\n(год)";
            // 
            // DurationTb
            // 
            this.DurationTb.Location = new System.Drawing.Point(1210, 73);
            this.DurationTb.Name = "DurationTb";
            this.DurationTb.Size = new System.Drawing.Size(138, 34);
            this.DurationTb.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 731);
            this.panel1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Місця";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Паркінг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Авто";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(36, 353);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 69);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(36, 225);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 69);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 69);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1575, 731);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Parking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking";
            ((System.ComponentModel.ISupportInitialize)(this.ParkingDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ParkingDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DurationTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button BookBtn;
        private System.Windows.Forms.ComboBox Place;
        private System.Windows.Forms.ComboBox Cars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TagTb;
        private System.Windows.Forms.Button ShowTagBtn;
    }
}