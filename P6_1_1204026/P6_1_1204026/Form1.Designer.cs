namespace P6_1_1204026
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sekProdi = new System.Windows.Forms.TextBox();
            this.kaProdi = new System.Windows.Forms.TextBox();
            this.Singkatan = new System.Windows.Forms.TextBox();
            this.namaProdi = new System.Windows.Forms.TextBox();
            this.idProdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM INPUT LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID PRODI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAMA PRODI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SINGKATAN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "KETUA PRODI :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "SEKRETARIS PRODI :";
            // 
            // sekProdi
            // 
            this.sekProdi.Location = new System.Drawing.Point(276, 316);
            this.sekProdi.Name = "sekProdi";
            this.sekProdi.Size = new System.Drawing.Size(100, 26);
            this.sekProdi.TabIndex = 6;
            // 
            // kaProdi
            // 
            this.kaProdi.Location = new System.Drawing.Point(276, 272);
            this.kaProdi.Name = "kaProdi";
            this.kaProdi.Size = new System.Drawing.Size(100, 26);
            this.kaProdi.TabIndex = 7;
            // 
            // Singkatan
            // 
            this.Singkatan.Location = new System.Drawing.Point(276, 226);
            this.Singkatan.Name = "Singkatan";
            this.Singkatan.Size = new System.Drawing.Size(100, 26);
            this.Singkatan.TabIndex = 8;
            // 
            // namaProdi
            // 
            this.namaProdi.Location = new System.Drawing.Point(276, 177);
            this.namaProdi.Name = "namaProdi";
            this.namaProdi.Size = new System.Drawing.Size(100, 26);
            this.namaProdi.TabIndex = 9;
            // 
            // idProdi
            // 
            this.idProdi.Location = new System.Drawing.Point(276, 127);
            this.idProdi.Name = "idProdi";
            this.idProdi.Size = new System.Drawing.Size(100, 26);
            this.idProdi.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "SAVE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 536);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idProdi);
            this.Controls.Add(this.namaProdi);
            this.Controls.Add(this.Singkatan);
            this.Controls.Add(this.kaProdi);
            this.Controls.Add(this.sekProdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sekProdi;
        private System.Windows.Forms.TextBox kaProdi;
        private System.Windows.Forms.TextBox Singkatan;
        private System.Windows.Forms.TextBox namaProdi;
        private System.Windows.Forms.TextBox idProdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

