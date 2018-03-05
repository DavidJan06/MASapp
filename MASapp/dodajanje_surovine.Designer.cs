namespace MASapp
{
    partial class dodajanje_surovine
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
            this.ime_surovine = new System.Windows.Forms.TextBox();
            this.kolicina_surovine = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Količina";
            // 
            // ime_surovine
            // 
            this.ime_surovine.Location = new System.Drawing.Point(183, 18);
            this.ime_surovine.Name = "ime_surovine";
            this.ime_surovine.Size = new System.Drawing.Size(266, 31);
            this.ime_surovine.TabIndex = 2;
            // 
            // kolicina_surovine
            // 
            this.kolicina_surovine.Location = new System.Drawing.Point(183, 75);
            this.kolicina_surovine.Name = "kolicina_surovine";
            this.kolicina_surovine.Size = new System.Drawing.Size(266, 31);
            this.kolicina_surovine.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dodajanje_surovine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kolicina_surovine);
            this.Controls.Add(this.ime_surovine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dodajanje_surovine";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "dodajanje_surovine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ime_surovine;
        private System.Windows.Forms.TextBox kolicina_surovine;
        private System.Windows.Forms.Button button1;
    }
}