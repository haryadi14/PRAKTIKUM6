namespace P6_3_1204026
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartb1 = new chartb.chartb();
            this.numeric1 = new numerictb.numeric();
            this.numeric2 = new numerictb.numeric();
            this.tgl = new System.Windows.Forms.MonthCalendar();
            this.rblk = new System.Windows.Forms.RadioButton();
            this.rbPr = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Alamat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.epBenar = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSalah = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epBenar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSalah)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM INPUT DATA MAHASISWA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "NPM :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tanggal Lahir :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Alamat :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "No.Telepon  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 640);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Program Studi :";
            // 
            // chartb1
            // 
            this.chartb1.Location = new System.Drawing.Point(181, 179);
            this.chartb1.Name = "chartb1";
            this.chartb1.Size = new System.Drawing.Size(100, 26);
            this.chartb1.TabIndex = 9;
            this.chartb1.Leave += new System.EventHandler(this.chartb1_Leave);
            // 
            // numeric1
            // 
            this.numeric1.Location = new System.Drawing.Point(181, 118);
            this.numeric1.MaxLength = 7;
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(100, 26);
            this.numeric1.TabIndex = 10;
            this.numeric1.Leave += new System.EventHandler(this.numeric1_Leave);
            // 
            // numeric2
            // 
            this.numeric2.Location = new System.Drawing.Point(186, 598);
            this.numeric2.Name = "numeric2";
            this.numeric2.Size = new System.Drawing.Size(100, 26);
            this.numeric2.TabIndex = 11;
            this.numeric2.Leave += new System.EventHandler(this.numeric2_Leave);
            // 
            // tgl
            // 
            this.tgl.Location = new System.Drawing.Point(181, 231);
            this.tgl.Name = "tgl";
            this.tgl.TabIndex = 12;
            this.tgl.TodayDate = new System.DateTime(2022, 5, 12, 0, 0, 0, 0);
            // 
            // rblk
            // 
            this.rblk.AutoSize = true;
            this.rblk.Location = new System.Drawing.Point(181, 511);
            this.rblk.Name = "rblk";
            this.rblk.Size = new System.Drawing.Size(105, 24);
            this.rblk.TabIndex = 13;
            this.rblk.TabStop = true;
            this.rblk.Text = "Laki - Laki";
            this.rblk.UseVisualStyleBackColor = true;
            // 
            // rbPr
            // 
            this.rbPr.AutoSize = true;
            this.rbPr.Location = new System.Drawing.Point(357, 511);
            this.rbPr.Name = "rbPr";
            this.rbPr.Size = new System.Drawing.Size(116, 24);
            this.rbPr.TabIndex = 14;
            this.rbPr.TabStop = true;
            this.rbPr.Text = "Perempuan";
            this.rbPr.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Jenis Kelamin :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 632);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 16;
            // 
            // Alamat
            // 
            this.Alamat.Location = new System.Drawing.Point(181, 549);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(188, 26);
            this.Alamat.TabIndex = 17;
            this.Alamat.Leave += new System.EventHandler(this.Alamat_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 707);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 707);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // epBenar
            // 
            this.epBenar.ContainerControl = this;
            this.epBenar.Icon = ((System.Drawing.Icon)(resources.GetObject("epBenar.Icon")));
            // 
            // epSalah
            // 
            this.epSalah.ContainerControl = this;
            this.epSalah.Icon = ((System.Drawing.Icon)(resources.GetObject("epSalah.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 855);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbPr);
            this.Controls.Add(this.rblk);
            this.Controls.Add(this.tgl);
            this.Controls.Add(this.numeric2);
            this.Controls.Add(this.numeric1);
            this.Controls.Add(this.chartb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epBenar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSalah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private chartb.chartb chartb1;
        private numerictb.numeric numeric1;
        private numerictb.numeric numeric2;
        private System.Windows.Forms.MonthCalendar tgl;
        private System.Windows.Forms.RadioButton rblk;
        private System.Windows.Forms.RadioButton rbPr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Alamat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider epBenar;
        private System.Windows.Forms.ErrorProvider epSalah;
    }
}

