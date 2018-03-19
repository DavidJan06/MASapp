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
            this.shraniBds = new System.Windows.Forms.Button();
            this.zalogaDGVp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.zalogaDGVp)).BeginInit();
            this.SuspendLayout();
            // 
            // shraniBds
            // 
            this.shraniBds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shraniBds.Location = new System.Drawing.Point(12, 12);
            this.shraniBds.Name = "shraniBds";
            this.shraniBds.Size = new System.Drawing.Size(136, 28);
            this.shraniBds.TabIndex = 2;
            this.shraniBds.Text = "Shrani";
            this.shraniBds.UseVisualStyleBackColor = true;
            // 
            // zalogaDGVp
            // 
            this.zalogaDGVp.AllowUserToAddRows = false;
            this.zalogaDGVp.AllowUserToDeleteRows = false;
            this.zalogaDGVp.AllowUserToResizeColumns = false;
            this.zalogaDGVp.AllowUserToResizeRows = false;
            this.zalogaDGVp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zalogaDGVp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zalogaDGVp.Location = new System.Drawing.Point(12, 46);
            this.zalogaDGVp.MultiSelect = false;
            this.zalogaDGVp.Name = "zalogaDGVp";
            this.zalogaDGVp.RowHeadersVisible = false;
            this.zalogaDGVp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zalogaDGVp.Size = new System.Drawing.Size(404, 283);
            this.zalogaDGVp.TabIndex = 3;
            // 
            // DodajSurovine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 345);
            this.Controls.Add(this.zalogaDGVp);
            this.Controls.Add(this.shraniBds);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajSurovine";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "DodajSurovine";
            ((System.ComponentModel.ISupportInitialize)(this.zalogaDGVp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button shraniBds;
        private System.Windows.Forms.DataGridView zalogaDGVp;
    }
}