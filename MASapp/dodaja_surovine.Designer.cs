namespace MASapp
{
    partial class dodaja_surovine
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
            this.dodaj_surovino = new System.Windows.Forms.Button();
            this.ime_surovine = new System.Windows.Forms.TextBox();
            this.ime_kategorije = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodaj_surovino
            // 
            this.dodaj_surovino.Location = new System.Drawing.Point(12, 78);
            this.dodaj_surovino.Name = "dodaj_surovino";
            this.dodaj_surovino.Size = new System.Drawing.Size(78, 30);
            this.dodaj_surovino.TabIndex = 0;
            this.dodaj_surovino.Text = "Dodaj";
            this.dodaj_surovino.UseVisualStyleBackColor = true;
            this.dodaj_surovino.Click += new System.EventHandler(this.dodaj_surovino_Click);
            // 
            // ime_surovine
            // 
            this.ime_surovine.Location = new System.Drawing.Point(102, 40);
            this.ime_surovine.Name = "ime_surovine";
            this.ime_surovine.Size = new System.Drawing.Size(103, 26);
            this.ime_surovine.TabIndex = 1;
            // 
            // ime_kategorije
            // 
            this.ime_kategorije.FormattingEnabled = true;
            this.ime_kategorije.Location = new System.Drawing.Point(102, 6);
            this.ime_kategorije.Name = "ime_kategorije";
            this.ime_kategorije.Size = new System.Drawing.Size(103, 28);
            this.ime_kategorije.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategorija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime:";
            // 
            // dodaja_surovine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 120);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ime_kategorije);
            this.Controls.Add(this.ime_surovine);
            this.Controls.Add(this.dodaj_surovino);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "dodaja_surovine";
            this.Text = "Surovine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodaj_surovino;
        private System.Windows.Forms.TextBox ime_surovine;
        private System.Windows.Forms.ComboBox ime_kategorije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}