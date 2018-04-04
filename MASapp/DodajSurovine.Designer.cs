namespace MASapp
{
    partial class DodajSurovine
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
            this.dodajBds = new System.Windows.Forms.Button();
            this.surovineCBds = new System.Windows.Forms.ComboBox();
            this.steviloTBds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodajBds
            // 
            this.dodajBds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajBds.Location = new System.Drawing.Point(285, 11);
            this.dodajBds.Name = "dodajBds";
            this.dodajBds.Size = new System.Drawing.Size(99, 28);
            this.dodajBds.TabIndex = 2;
            this.dodajBds.Text = "Dodaj";
            this.dodajBds.UseVisualStyleBackColor = true;
            this.dodajBds.Click += new System.EventHandler(this.dodajBds_Click);
            // 
            // surovineCBds
            // 
            this.surovineCBds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surovineCBds.FormattingEnabled = true;
            this.surovineCBds.Location = new System.Drawing.Point(12, 12);
            this.surovineCBds.Name = "surovineCBds";
            this.surovineCBds.Size = new System.Drawing.Size(121, 28);
            this.surovineCBds.TabIndex = 3;
            // 
            // steviloTBds
            // 
            this.steviloTBds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.steviloTBds.Location = new System.Drawing.Point(212, 12);
            this.steviloTBds.Name = "steviloTBds";
            this.steviloTBds.Size = new System.Drawing.Size(67, 26);
            this.steviloTBds.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Količina:";
            // 
            // DodajSurovine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 58);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.steviloTBds);
            this.Controls.Add(this.surovineCBds);
            this.Controls.Add(this.dodajBds);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajSurovine";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "DodajSurovine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dodajBds;
        private System.Windows.Forms.ComboBox surovineCBds;
        private System.Windows.Forms.TextBox steviloTBds;
        private System.Windows.Forms.Label label1;
    }
}