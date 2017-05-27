using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_PengenalanPola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string PathData;
        
        OpenFileDialog opfile;
        OleDbConnection conn;
        OleDbDataAdapter connAdapter;
        DataTable dt;
        DataProcess dp = new DataProcess();

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                opfile = new OpenFileDialog();
                if (opfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    lbl_path.Text = String.Format("Lokasi Data : {0}", opfile.FileName);
                    PathData = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + opfile.FileName + ";Extended Properties='Excel 12.0 XML;HDR=YES;';";
                    setBindingDataKasus();
                    setBindingBobot();
                    setBindingAtrib1();
                    setBindingAtrib2();
                    setBindingAtrib3();
                    setValueToDictionary();
                    setComboBoxValue();

                }
            }
            catch { }
        }
        
        private void setBindingDataKasus()
        {
            conn = new OleDbConnection(PathData);
            connAdapter = new OleDbDataAdapter("Select * from [DataKasus$]", conn);
            dt = new DataTable();
            connAdapter.Fill(dt);
            dGV_dataKasus.DataSource = dt;
        }

        private void setBindingBobot()
        {
            conn = new OleDbConnection(PathData);
            connAdapter = new OleDbDataAdapter("Select * from [Bobot$]", conn);
            dt = new DataTable();
            connAdapter.Fill(dt);
            dGV_bobot.DataSource = dt;
        }

        private void setBindingAtrib1()
        {
            conn = new OleDbConnection(PathData);
            connAdapter = new OleDbDataAdapter("Select * from [Atribut1$]", conn);
            dt = new DataTable();
            connAdapter.Fill(dt);
            dGV_atribut1.DataSource = dt;
        }

        private void setBindingAtrib2()
        {
            conn = new OleDbConnection(PathData);
            connAdapter = new OleDbDataAdapter("Select * from [Atribut2$]", conn);
            dt = new DataTable();
            connAdapter.Fill(dt);
            dGV_atribut2.DataSource = dt;
        }

        private void setBindingAtrib3()
        {
            conn = new OleDbConnection(PathData);
            connAdapter = new OleDbDataAdapter("Select * from [Atribut3$]", conn);
            dt = new DataTable();
            connAdapter.Fill(dt);
            dGV_atribut3.DataSource = dt;
        }

        private void setValueToDictionary()
        {
            attr_tanaman.attr_itemA = new Dictionary<string, float>();
            attr_tanaman.attr_itemB = new Dictionary<string, float>();
            attr_tanaman.attr_itemC = new Dictionary<string, float>();
            attr_tanaman.attr_itemD = new Dictionary<string, float>();
            attr_tanaman.attr_item = new string[dGV_atribut1.Rows.Count-1];

            attr_periode.attr_JanMar = new Dictionary<string, float>();
            attr_periode.attr_AprJun = new Dictionary<string, float>();
            attr_periode.attr_JulSep = new Dictionary<string, float>();
            attr_periode.attr_OktDes = new Dictionary<string, float>();
            attr_periode.attr_item = new string[dGV_atribut2.Rows.Count - 1];

            attr_sawah.attr_irigasi = new Dictionary<string, float>();
            attr_sawah.attr_musiman = new Dictionary<string, float>();
            attr_sawah.attr_item = new string[dGV_atribut3.Rows.Count - 1];            

            bobot.bobot_val = new Dictionary<string, float>();

            dataKasus.dataKasus_val = new Dictionary<string, string[]>();

            bulan_periode.bulan_periode_val = new Dictionary<string, string>();

            //Save Value DataGridView to Array (Attribut Tanaman)
            for (int i = 0; i < (dGV_atribut1.Rows.Count - 1); i++)
            {
                attr_tanaman.attr_itemA.Add(dGV_atribut1.Rows[i].Cells[0].Value.ToString(), float.Parse(dGV_atribut1.Rows[i].Cells[1].Value.ToString()));
                attr_tanaman.attr_itemB.Add(dGV_atribut1.Rows[i].Cells[0].Value.ToString(), float.Parse(dGV_atribut1.Rows[i].Cells[2].Value.ToString()));
                attr_tanaman.attr_itemC.Add(dGV_atribut1.Rows[i].Cells[0].Value.ToString(), float.Parse(dGV_atribut1.Rows[i].Cells[3].Value.ToString()));
                attr_tanaman.attr_itemD.Add(dGV_atribut1.Rows[i].Cells[0].Value.ToString(), float.Parse(dGV_atribut1.Rows[i].Cells[4].Value.ToString()));
                attr_tanaman.attr_item[i] = dGV_atribut1.Rows[i].Cells[0].Value.ToString();
            }

            //Save Value DataGridView to Array (Attribut Periode)
            for (int i = 0; i < (dGV_atribut2.Rows.Count - 1); i++)
            {
                attr_periode.attr_JanMar.Add(dGV_atribut2.Rows[i].Cells[0].Value.ToString(), float.Parse(dGV_atribut2.Rows[i].Cells[1].Value.ToString()));
                attr_periode.attr_AprJun.Add(dGV_atribut2.Rows[i].Cells[0].Value.ToString(), float.Parse(dGV_atribut2.Rows[i].Cells[2].Value.ToString()));
                attr_periode.attr_JulSep.Add(dGV_atribut2.Rows[i].Cells[0].Value.ToString(), float.Parse(dGV_atribut2.Rows[i].Cells[3].Value.ToString()));
                attr_periode.attr_OktDes.Add(dGV_atribut2.Rows[i].Cells[0].Value.ToString(), float.Parse(dGV_atribut2.Rows[i].Cells[4].Value.ToString()));
                attr_periode.attr_item[i] = dGV_atribut2.Rows[i].Cells[0].Value.ToString();
            }

            //Save Value DataGridView to Array (Attribut Sawah)
            for (int i = 0; i < (dGV_atribut3.Rows.Count - 1); i++)
            {
                attr_sawah.attr_irigasi.Add(dGV_atribut3.Rows[i].Cells[0].Value.ToString(), float.Parse(dGV_atribut3.Rows[i].Cells[1].Value.ToString()));
                attr_sawah.attr_musiman.Add(dGV_atribut3.Rows[i].Cells[0].Value.ToString(), float.Parse(dGV_atribut3.Rows[i].Cells[2].Value.ToString()));
                attr_sawah.attr_item[i] = dGV_atribut3.Rows[i].Cells[0].Value.ToString();
            }

            //Save Value DataGridView to Array (Bobot)
            for (int i = 0; i < (dGV_bobot.Rows.Count - 1); i++)
            {
                bobot.bobot_val.Add(dGV_bobot.Rows[i].Cells[0].Value.ToString(), float.Parse(dGV_bobot.Rows[i].Cells[1].Value.ToString()));
            }

            //Save Value DataGridView to Array (Data Kasus)
            for (int i = 0; i < (dGV_dataKasus.Rows.Count - 1); i++)
            {
                dataKasus.dataKasus_val.Add(dGV_dataKasus.Rows[i].Cells[0].Value.ToString(), new string[] { dGV_dataKasus.Rows[i].Cells[1].Value.ToString(), dGV_dataKasus.Rows[i].Cells[2].Value.ToString(), dGV_dataKasus.Rows[i].Cells[3].Value.ToString(), dGV_dataKasus.Rows[i].Cells[4].Value.ToString() });
            }

            //Save Value DataGridView to Array (Bulan in Periode)
            bulan_periode.bulan_periode_val.Add(bulan_periode.bulan[0], "Jan-Mar");
            bulan_periode.bulan_periode_val.Add(bulan_periode.bulan[1], "Jan-Mar");
            bulan_periode.bulan_periode_val.Add(bulan_periode.bulan[2], "Jan-Mar");
            bulan_periode.bulan_periode_val.Add(bulan_periode.bulan[3], "Apr-Jun");
            bulan_periode.bulan_periode_val.Add(bulan_periode.bulan[4], "Apr-Jun");
            bulan_periode.bulan_periode_val.Add(bulan_periode.bulan[5], "Apr-Jun");
            bulan_periode.bulan_periode_val.Add(bulan_periode.bulan[6], "Jul-Sep");
            bulan_periode.bulan_periode_val.Add(bulan_periode.bulan[7], "Jul-Sep");
            bulan_periode.bulan_periode_val.Add(bulan_periode.bulan[8], "Jul-Sep");
            bulan_periode.bulan_periode_val.Add(bulan_periode.bulan[9], "Okt-Des");
            bulan_periode.bulan_periode_val.Add(bulan_periode.bulan[10], "Okt-Des");
            bulan_periode.bulan_periode_val.Add(bulan_periode.bulan[11], "Okt-Des");
        }

        private void setComboBoxValue()
        {
            foreach (var x in attr_tanaman.attr_item)
            {
                comboBox_tanaman.Items.Add(x);
            }

            foreach (var x in bulan_periode.bulan)
            {
                comboBox_bulan.Items.Add(x);
            }

            foreach (var x in attr_sawah.attr_item)
            {
                comboBox_sawah.Items.Add(x);
            }
        }        

        private void btn_Exec_Click(object sender, EventArgs e)
        {
            if (comboBox_tanaman.Text != "" && comboBox_bulan.Text != "" && comboBox_sawah.Text != "")
            {
                dGV_Result.Rows.Clear();
                dGV_Result.Columns.Clear();

                dp.RUN_PROCESS(comboBox_tanaman.Text, comboBox_bulan.Text, comboBox_sawah.Text);
                setBindingToDatagridViewResult();
                DialogResult dlg = MessageBox.Show("Data berhasil di proses !\nProses berhasil...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Masih terdapat Isian yang kosong !\nGagal memproses...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void setBindingToDatagridViewResult()
        {
            RESULT.count_all = new List<float>();
            RESULT.count_result = new List<float>();

            dGV_Result.Columns.Add("No", "No.");
            dGV_Result.Columns.Add("Column1", "J.Tanaman (A)");
            dGV_Result.Columns.Add("Column2", "Bobot (J.Tanaman) (AA)");
            dGV_Result.Columns.Add("Column3", "Periode (B)");
            dGV_Result.Columns.Add("Column4", "Bobot (Periode) (BB)");
            dGV_Result.Columns.Add("Column5", "J.Sawah (C)");
            dGV_Result.Columns.Add("Column6", "Bobot (J.Sawah) (CC)");
            dGV_Result.Columns.Add("Column7", "(A * AA)");
            dGV_Result.Columns.Add("Column8", "(B * BB)");
            dGV_Result.Columns.Add("Column9", "(C * CC)");
            dGV_Result.Columns.Add("Column10", "(A * AA) + (B * BB) + (C * CC)");
            dGV_Result.Columns.Add("Column11", "(AA + BB + CC)");
            dGV_Result.Columns.Add("Column12", "(A * AA) + (B * BB) + (C * CC) / (AA + BB + CC)");

            //NO
            for (int no = 1; no <= RESULT.val_of_tanaman.Capacity; no++)
            {
                int indexRow = dGV_Result.Rows.Add();
                dGV_Result.Rows[indexRow].Cells["No"].Value = no;
            }

            //Column_1
            int idxColumn_1 = 0;
            foreach (var x in RESULT.val_of_tanaman)
            {
                dGV_Result.Rows[idxColumn_1].Cells["Column1"].Value = x;
                ++idxColumn_1;
            }

            //Column_2
            for (int idxColumn2 = 0; idxColumn2 < (dGV_Result.Rows.Count - 1); idxColumn2++)
            {
                dGV_Result.Rows[idxColumn2].Cells["Column2"].Value = bobot.bobot_val["Jenis Tanaman"];
            }

            //Column_3
            int idxColumn_3 = 0;
            foreach (var x in RESULT.val_of_periode)
            {
                dGV_Result.Rows[idxColumn_3].Cells["Column3"].Value = x;
                ++idxColumn_3;
            }

            //Column_4
            for (int idxColumn4 = 0; idxColumn4 < (dGV_Result.Rows.Count - 1); idxColumn4++)
            {
                dGV_Result.Rows[idxColumn4].Cells["Column4"].Value = bobot.bobot_val["Periode"];
            }

            //Column_5
            int idxColumn_5 = 0;
            foreach (var x in RESULT.val_of_sawah)
            {
                dGV_Result.Rows[idxColumn_5].Cells["Column5"].Value = x;
                ++idxColumn_5;
            }

            //Column_6
            for (int idxColumn6 = 0; idxColumn6 < (dGV_Result.Rows.Count - 1); idxColumn6++)
            {
                dGV_Result.Rows[idxColumn6].Cells["Column6"].Value = bobot.bobot_val["Jenis Sawah"];
            }

            //Column_7
            int idxColumn_7 = 0;
            foreach (var x in RESULT.count_of_tanaman)
            {
                dGV_Result.Rows[idxColumn_7].Cells["Column7"].Value = x;
                ++idxColumn_7;
            }

            //Column_8
            int idxColumn_8 = 0;
            foreach (var x in RESULT.count_of_periode)
            {
                dGV_Result.Rows[idxColumn_8].Cells["Column8"].Value = x;
                ++idxColumn_8;
            }

            //Column_9
            int idxColumn_9 = 0;
            foreach (var x in RESULT.count_of_sawah)
            {
                dGV_Result.Rows[idxColumn_9].Cells["Column9"].Value = x;
                ++idxColumn_9;
            }

            //Column_10
            for (int i = 0; i < (dGV_Result.Rows.Count - 1); i++)
            {
                RESULT.count_all.Add(RESULT.count_of_tanaman[i] + RESULT.count_of_periode[i] + RESULT.count_of_sawah[i]);
            }

            int idxColumn_10 = 0;
            foreach (var x in RESULT.count_all)
            {
                dGV_Result.Rows[idxColumn_10].Cells["Column10"].Value = x;
                ++idxColumn_10;
            }

            //Column_11
            for (int i = 0; i < (dGV_Result.Rows.Count - 1); i++)
            {
                dGV_Result.Rows[i].Cells["Column11"].Value = float.Parse(dGV_Result.Rows[i].Cells["Column2"].Value.ToString()) + float.Parse(dGV_Result.Rows[i].Cells["Column4"].Value.ToString()) + float.Parse(dGV_Result.Rows[i].Cells["Column6"].Value.ToString());
            }

            //Column_12
            for (int i = 0; i < (dGV_Result.Rows.Count - 1); i++)
            {
                RESULT.count_result.Add((RESULT.count_of_tanaman[i] + RESULT.count_of_periode[i] + RESULT.count_of_sawah[i]) / (float.Parse(dGV_Result.Rows[i].Cells["Column2"].Value.ToString()) + float.Parse(dGV_Result.Rows[i].Cells["Column4"].Value.ToString()) + float.Parse(dGV_Result.Rows[i].Cells["Column6"].Value.ToString())));
            }

            int idxColumn_12 = 0;
            foreach (var x in RESULT.count_result)
            {
                dGV_Result.Rows[idxColumn_12].Cells["Column12"].Value = x;
                ++idxColumn_12;
            }

            float maxVal = RESULT.count_result.Max();
            int getIndexMax = RESULT.count_result.IndexOf(maxVal) + 1;
            
            setBindingResult(dataKasus.dataKasus_val[getIndexMax.ToString()], getIndexMax, maxVal);

        }

        private void setBindingResult(string[] value, int getIndex, float maxVal)
        {
            label_index_kasus.Text = String.Format("Kasus Terdekat : {0} (Nilai : {1})", getIndex, maxVal);
            label_resiko.Text = String.Format("Resiko Gagal Panen : {0}", value[3]);
            label_datakasus.Text = String.Format("Data Kasus : {0} | {1} | {2} | {3}", value[0], value[1], value[2], value[3]);
        }

    }
}
