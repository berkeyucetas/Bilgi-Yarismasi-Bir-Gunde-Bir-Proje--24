namespace Bilgi_Yarışması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            this.lblDogru = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblZaman = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoru
            // 
            this.txtSoru.BackColor = System.Drawing.Color.DarkGray;
            this.txtSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoru.ForeColor = System.Drawing.Color.White;
            this.txtSoru.Location = new System.Drawing.Point(210, 7);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(618, 259);
            this.txtSoru.TabIndex = 0;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.DarkGray;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.Location = new System.Drawing.Point(210, 337);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(618, 63);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.DarkGray;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.ForeColor = System.Drawing.Color.White;
            this.btnB.Location = new System.Drawing.Point(210, 406);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(618, 63);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.DarkGray;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.Location = new System.Drawing.Point(210, 475);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(618, 63);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.DarkGray;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnD.ForeColor = System.Drawing.Color.White;
            this.btnD.Location = new System.Drawing.Point(210, 544);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(618, 63);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.BackColor = System.Drawing.Color.DarkGray;
            this.btnIleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIleri.ForeColor = System.Drawing.Color.White;
            this.btnIleri.Location = new System.Drawing.Point(834, 7);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(235, 63);
            this.btnIleri.TabIndex = 6;
            this.btnIleri.Text = "Başla";
            this.btnIleri.UseVisualStyleBackColor = false;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(937, 274);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(42, 16);
            this.lblDogru.TabIndex = 7;
            this.lblDogru.Text = "dogru";
            this.lblDogru.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(898, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Puan=";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.BackColor = System.Drawing.Color.DarkGray;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.Color.White;
            this.lblPuan.Location = new System.Drawing.Point(985, 73);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(25, 26);
            this.lblPuan.TabIndex = 9;
            this.lblPuan.Text = "0";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.BackColor = System.Drawing.Color.DarkGray;
            this.lblSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.ForeColor = System.Drawing.Color.White;
            this.lblSoru.Location = new System.Drawing.Point(116, 9);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(25, 26);
            this.lblSoru.TabIndex = 11;
            this.lblSoru.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Soru:";
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.BackColor = System.Drawing.Color.DarkGray;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.ForeColor = System.Drawing.Color.White;
            this.lblZaman.Location = new System.Drawing.Point(116, 44);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(25, 26);
            this.lblZaman.TabIndex = 13;
            this.lblZaman.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Zaman:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1077, 613);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.txtSoru);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Bilgi Yarışması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Label label3;
    }
}

