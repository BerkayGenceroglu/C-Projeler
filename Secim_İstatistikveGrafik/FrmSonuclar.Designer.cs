namespace Secim_İstatistikveGrafik
{
    partial class FrmSonuclar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtilce = new System.Windows.Forms.TextBox();
            this.txtaparti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbparti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcparti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdparti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txteparti = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnoygiris = new System.Windows.Forms.Button();
            this.btngrafik = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(167, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE AD:";
            // 
            // txtilce
            // 
            this.txtilce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtilce.Location = new System.Drawing.Point(281, 63);
            this.txtilce.Name = "txtilce";
            this.txtilce.Size = new System.Drawing.Size(281, 31);
            this.txtilce.TabIndex = 1;
            this.txtilce.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtaparti
            // 
            this.txtaparti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaparti.Location = new System.Drawing.Point(281, 146);
            this.txtaparti.Name = "txtaparti";
            this.txtaparti.Size = new System.Drawing.Size(281, 31);
            this.txtaparti.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(168, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ:";
            // 
            // txtbparti
            // 
            this.txtbparti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbparti.Location = new System.Drawing.Point(281, 197);
            this.txtbparti.Name = "txtbparti";
            this.txtbparti.Size = new System.Drawing.Size(281, 31);
            this.txtbparti.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(168, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "B PARTİ:";
            // 
            // txtcparti
            // 
            this.txtcparti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcparti.Location = new System.Drawing.Point(281, 246);
            this.txtcparti.Name = "txtcparti";
            this.txtcparti.Size = new System.Drawing.Size(281, 31);
            this.txtcparti.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(167, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "C PARTİ:";
            // 
            // txtdparti
            // 
            this.txtdparti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdparti.Location = new System.Drawing.Point(281, 299);
            this.txtdparti.Name = "txtdparti";
            this.txtdparti.Size = new System.Drawing.Size(281, 31);
            this.txtdparti.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(167, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "D PARTİ:";
            // 
            // txteparti
            // 
            this.txteparti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteparti.Location = new System.Drawing.Point(281, 349);
            this.txteparti.Name = "txteparti";
            this.txteparti.Size = new System.Drawing.Size(281, 31);
            this.txteparti.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(168, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "E PARTİ:";
            // 
            // btnoygiris
            // 
            this.btnoygiris.ForeColor = System.Drawing.Color.Red;
            this.btnoygiris.Location = new System.Drawing.Point(281, 386);
            this.btnoygiris.Name = "btnoygiris";
            this.btnoygiris.Size = new System.Drawing.Size(281, 33);
            this.btnoygiris.TabIndex = 12;
            this.btnoygiris.Text = "Oy Girişi Yap";
            this.btnoygiris.UseVisualStyleBackColor = true;
            this.btnoygiris.Click += new System.EventHandler(this.btnoygiris_Click);
            // 
            // btngrafik
            // 
            this.btngrafik.ForeColor = System.Drawing.Color.Red;
            this.btngrafik.Location = new System.Drawing.Point(281, 425);
            this.btngrafik.Name = "btngrafik";
            this.btngrafik.Size = new System.Drawing.Size(133, 36);
            this.btngrafik.TabIndex = 13;
            this.btngrafik.Text = "Grafikler";
            this.btngrafik.UseVisualStyleBackColor = true;
            this.btngrafik.Click += new System.EventHandler(this.btngrafik_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.ForeColor = System.Drawing.Color.Red;
            this.btncıkıs.Location = new System.Drawing.Point(431, 425);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(131, 36);
            this.btncıkıs.TabIndex = 14;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = true;
            // 
            // FrmSonuclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(747, 536);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.btngrafik);
            this.Controls.Add(this.btnoygiris);
            this.Controls.Add(this.txteparti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdparti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcparti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbparti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtaparti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtilce);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSonuclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTGS";
            this.Load += new System.EventHandler(this.FrmSonuclar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtilce;
        private System.Windows.Forms.TextBox txtaparti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbparti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcparti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdparti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txteparti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnoygiris;
        private System.Windows.Forms.Button btngrafik;
        private System.Windows.Forms.Button btncıkıs;
    }
}

