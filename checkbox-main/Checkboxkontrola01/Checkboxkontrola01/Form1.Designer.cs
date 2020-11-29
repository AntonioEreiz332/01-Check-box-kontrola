namespace Checkboxkontrola01
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
            this.boxDorucak = new System.Windows.Forms.CheckBox();
            this.boxRucak = new System.Windows.Forms.CheckBox();
            this.boxVecera = new System.Windows.Forms.CheckBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.boxSakrij = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // boxDorucak
            // 
            this.boxDorucak.AutoSize = true;
            this.boxDorucak.Location = new System.Drawing.Point(35, 31);
            this.boxDorucak.Name = "boxDorucak";
            this.boxDorucak.Size = new System.Drawing.Size(67, 17);
            this.boxDorucak.TabIndex = 0;
            this.boxDorucak.Text = "Dorucak";
            this.boxDorucak.UseVisualStyleBackColor = true;
            // 
            // boxRucak
            // 
            this.boxRucak.AutoSize = true;
            this.boxRucak.Location = new System.Drawing.Point(35, 54);
            this.boxRucak.Name = "boxRucak";
            this.boxRucak.Size = new System.Drawing.Size(58, 17);
            this.boxRucak.TabIndex = 1;
            this.boxRucak.Text = "Rucak";
            this.boxRucak.UseVisualStyleBackColor = true;
            // 
            // boxVecera
            // 
            this.boxVecera.AutoSize = true;
            this.boxVecera.Location = new System.Drawing.Point(35, 77);
            this.boxVecera.Name = "boxVecera";
            this.boxVecera.Size = new System.Drawing.Size(60, 17);
            this.boxVecera.TabIndex = 2;
            this.boxVecera.Text = "Vecera";
            this.boxVecera.UseVisualStyleBackColor = true;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(149, 31);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(116, 63);
            this.txtIspis.TabIndex = 3;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(35, 115);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(75, 23);
            this.btnPosalji.TabIndex = 4;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // boxSakrij
            // 
            this.boxSakrij.AutoSize = true;
            this.boxSakrij.Location = new System.Drawing.Point(149, 119);
            this.boxSakrij.Name = "boxSakrij";
            this.boxSakrij.Size = new System.Drawing.Size(101, 17);
            this.boxSakrij.TabIndex = 5;
            this.boxSakrij.Text = "Sakrij Narudžbu";
            this.boxSakrij.UseVisualStyleBackColor = true;
            this.boxSakrij.CheckedChanged += new System.EventHandler(this.boxSakrij_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxSakrij);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.boxVecera);
            this.Controls.Add(this.boxRucak);
            this.Controls.Add(this.boxDorucak);
            this.Name = "Form1";
            this.Text = "Upotreba CheckBox kontorle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox boxDorucak;
        private System.Windows.Forms.CheckBox boxRucak;
        private System.Windows.Forms.CheckBox boxVecera;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.CheckBox boxSakrij;
    }
}

