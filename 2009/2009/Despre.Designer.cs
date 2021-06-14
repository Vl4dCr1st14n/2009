namespace _2009
{
    partial class Despre
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
            this.lblNumeE = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.lblScoala = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblClasa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumeE
            // 
            this.lblNumeE.AutoSize = true;
            this.lblNumeE.Location = new System.Drawing.Point(82, 24);
            this.lblNumeE.Name = "lblNumeE";
            this.lblNumeE.Size = new System.Drawing.Size(28, 13);
            this.lblNumeE.TabIndex = 0;
            this.lblNumeE.Text = "Elev";
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(84, 85);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(26, 13);
            this.lblProf.TabIndex = 1;
            this.lblProf.Text = "Prof";
            // 
            // lblScoala
            // 
            this.lblScoala.AutoSize = true;
            this.lblScoala.Location = new System.Drawing.Point(84, 151);
            this.lblScoala.Name = "lblScoala";
            this.lblScoala.Size = new System.Drawing.Size(40, 13);
            this.lblScoala.TabIndex = 2;
            this.lblScoala.Text = "Scoala";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(82, 246);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(41, 13);
            this.lblLocal.TabIndex = 3;
            this.lblLocal.Text = "loc_jud";
            // 
            // lblClasa
            // 
            this.lblClasa.AutoSize = true;
            this.lblClasa.Location = new System.Drawing.Point(82, 201);
            this.lblClasa.Name = "lblClasa";
            this.lblClasa.Size = new System.Drawing.Size(32, 13);
            this.lblClasa.TabIndex = 4;
            this.lblClasa.Text = "clasa";
            // 
            // Despre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 298);
            this.Controls.Add(this.lblClasa);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblScoala);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.lblNumeE);
            this.Name = "Despre";
            this.Text = "Despre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeE;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Label lblScoala;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblClasa;
    }
}