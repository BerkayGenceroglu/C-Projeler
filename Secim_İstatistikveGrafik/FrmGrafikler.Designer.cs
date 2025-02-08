namespace Secim_İstatistikveGrafik
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbleparti = new System.Windows.Forms.Label();
            this.lbldparti = new System.Windows.Forms.Label();
            this.lblcparti = new System.Windows.Forms.Label();
            this.lblbparti = new System.Windows.Forms.Label();
            this.lblaparti = new System.Windows.Forms.Label();
            this.progressBarE = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBarD = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progress1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbılce = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 22);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Partiler";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(905, 211);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbleparti);
            this.groupBox2.Controls.Add(this.lbldparti);
            this.groupBox2.Controls.Add(this.lblcparti);
            this.groupBox2.Controls.Add(this.lblbparti);
            this.groupBox2.Controls.Add(this.lblaparti);
            this.groupBox2.Controls.Add(this.progressBarE);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.progressBarD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.progressBarC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.progressBarB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progress1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbılce);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(911, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // lbleparti
            // 
            this.lbleparti.AutoSize = true;
            this.lbleparti.Location = new System.Drawing.Point(668, 204);
            this.lbleparti.Name = "lbleparti";
            this.lbleparti.Size = new System.Drawing.Size(19, 20);
            this.lbleparti.TabIndex = 16;
            this.lbleparti.Text = "0";
            // 
            // lbldparti
            // 
            this.lbldparti.AutoSize = true;
            this.lbldparti.Location = new System.Drawing.Point(668, 175);
            this.lbldparti.Name = "lbldparti";
            this.lbldparti.Size = new System.Drawing.Size(19, 20);
            this.lbldparti.TabIndex = 15;
            this.lbldparti.Text = "0";
            // 
            // lblcparti
            // 
            this.lblcparti.AutoSize = true;
            this.lblcparti.Location = new System.Drawing.Point(668, 146);
            this.lblcparti.Name = "lblcparti";
            this.lblcparti.Size = new System.Drawing.Size(19, 20);
            this.lblcparti.TabIndex = 14;
            this.lblcparti.Text = "0";
            // 
            // lblbparti
            // 
            this.lblbparti.AutoSize = true;
            this.lblbparti.Location = new System.Drawing.Point(668, 117);
            this.lblbparti.Name = "lblbparti";
            this.lblbparti.Size = new System.Drawing.Size(19, 20);
            this.lblbparti.TabIndex = 13;
            this.lblbparti.Text = "0";
            // 
            // lblaparti
            // 
            this.lblaparti.AutoSize = true;
            this.lblaparti.Location = new System.Drawing.Point(668, 85);
            this.lblaparti.Name = "lblaparti";
            this.lblaparti.Size = new System.Drawing.Size(19, 20);
            this.lblaparti.TabIndex = 12;
            this.lblaparti.Text = "0";
            // 
            // progressBarE
            // 
            this.progressBarE.Location = new System.Drawing.Point(300, 201);
            this.progressBarE.Name = "progressBarE";
            this.progressBarE.Size = new System.Drawing.Size(362, 23);
            this.progressBarE.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "E PARTİ :";
            // 
            // progressBarD
            // 
            this.progressBarD.Location = new System.Drawing.Point(300, 172);
            this.progressBarD.Name = "progressBarD";
            this.progressBarD.Size = new System.Drawing.Size(362, 23);
            this.progressBarD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "D PARTİ :";
            // 
            // progressBarC
            // 
            this.progressBarC.Location = new System.Drawing.Point(301, 143);
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(362, 23);
            this.progressBarC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "C PARTİ :";
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(300, 114);
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(362, 23);
            this.progressBarB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "B PARTİ :";
            // 
            // progress1
            // 
            this.progress1.Location = new System.Drawing.Point(300, 85);
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(362, 23);
            this.progress1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ :";
            // 
            // cmbılce
            // 
            this.cmbılce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbılce.FormattingEnabled = true;
            this.cmbılce.Location = new System.Drawing.Point(300, 37);
            this.cmbılce.Name = "cmbılce";
            this.cmbılce.Size = new System.Drawing.Size(171, 28);
            this.cmbılce.TabIndex = 1;
            this.cmbılce.SelectedIndexChanged += new System.EventHandler(this.cmbılce_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin :";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGrafikler";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cmbılce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBarD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progress1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbleparti;
        private System.Windows.Forms.Label lbldparti;
        private System.Windows.Forms.Label lblcparti;
        private System.Windows.Forms.Label lblbparti;
        private System.Windows.Forms.Label lblaparti;
    }
}