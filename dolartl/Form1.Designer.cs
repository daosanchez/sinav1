namespace dolartl
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
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblTl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 ABD DOLARI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(55, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "MİKTAR";
            // 
            // txtDolar
            // 
            this.txtDolar.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDolar.Location = new System.Drawing.Point(144, 24);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 26);
            this.txtDolar.TabIndex = 2;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiktar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtMiktar.Location = new System.Drawing.Point(144, 77);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 26);
            this.txtMiktar.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(25, 137);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(197, 44);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblTl
            // 
            this.lblTl.AutoSize = true;
            this.lblTl.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTl.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTl.Location = new System.Drawing.Point(22, 212);
            this.lblTl.Name = "lblTl";
            this.lblTl.Size = new System.Drawing.Size(91, 18);
            this.lblTl.TabIndex = 5;
            this.lblTl.Text = "TL TUTARI:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.lblTl);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtDolar);
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
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblTl;
    }
}

