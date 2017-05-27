namespace TA_PengenalanPola
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
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dGV_dataKasus = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dGV_atribut1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dGV_atribut2 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dGV_atribut3 = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dGV_bobot = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Exec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_sawah = new System.Windows.Forms.ComboBox();
            this.comboBox_bulan = new System.Windows.Forms.ComboBox();
            this.comboBox_tanaman = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dGV_Result = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.lbl_path = new System.Windows.Forms.Label();
            this.label_index_kasus = new System.Windows.Forms.Label();
            this.label_resiko = new System.Windows.Forms.Label();
            this.label_datakasus = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_dataKasus)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_atribut1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_atribut2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_atribut3)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_bobot)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Result)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pattern Recognition (Data Mining)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(645, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistem Prediksi Kemungkinan Terjadinya Resiko Gagal Panen dalam Penentuan Bulan C" +
    "ocok Tanam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menggunakan Algoritma Klasifikasi k-Nearest Neighbor (k-NN)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(41, 133);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(298, 364);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dGV_dataKasus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(290, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data Kasus";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dGV_dataKasus
            // 
            this.dGV_dataKasus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_dataKasus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_dataKasus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_dataKasus.Location = new System.Drawing.Point(0, 0);
            this.dGV_dataKasus.Name = "dGV_dataKasus";
            this.dGV_dataKasus.ReadOnly = true;
            this.dGV_dataKasus.RowHeadersVisible = false;
            this.dGV_dataKasus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGV_dataKasus.Size = new System.Drawing.Size(290, 338);
            this.dGV_dataKasus.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dGV_atribut1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(290, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kedekatan Atribut (J.Tanaman)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dGV_atribut1
            // 
            this.dGV_atribut1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_atribut1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_atribut1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_atribut1.Location = new System.Drawing.Point(0, 0);
            this.dGV_atribut1.Name = "dGV_atribut1";
            this.dGV_atribut1.ReadOnly = true;
            this.dGV_atribut1.RowHeadersVisible = false;
            this.dGV_atribut1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGV_atribut1.Size = new System.Drawing.Size(290, 338);
            this.dGV_atribut1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dGV_atribut2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(290, 338);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kedekatan Atribut (Periode)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dGV_atribut2
            // 
            this.dGV_atribut2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_atribut2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_atribut2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_atribut2.Location = new System.Drawing.Point(0, 0);
            this.dGV_atribut2.Name = "dGV_atribut2";
            this.dGV_atribut2.ReadOnly = true;
            this.dGV_atribut2.RowHeadersVisible = false;
            this.dGV_atribut2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGV_atribut2.Size = new System.Drawing.Size(290, 338);
            this.dGV_atribut2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dGV_atribut3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(290, 338);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kedekatan Atribut (J.Sawah)";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dGV_atribut3
            // 
            this.dGV_atribut3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_atribut3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_atribut3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_atribut3.Location = new System.Drawing.Point(0, 0);
            this.dGV_atribut3.Name = "dGV_atribut3";
            this.dGV_atribut3.ReadOnly = true;
            this.dGV_atribut3.RowHeadersVisible = false;
            this.dGV_atribut3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGV_atribut3.Size = new System.Drawing.Size(290, 338);
            this.dGV_atribut3.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(347, 135);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(168, 100);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dGV_bobot);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(160, 74);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Bobot Atribut";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dGV_bobot
            // 
            this.dGV_bobot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_bobot.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_bobot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_bobot.Location = new System.Drawing.Point(0, 0);
            this.dGV_bobot.Name = "dGV_bobot";
            this.dGV_bobot.ReadOnly = true;
            this.dGV_bobot.RowHeadersVisible = false;
            this.dGV_bobot.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGV_bobot.Size = new System.Drawing.Size(160, 74);
            this.dGV_bobot.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Masukkan Contoh Kasus :";
            // 
            // btn_Exec
            // 
            this.btn_Exec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exec.Location = new System.Drawing.Point(236, 53);
            this.btn_Exec.Name = "btn_Exec";
            this.btn_Exec.Size = new System.Drawing.Size(75, 76);
            this.btn_Exec.TabIndex = 6;
            this.btn_Exec.Text = "Cek";
            this.btn_Exec.UseVisualStyleBackColor = true;
            this.btn_Exec.Click += new System.EventHandler(this.btn_Exec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_sawah);
            this.groupBox1.Controls.Add(this.comboBox_bulan);
            this.groupBox1.Controls.Add(this.comboBox_tanaman);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_Exec);
            this.groupBox1.Location = new System.Drawing.Point(347, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 147);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contoh Kasus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "J.Sawah";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bulan Tanam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "J.Tanaman";
            // 
            // comboBox_sawah
            // 
            this.comboBox_sawah.AutoCompleteCustomSource.AddRange(new string[] {
            "Irigasi",
            "Musiman"});
            this.comboBox_sawah.FormattingEnabled = true;
            this.comboBox_sawah.Location = new System.Drawing.Point(98, 108);
            this.comboBox_sawah.Name = "comboBox_sawah";
            this.comboBox_sawah.Size = new System.Drawing.Size(121, 21);
            this.comboBox_sawah.TabIndex = 9;
            // 
            // comboBox_bulan
            // 
            this.comboBox_bulan.FormattingEnabled = true;
            this.comboBox_bulan.Location = new System.Drawing.Point(98, 80);
            this.comboBox_bulan.Name = "comboBox_bulan";
            this.comboBox_bulan.Size = new System.Drawing.Size(121, 21);
            this.comboBox_bulan.TabIndex = 8;
            // 
            // comboBox_tanaman
            // 
            this.comboBox_tanaman.FormattingEnabled = true;
            this.comboBox_tanaman.Location = new System.Drawing.Point(98, 53);
            this.comboBox_tanaman.Name = "comboBox_tanaman";
            this.comboBox_tanaman.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tanaman.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_datakasus);
            this.groupBox2.Controls.Add(this.label_resiko);
            this.groupBox2.Controls.Add(this.label_index_kasus);
            this.groupBox2.Location = new System.Drawing.Point(347, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasil Klasifikasi";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(41, 503);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(642, 160);
            this.tabControl3.TabIndex = 9;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dGV_Result);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(634, 134);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Proses Perhitungan";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dGV_Result
            // 
            this.dGV_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Result.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_Result.Location = new System.Drawing.Point(0, 0);
            this.dGV_Result.Name = "dGV_Result";
            this.dGV_Result.ReadOnly = true;
            this.dGV_Result.RowHeadersVisible = false;
            this.dGV_Result.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGV_Result.Size = new System.Drawing.Size(634, 134);
            this.dGV_Result.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_OpenFile);
            this.groupBox3.Location = new System.Drawing.Point(528, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pilih Data";
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenFile.Location = new System.Drawing.Point(8, 21);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(134, 71);
            this.btn_OpenFile.TabIndex = 0;
            this.btn_OpenFile.Text = "Buka File";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(39, 114);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(76, 13);
            this.lbl_path.TabIndex = 11;
            this.lbl_path.Text = "Lokasi Data : -";
            this.lbl_path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_index_kasus
            // 
            this.label_index_kasus.AutoSize = true;
            this.label_index_kasus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_index_kasus.Location = new System.Drawing.Point(6, 22);
            this.label_index_kasus.Name = "label_index_kasus";
            this.label_index_kasus.Size = new System.Drawing.Size(112, 13);
            this.label_index_kasus.TabIndex = 0;
            this.label_index_kasus.Text = "Kasus Terdekat : -";
            // 
            // label_resiko
            // 
            this.label_resiko.AutoSize = true;
            this.label_resiko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resiko.Location = new System.Drawing.Point(6, 47);
            this.label_resiko.Name = "label_resiko";
            this.label_resiko.Size = new System.Drawing.Size(139, 13);
            this.label_resiko.TabIndex = 1;
            this.label_resiko.Text = "Resiko Gagal Panen : -";
            // 
            // label_datakasus
            // 
            this.label_datakasus.AutoSize = true;
            this.label_datakasus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datakasus.Location = new System.Drawing.Point(6, 74);
            this.label_datakasus.Name = "label_datakasus";
            this.label_datakasus.Size = new System.Drawing.Size(88, 13);
            this.label_datakasus.TabIndex = 2;
            this.label_datakasus.Text = "Data Kasus : -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 681);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pattern Recognition (Data Mining) using k-NN Algorithm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_dataKasus)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_atribut1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_atribut2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_atribut3)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_bobot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Result)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Exec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_tanaman;
        private System.Windows.Forms.ComboBox comboBox_bulan;
        private System.Windows.Forms.ComboBox comboBox_sawah;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dGV_dataKasus;
        private System.Windows.Forms.DataGridView dGV_atribut1;
        private System.Windows.Forms.DataGridView dGV_atribut2;
        private System.Windows.Forms.DataGridView dGV_atribut3;
        private System.Windows.Forms.DataGridView dGV_bobot;
        private System.Windows.Forms.DataGridView dGV_Result;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Label label_datakasus;
        private System.Windows.Forms.Label label_resiko;
        private System.Windows.Forms.Label label_index_kasus;
    }
}

