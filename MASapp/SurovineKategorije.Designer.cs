namespace MASapp
{
    partial class SurovineKategorije
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
            this.Surovine = new System.Windows.Forms.Button();
            this.Kategorije = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Surovine
            // 
            this.Surovine.Location = new System.Drawing.Point(13, 14);
            this.Surovine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Surovine.Name = "Surovine";
            this.Surovine.Size = new System.Drawing.Size(79, 35);
            this.Surovine.TabIndex = 0;
            this.Surovine.Text = "Surovine";
            this.Surovine.UseVisualStyleBackColor = true;
            this.Surovine.Click += new System.EventHandler(this.Surovine_Click);
            // 
            // Kategorije
            // 
            this.Kategorije.Location = new System.Drawing.Point(100, 14);
            this.Kategorije.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Kategorije.Name = "Kategorije";
            this.Kategorije.Size = new System.Drawing.Size(90, 35);
            this.Kategorije.TabIndex = 1;
            this.Kategorije.Text = "Kategorije";
            this.Kategorije.UseVisualStyleBackColor = true;
            this.Kategorije.Click += new System.EventHandler(this.Kategorije_Click);
            // 
            // SurovineKategorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 62);
            this.Controls.Add(this.Kategorije);
            this.Controls.Add(this.Surovine);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SurovineKategorije";
            this.Text = "SurovineKategorije";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Surovine;
        private System.Windows.Forms.Button Kategorije;
    }
}