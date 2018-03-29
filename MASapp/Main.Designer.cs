namespace MASapp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pregled = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datumCBp = new System.Windows.Forms.ComboBox();
            this.izvoziBp = new System.Windows.Forms.Button();
            this.porabaDGVp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dodajZalogoBp = new System.Windows.Forms.Button();
            this.zalogaDGVp = new System.Windows.Forms.DataGridView();
            this.Vnos = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.izbrišiPogledBv = new System.Windows.Forms.Button();
            this.pregledDGVv = new System.Windows.Forms.DataGridView();
            this.datumLv = new System.Windows.Forms.Label();
            this.shraniPogledBv = new System.Windows.Forms.Button();
            this.porabaDGVv = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.izdelkiDGVv = new System.Windows.Forms.DataGridView();
            this.kategorijeCBv = new System.Windows.Forms.ComboBox();
            this.Izdelki = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dodajIzdelkiBi = new System.Windows.Forms.Button();
            this.izdelkiDGVi = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dodajKategorijeBi = new System.Windows.Forms.Button();
            this.kategorijeDGVi = new System.Windows.Forms.DataGridView();
            this.dodajSurovineBv = new System.Windows.Forms.Button();
            this.kolicinaBv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.NUDv = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dodajIzdelekBv = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imeIzdelkaLv = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.surovineDGVv = new System.Windows.Forms.DataGridView();
            this.sestavineIzdelkaDGVv = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Pregled.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.porabaDGVp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zalogaDGVp)).BeginInit();
            this.Vnos.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledDGVv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porabaDGVv)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izdelkiDGVv)).BeginInit();
            this.Izdelki.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izdelkiDGVi)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeDGVi)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surovineDGVv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sestavineIzdelkaDGVv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Pregled);
            this.tabControl1.Controls.Add(this.Vnos);
            this.tabControl1.Controls.Add(this.Izdelki);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // Pregled
            // 
            this.Pregled.Controls.Add(this.groupBox2);
            this.Pregled.Controls.Add(this.groupBox1);
            this.Pregled.Location = new System.Drawing.Point(4, 29);
            this.Pregled.Name = "Pregled";
            this.Pregled.Padding = new System.Windows.Forms.Padding(3);
            this.Pregled.Size = new System.Drawing.Size(851, 521);
            this.Pregled.TabIndex = 0;
            this.Pregled.Text = "Pregled";
            this.Pregled.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datumCBp);
            this.groupBox2.Controls.Add(this.izvoziBp);
            this.groupBox2.Controls.Add(this.porabaDGVp);
            this.groupBox2.Location = new System.Drawing.Point(428, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 510);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Poraba";
            // 
            // datumCBp
            // 
            this.datumCBp.FormattingEnabled = true;
            this.datumCBp.Location = new System.Drawing.Point(289, 24);
            this.datumCBp.Name = "datumCBp";
            this.datumCBp.Size = new System.Drawing.Size(121, 28);
            this.datumCBp.TabIndex = 2;
            // 
            // izvoziBp
            // 
            this.izvoziBp.Location = new System.Drawing.Point(185, 25);
            this.izvoziBp.Name = "izvoziBp";
            this.izvoziBp.Size = new System.Drawing.Size(98, 27);
            this.izvoziBp.TabIndex = 1;
            this.izvoziBp.Text = "Izvozi";
            this.izvoziBp.UseVisualStyleBackColor = true;
            // 
            // porabaDGVp
            // 
            this.porabaDGVp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.porabaDGVp.Location = new System.Drawing.Point(6, 58);
            this.porabaDGVp.Name = "porabaDGVp";
            this.porabaDGVp.Size = new System.Drawing.Size(404, 446);
            this.porabaDGVp.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dodajZalogoBp);
            this.groupBox1.Controls.Add(this.zalogaDGVp);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaloga";
            // 
            // dodajZalogoBp
            // 
            this.dodajZalogoBp.Location = new System.Drawing.Point(274, 24);
            this.dodajZalogoBp.Name = "dodajZalogoBp";
            this.dodajZalogoBp.Size = new System.Drawing.Size(136, 28);
            this.dodajZalogoBp.TabIndex = 1;
            this.dodajZalogoBp.Text = "Dodaj zalogi";
            this.dodajZalogoBp.UseVisualStyleBackColor = true;
            this.dodajZalogoBp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // zalogaDGVp
            // 
            this.zalogaDGVp.AllowUserToAddRows = false;
            this.zalogaDGVp.AllowUserToDeleteRows = false;
            this.zalogaDGVp.AllowUserToResizeColumns = false;
            this.zalogaDGVp.AllowUserToResizeRows = false;
            this.zalogaDGVp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zalogaDGVp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zalogaDGVp.Location = new System.Drawing.Point(6, 58);
            this.zalogaDGVp.MultiSelect = false;
            this.zalogaDGVp.Name = "zalogaDGVp";
            this.zalogaDGVp.ReadOnly = true;
            this.zalogaDGVp.RowHeadersVisible = false;
            this.zalogaDGVp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zalogaDGVp.Size = new System.Drawing.Size(404, 446);
            this.zalogaDGVp.TabIndex = 0;
            // 
            // Vnos
            // 
            this.Vnos.Controls.Add(this.groupBox9);
            this.Vnos.Controls.Add(this.groupBox6);
            this.Vnos.Controls.Add(this.groupBox5);
            this.Vnos.Controls.Add(this.groupBox4);
            this.Vnos.Controls.Add(this.groupBox3);
            this.Vnos.Location = new System.Drawing.Point(4, 29);
            this.Vnos.Name = "Vnos";
            this.Vnos.Padding = new System.Windows.Forms.Padding(3);
            this.Vnos.Size = new System.Drawing.Size(851, 521);
            this.Vnos.TabIndex = 1;
            this.Vnos.Text = "Vnos";
            this.Vnos.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.surovineDGVv);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.kolicinaBv);
            this.groupBox6.Controls.Add(this.dodajSurovineBv);
            this.groupBox6.Location = new System.Drawing.Point(8, 263);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(281, 250);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Surovine";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.izbrišiPogledBv);
            this.groupBox5.Controls.Add(this.pregledDGVv);
            this.groupBox5.Controls.Add(this.datumLv);
            this.groupBox5.Controls.Add(this.shraniPogledBv);
            this.groupBox5.Controls.Add(this.porabaDGVv);
            this.groupBox5.Location = new System.Drawing.Point(564, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(283, 507);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pogled";
            // 
            // izbrišiPogledBv
            // 
            this.izbrišiPogledBv.Location = new System.Drawing.Point(102, 23);
            this.izbrišiPogledBv.Name = "izbrišiPogledBv";
            this.izbrišiPogledBv.Size = new System.Drawing.Size(84, 28);
            this.izbrišiPogledBv.TabIndex = 6;
            this.izbrišiPogledBv.Text = "Izbriši";
            this.izbrišiPogledBv.UseVisualStyleBackColor = true;
            // 
            // pregledDGVv
            // 
            this.pregledDGVv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledDGVv.Location = new System.Drawing.Point(6, 57);
            this.pregledDGVv.Name = "pregledDGVv";
            this.pregledDGVv.Size = new System.Drawing.Size(270, 205);
            this.pregledDGVv.TabIndex = 5;
            // 
            // datumLv
            // 
            this.datumLv.AutoSize = true;
            this.datumLv.Location = new System.Drawing.Point(6, 27);
            this.datumLv.Name = "datumLv";
            this.datumLv.Size = new System.Drawing.Size(65, 20);
            this.datumLv.TabIndex = 4;
            this.datumLv.Text = "Datum: ";
            // 
            // shraniPogledBv
            // 
            this.shraniPogledBv.Location = new System.Drawing.Point(192, 23);
            this.shraniPogledBv.Name = "shraniPogledBv";
            this.shraniPogledBv.Size = new System.Drawing.Size(84, 28);
            this.shraniPogledBv.TabIndex = 3;
            this.shraniPogledBv.Text = "Shrani";
            this.shraniPogledBv.UseVisualStyleBackColor = true;
            // 
            // porabaDGVv
            // 
            this.porabaDGVv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.porabaDGVv.Location = new System.Drawing.Point(6, 268);
            this.porabaDGVv.Name = "porabaDGVv";
            this.porabaDGVv.Size = new System.Drawing.Size(270, 233);
            this.porabaDGVv.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sestavineIzdelkaDGVv);
            this.groupBox4.Controls.Add(this.imeIzdelkaLv);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(295, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 397);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sestavine";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.izdelkiDGVv);
            this.groupBox3.Controls.Add(this.kategorijeCBv);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 252);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Meni";
            // 
            // izdelkiDGVv
            // 
            this.izdelkiDGVv.AllowUserToAddRows = false;
            this.izdelkiDGVv.AllowUserToDeleteRows = false;
            this.izdelkiDGVv.AllowUserToResizeColumns = false;
            this.izdelkiDGVv.AllowUserToResizeRows = false;
            this.izdelkiDGVv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.izdelkiDGVv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izdelkiDGVv.Location = new System.Drawing.Point(6, 57);
            this.izdelkiDGVv.MultiSelect = false;
            this.izdelkiDGVv.Name = "izdelkiDGVv";
            this.izdelkiDGVv.ReadOnly = true;
            this.izdelkiDGVv.RowHeadersVisible = false;
            this.izdelkiDGVv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.izdelkiDGVv.Size = new System.Drawing.Size(269, 189);
            this.izdelkiDGVv.TabIndex = 7;
            this.izdelkiDGVv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.izdelkiDGVv_CellMouseDoubleClick);
            // 
            // kategorijeCBv
            // 
            this.kategorijeCBv.FormattingEnabled = true;
            this.kategorijeCBv.Location = new System.Drawing.Point(6, 26);
            this.kategorijeCBv.Name = "kategorijeCBv";
            this.kategorijeCBv.Size = new System.Drawing.Size(121, 28);
            this.kategorijeCBv.TabIndex = 1;
            this.kategorijeCBv.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Izdelki
            // 
            this.Izdelki.Controls.Add(this.button6);
            this.Izdelki.Controls.Add(this.button5);
            this.Izdelki.Controls.Add(this.groupBox8);
            this.Izdelki.Controls.Add(this.groupBox7);
            this.Izdelki.Location = new System.Drawing.Point(4, 29);
            this.Izdelki.Name = "Izdelki";
            this.Izdelki.Padding = new System.Windows.Forms.Padding(3);
            this.Izdelki.Size = new System.Drawing.Size(851, 521);
            this.Izdelki.TabIndex = 2;
            this.Izdelki.Text = "Izdelki";
            this.Izdelki.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dodajIzdelkiBi);
            this.groupBox8.Controls.Add(this.izdelkiDGVi);
            this.groupBox8.Location = new System.Drawing.Point(428, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(416, 510);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Izdelki";
            // 
            // dodajIzdelkiBi
            // 
            this.dodajIzdelkiBi.Location = new System.Drawing.Point(326, 18);
            this.dodajIzdelkiBi.Name = "dodajIzdelkiBi";
            this.dodajIzdelkiBi.Size = new System.Drawing.Size(84, 28);
            this.dodajIzdelkiBi.TabIndex = 3;
            this.dodajIzdelkiBi.Text = "Dodaj";
            this.dodajIzdelkiBi.UseVisualStyleBackColor = true;
            // 
            // izdelkiDGVi
            // 
            this.izdelkiDGVi.AllowUserToAddRows = false;
            this.izdelkiDGVi.AllowUserToDeleteRows = false;
            this.izdelkiDGVi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.izdelkiDGVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izdelkiDGVi.Location = new System.Drawing.Point(6, 52);
            this.izdelkiDGVi.Name = "izdelkiDGVi";
            this.izdelkiDGVi.ReadOnly = true;
            this.izdelkiDGVi.RowHeadersVisible = false;
            this.izdelkiDGVi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.izdelkiDGVi.Size = new System.Drawing.Size(404, 452);
            this.izdelkiDGVi.TabIndex = 0;
            this.izdelkiDGVi.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.izdelkiDGVi_CellContentDoubleClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dodajKategorijeBi);
            this.groupBox7.Controls.Add(this.kategorijeDGVi);
            this.groupBox7.Location = new System.Drawing.Point(6, 40);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(416, 476);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Kategorije";
            // 
            // dodajKategorijeBi
            // 
            this.dodajKategorijeBi.Location = new System.Drawing.Point(326, 18);
            this.dodajKategorijeBi.Name = "dodajKategorijeBi";
            this.dodajKategorijeBi.Size = new System.Drawing.Size(84, 28);
            this.dodajKategorijeBi.TabIndex = 3;
            this.dodajKategorijeBi.Text = "Dodaj";
            this.dodajKategorijeBi.UseVisualStyleBackColor = true;
            // 
            // kategorijeDGVi
            // 
            this.kategorijeDGVi.AllowUserToAddRows = false;
            this.kategorijeDGVi.AllowUserToDeleteRows = false;
            this.kategorijeDGVi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kategorijeDGVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kategorijeDGVi.Location = new System.Drawing.Point(6, 52);
            this.kategorijeDGVi.MultiSelect = false;
            this.kategorijeDGVi.Name = "kategorijeDGVi";
            this.kategorijeDGVi.ReadOnly = true;
            this.kategorijeDGVi.RowHeadersVisible = false;
            this.kategorijeDGVi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kategorijeDGVi.Size = new System.Drawing.Size(404, 418);
            this.kategorijeDGVi.TabIndex = 0;
            this.kategorijeDGVi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.kategorijeDGVi_CellMouseClick);
            this.kategorijeDGVi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.kategorijeDGV_CellMouseDoubleClick);
            // 
            // dodajSurovineBv
            // 
            this.dodajSurovineBv.Location = new System.Drawing.Point(191, 18);
            this.dodajSurovineBv.Name = "dodajSurovineBv";
            this.dodajSurovineBv.Size = new System.Drawing.Size(84, 28);
            this.dodajSurovineBv.TabIndex = 9;
            this.dodajSurovineBv.Text = "Dodaj ->";
            this.dodajSurovineBv.UseVisualStyleBackColor = true;
            this.dodajSurovineBv.Click += new System.EventHandler(this.dodajSurovineBv_Click);
            // 
            // kolicinaBv
            // 
            this.kolicinaBv.Location = new System.Drawing.Point(130, 18);
            this.kolicinaBv.Name = "kolicinaBv";
            this.kolicinaBv.Size = new System.Drawing.Size(55, 26);
            this.kolicinaBv.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Količina(g):";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Controls.Add(this.button3);
            this.groupBox9.Controls.Add(this.NUDv);
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Controls.Add(this.dodajIzdelekBv);
            this.groupBox9.Location = new System.Drawing.Point(295, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(263, 104);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Urejanje Pogleda";
            // 
            // NUDv
            // 
            this.NUDv.Location = new System.Drawing.Point(102, 27);
            this.NUDv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDv.Name = "NUDv";
            this.NUDv.Size = new System.Drawing.Size(46, 26);
            this.NUDv.TabIndex = 16;
            this.NUDv.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Količina:";
            // 
            // dodajIzdelekBv
            // 
            this.dodajIzdelekBv.Location = new System.Drawing.Point(154, 27);
            this.dodajIzdelekBv.Name = "dodajIzdelekBv";
            this.dodajIzdelekBv.Size = new System.Drawing.Size(84, 28);
            this.dodajIzdelekBv.TabIndex = 15;
            this.dodajIzdelekBv.Text = "Dodaj";
            this.dodajIzdelekBv.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "Odstrani";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // imeIzdelkaLv
            // 
            this.imeIzdelkaLv.AutoSize = true;
            this.imeIzdelkaLv.Location = new System.Drawing.Point(6, 29);
            this.imeIzdelkaLv.Name = "imeIzdelkaLv";
            this.imeIzdelkaLv.Size = new System.Drawing.Size(91, 20);
            this.imeIzdelkaLv.TabIndex = 19;
            this.imeIzdelkaLv.Text = "Ime Izdelka";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 28);
            this.button3.TabIndex = 19;
            this.button3.Text = "Odstrani";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(154, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 28);
            this.button4.TabIndex = 20;
            this.button4.Text = "Uredi";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 28);
            this.button5.TabIndex = 4;
            this.button5.Text = "Uvozi";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(96, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 28);
            this.button6.TabIndex = 5;
            this.button6.Text = "Izvozi";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // surovineDGVv
            // 
            this.surovineDGVv.AllowUserToAddRows = false;
            this.surovineDGVv.AllowUserToDeleteRows = false;
            this.surovineDGVv.AllowUserToResizeColumns = false;
            this.surovineDGVv.AllowUserToResizeRows = false;
            this.surovineDGVv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.surovineDGVv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.surovineDGVv.Location = new System.Drawing.Point(6, 52);
            this.surovineDGVv.MultiSelect = false;
            this.surovineDGVv.Name = "surovineDGVv";
            this.surovineDGVv.ReadOnly = true;
            this.surovineDGVv.RowHeadersVisible = false;
            this.surovineDGVv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.surovineDGVv.Size = new System.Drawing.Size(269, 189);
            this.surovineDGVv.TabIndex = 8;
            // 
            // sestavineIzdelkaDGVv
            // 
            this.sestavineIzdelkaDGVv.AllowUserToDeleteRows = false;
            this.sestavineIzdelkaDGVv.AllowUserToResizeColumns = false;
            this.sestavineIzdelkaDGVv.AllowUserToResizeRows = false;
            this.sestavineIzdelkaDGVv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sestavineIzdelkaDGVv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sestavineIzdelkaDGVv.Location = new System.Drawing.Point(6, 59);
            this.sestavineIzdelkaDGVv.MultiSelect = false;
            this.sestavineIzdelkaDGVv.Name = "sestavineIzdelkaDGVv";
            this.sestavineIzdelkaDGVv.ReadOnly = true;
            this.sestavineIzdelkaDGVv.RowHeadersVisible = false;
            this.sestavineIzdelkaDGVv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sestavineIzdelkaDGVv.Size = new System.Drawing.Size(251, 329);
            this.sestavineIzdelkaDGVv.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 554);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.Text = "MAŠapp";
            this.tabControl1.ResumeLayout(false);
            this.Pregled.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.porabaDGVp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zalogaDGVp)).EndInit();
            this.Vnos.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledDGVv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porabaDGVv)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.izdelkiDGVv)).EndInit();
            this.Izdelki.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.izdelkiDGVi)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kategorijeDGVi)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surovineDGVv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sestavineIzdelkaDGVv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pregled;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox datumCBp;
        private System.Windows.Forms.Button izvoziBp;
        private System.Windows.Forms.DataGridView porabaDGVp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dodajZalogoBp;
        private System.Windows.Forms.DataGridView zalogaDGVp;
        private System.Windows.Forms.TabPage Vnos;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView pregledDGVv;
        private System.Windows.Forms.Label datumLv;
        private System.Windows.Forms.Button shraniPogledBv;
        private System.Windows.Forms.DataGridView porabaDGVv;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox kategorijeCBv;
        private System.Windows.Forms.TabPage Izdelki;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView izdelkiDGVi;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView kategorijeDGVi;
        private System.Windows.Forms.Button dodajIzdelkiBi;
        private System.Windows.Forms.Button dodajKategorijeBi;
        private System.Windows.Forms.DataGridView izdelkiDGVv;
        private System.Windows.Forms.Button izbrišiPogledBv;
        private System.Windows.Forms.Button dodajSurovineBv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kolicinaBv;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown NUDv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dodajIzdelekBv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label imeIzdelkaLv;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView surovineDGVv;
        private System.Windows.Forms.DataGridView sestavineIzdelkaDGVv;
    }
}

