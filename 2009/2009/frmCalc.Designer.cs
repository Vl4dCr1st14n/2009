namespace _2009
{
    partial class frmCalc
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
            this.btnAD = new System.Windows.Forms.Button();
            this.btnTAKE = new System.Windows.Forms.Button();
            this.btnDIV = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSQR = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAD
            // 
            this.btnAD.Location = new System.Drawing.Point(377, 117);
            this.btnAD.Name = "btnAD";
            this.btnAD.Size = new System.Drawing.Size(29, 23);
            this.btnAD.TabIndex = 0;
            this.btnAD.Text = "+";
            this.btnAD.UseVisualStyleBackColor = true;
            // 
            // btnTAKE
            // 
            this.btnTAKE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTAKE.Location = new System.Drawing.Point(436, 117);
            this.btnTAKE.Name = "btnTAKE";
            this.btnTAKE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTAKE.Size = new System.Drawing.Size(31, 23);
            this.btnTAKE.TabIndex = 1;
            this.btnTAKE.Text = "-";
            this.btnTAKE.UseVisualStyleBackColor = true;
            // 
            // btnDIV
            // 
            this.btnDIV.Location = new System.Drawing.Point(377, 168);
            this.btnDIV.Name = "btnDIV";
            this.btnDIV.Size = new System.Drawing.Size(29, 23);
            this.btnDIV.TabIndex = 3;
            this.btnDIV.Text = "/";
            this.btnDIV.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(436, 168);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(31, 23);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnSQR
            // 
            this.btnSQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSQR.Location = new System.Drawing.Point(357, 223);
            this.btnSQR.Name = "btnSQR";
            this.btnSQR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSQR.Size = new System.Drawing.Size(52, 23);
            this.btnSQR.TabIndex = 4;
            this.btnSQR.Text = "Radical";
            this.btnSQR.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(436, 223);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "^2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSterge
            // 
            this.btnSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSterge.Location = new System.Drawing.Point(395, 266);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSterge.Size = new System.Drawing.Size(52, 23);
            this.btnSterge.TabIndex = 6;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOut.Location = new System.Drawing.Point(477, 266);
            this.btnOut.Name = "btnOut";
            this.btnOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOut.Size = new System.Drawing.Size(52, 23);
            this.btnOut.TabIndex = 7;
            this.btnOut.Text = "Iesire";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 418);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSQR);
            this.Controls.Add(this.btnDIV);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnTAKE);
            this.Controls.Add(this.btnAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalc";
            this.Text = "frmCalc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAD;
        private System.Windows.Forms.Button btnTAKE;
        private System.Windows.Forms.Button btnDIV;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSQR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnOut;
    }
}