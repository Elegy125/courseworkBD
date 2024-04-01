namespace ParkingLot
{
    partial class Places
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Places));
            this.EditPlace = new System.Windows.Forms.Button();
            this.AddPlace = new System.Windows.Forms.Button();
            this.DeletePlace = new System.Windows.Forms.Button();
            this.PlaceDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusTb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PositionTb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditPlace
            // 
            this.EditPlace.BackColor = System.Drawing.Color.Teal;
            this.EditPlace.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.EditPlace.FlatAppearance.BorderSize = 0;
            this.EditPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditPlace.ForeColor = System.Drawing.Color.White;
            this.EditPlace.Location = new System.Drawing.Point(784, 249);
            this.EditPlace.Name = "EditPlace";
            this.EditPlace.Size = new System.Drawing.Size(158, 39);
            this.EditPlace.TabIndex = 31;
            this.EditPlace.Text = "Редагувати";
            this.EditPlace.UseVisualStyleBackColor = false;
            this.EditPlace.Click += new System.EventHandler(this.EditPlace_Click);
            // 
            // AddPlace
            // 
            this.AddPlace.BackColor = System.Drawing.Color.Teal;
            this.AddPlace.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.AddPlace.FlatAppearance.BorderSize = 0;
            this.AddPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPlace.ForeColor = System.Drawing.Color.White;
            this.AddPlace.Location = new System.Drawing.Point(550, 249);
            this.AddPlace.Name = "AddPlace";
            this.AddPlace.Size = new System.Drawing.Size(158, 39);
            this.AddPlace.TabIndex = 30;
            this.AddPlace.Text = "Додати";
            this.AddPlace.UseVisualStyleBackColor = false;
            this.AddPlace.Click += new System.EventHandler(this.AddPlace_Click);
            // 
            // DeletePlace
            // 
            this.DeletePlace.BackColor = System.Drawing.Color.Teal;
            this.DeletePlace.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.DeletePlace.FlatAppearance.BorderSize = 0;
            this.DeletePlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePlace.ForeColor = System.Drawing.Color.White;
            this.DeletePlace.Location = new System.Drawing.Point(339, 249);
            this.DeletePlace.Name = "DeletePlace";
            this.DeletePlace.Size = new System.Drawing.Size(158, 39);
            this.DeletePlace.TabIndex = 29;
            this.DeletePlace.Text = "Видалити";
            this.DeletePlace.UseVisualStyleBackColor = false;
            this.DeletePlace.Click += new System.EventHandler(this.DeletePlace_Click);
            // 
            // PlaceDGV
            // 
            this.PlaceDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PlaceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlaceDGV.Location = new System.Drawing.Point(261, 329);
            this.PlaceDGV.Name = "PlaceDGV";
            this.PlaceDGV.RowHeadersWidth = 51;
            this.PlaceDGV.RowTemplate.Height = 24;
            this.PlaceDGV.Size = new System.Drawing.Size(753, 346);
            this.PlaceDGV.TabIndex = 28;
            this.PlaceDGV.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.PlaceDGV_RowStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Позиція";
            // 
            // StatusTb
            // 
            this.StatusTb.FormattingEnabled = true;
            this.StatusTb.Items.AddRange(new object[] {
            "Заброньовано",
            "Вільно",
            "Технічне обслуговування"});
            this.StatusTb.Location = new System.Drawing.Point(654, 89);
            this.StatusTb.Name = "StatusTb";
            this.StatusTb.Size = new System.Drawing.Size(121, 34);
            this.StatusTb.TabIndex = 23;
            this.StatusTb.Text = "Статус";
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
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(36, 389);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 69);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(36, 261);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 69);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 69);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 731);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PositionTb
            // 
            this.PositionTb.Location = new System.Drawing.Point(339, 89);
            this.PositionTb.Name = "PositionTb";
            this.PositionTb.Size = new System.Drawing.Size(207, 34);
            this.PositionTb.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1100, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 731);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 731);
            this.panel1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Місця";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Паркінг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Авто";
            // 
            // Places
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 731);
            this.Controls.Add(this.EditPlace);
            this.Controls.Add(this.AddPlace);
            this.Controls.Add(this.DeletePlace);
            this.Controls.Add(this.PlaceDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PositionTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Places";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Places";
            ((System.ComponentModel.ISupportInitialize)(this.PlaceDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditPlace;
        private System.Windows.Forms.Button AddPlace;
        private System.Windows.Forms.Button DeletePlace;
        private System.Windows.Forms.DataGridView PlaceDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StatusTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PositionTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}