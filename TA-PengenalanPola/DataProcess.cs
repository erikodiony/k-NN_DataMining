using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_PengenalanPola
{
    internal static class attr_tanaman
    {
        public static Dictionary<string, float> attr_itemA;
        public static Dictionary<string, float> attr_itemB;
        public static Dictionary<string, float> attr_itemC;
        public static Dictionary<string, float> attr_itemD;
        public static string[] attr_item;
    }

    internal static class attr_sawah
    {
        public static Dictionary<string, float> attr_musiman;
        public static Dictionary<string, float> attr_irigasi;
        public static string[] attr_item;
    }

    internal static class attr_periode
    {
        public static Dictionary<string, float> attr_JanMar;
        public static Dictionary<string, float> attr_AprJun;
        public static Dictionary<string, float> attr_JulSep;
        public static Dictionary<string, float> attr_OktDes;
        public static string[] attr_item;
    }

    internal static class bobot
    {
        public static Dictionary<string, float> bobot_val;
    }

    internal static class dataKasus
    {
        public static Dictionary<string, string[]> dataKasus_val;
    }

    internal static class bulan_periode
    {
        public static Dictionary<string, string> bulan_periode_val;
        public static readonly string[] bulan = new string[] { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
    }

    internal static class RESULT
    {
        public static List<float> val_of_tanaman = new List<float>();
        public static List<float> val_of_periode = new List<float>();
        public static List<float> val_of_sawah = new List<float>();

        public static float[] count_of_tanaman;
        public static float[] count_of_periode;
        public static float[] count_of_sawah;

        public static List<float> count_all;
        public static List<float> count_result;


    }

    class DataProcess
    {

        //Perhitungan Tanaman
        //===================================================================//

        //Get Value Compare_Tanaman TRUE
        public float getCompareTanaman_TRUE(string value, string key_DataKasus)
        {
            float getValue = 0;
            if (value == attr_tanaman.attr_item[0] && value == key_DataKasus)
            {
                getValue = attr_tanaman.attr_itemA[value];
            }

            if (value == attr_tanaman.attr_item[1] && value == key_DataKasus)
            {
                getValue = attr_tanaman.attr_itemB[value];
            }

            if (value == attr_tanaman.attr_item[2] && value == key_DataKasus)
            {
                getValue = attr_tanaman.attr_itemC[value];
            }

            if (value == attr_tanaman.attr_item[3] && value == key_DataKasus)
            {
                getValue = attr_tanaman.attr_itemD[value];
            }
            return getValue;

        }

        //Get Value Compare_Tanaman FALSE
        public float getCompareTanaman_FALSE(string value, string key_DataKasus)
        {
            float getValue = 0;
            if (key_DataKasus == attr_tanaman.attr_item[0])
            {
                getValue = attr_tanaman.attr_itemA[value];
            }
            if (key_DataKasus == attr_tanaman.attr_item[1])
            {
                getValue = attr_tanaman.attr_itemB[value];
            }
            if (key_DataKasus == attr_tanaman.attr_item[2])
            {
                getValue = attr_tanaman.attr_itemC[value];
            }
            if (key_DataKasus == attr_tanaman.attr_item[3])
            {
                getValue = attr_tanaman.attr_itemD[value];
            }
            return getValue;
        }


        //Perhitungan Periode
        //===================================================================//

        //Get Value Compare_Periode TRUE
        public float getComparePeriode_TRUE(string value, string key_DataKasus)
        {
            float getValue = 0;
            
            if (value == attr_periode.attr_item[0] && value == key_DataKasus)
            {
                getValue = attr_periode.attr_JanMar[value];
            }

            if (value == attr_periode.attr_item[1] && value == key_DataKasus)
            {
                getValue = attr_periode.attr_AprJun[value];
            }

            if (value == attr_periode.attr_item[2] && value == key_DataKasus)
            {
                getValue = attr_periode.attr_JulSep[value];
            }

            if (value == attr_periode.attr_item[3] && value == key_DataKasus)
            {
                getValue = attr_periode.attr_OktDes[value];
            }

            return getValue;

        }

        //Get Value Compare_Periode FALSE
        public float getComparePeriode_FALSE(string value, string key_DataKasus)
        {
            float getValue = 0;
            if (key_DataKasus == attr_periode.attr_item[0])
            {
                getValue = attr_periode.attr_JanMar[value];
            }
            if (key_DataKasus == attr_periode.attr_item[1])
            {
                getValue = attr_periode.attr_AprJun[value];
            }
            if (key_DataKasus == attr_periode.attr_item[2])
            {
                getValue = attr_periode.attr_JulSep[value];
            }
            if (key_DataKasus == attr_periode.attr_item[3])
            {
                getValue = attr_periode.attr_OktDes[value];
            }
            return getValue;
        }


        //Perhitungan Sawah
        //===================================================================//

        //Get Value Compare_Sawah TRUE
        public float getCompareSawah_TRUE(string value, string key_DataKasus)
        {
            float getValue = 0;
            if (value == attr_sawah.attr_item[0] && value == key_DataKasus)
            {
                getValue = attr_sawah.attr_irigasi[value];
            }

            if (value == attr_sawah.attr_item[1] && value == key_DataKasus)
            {
                getValue = attr_sawah.attr_musiman[value];
            }
            return getValue;

        }

        //Get Value Compare_Sawah FALSE
        public float getCompareSawah_FALSE(string value, string key_DataKasus)
        {
            float getValue = 0;
            if (key_DataKasus == attr_sawah.attr_item[0])
            {
                getValue = attr_sawah.attr_irigasi[value];
            }
            if (key_DataKasus == attr_sawah.attr_item[1])
            {
                getValue = attr_sawah.attr_musiman[value];
            }
            return getValue;
        }


        //Compare_Tanaman
        public List<float> Compare_Tanaman(string val_tanaman)
        {
            List<float> result = new List<float>();

            foreach (var x in dataKasus.dataKasus_val)
            {
                if (val_tanaman == x.Value[0])
                {
                    result.Add(getCompareTanaman_TRUE(val_tanaman, x.Value[0]));
                }
                else
                {
                    result.Add(getCompareTanaman_FALSE(val_tanaman, x.Value[0]));
                }
            }
            return result;
        }

        //Compare_Periode
        public List<float> Compare_Periode(string val_bulan)
        {
            List<float> result = new List<float>();

            foreach (var x in dataKasus.dataKasus_val)
            {
                if (val_bulan == x.Value[1])
                {
                    result.Add(getComparePeriode_TRUE(val_bulan, x.Value[1]));
                }
                else
                {
                    result.Add(getComparePeriode_FALSE(val_bulan, x.Value[1]));
                }
            }
            return result;
        }

        //Compare_Sawah
        public List<float> Compare_Sawah(string val_sawah)
        {
            List<float> result = new List<float>();

            foreach (var x in dataKasus.dataKasus_val)
            {
                if (val_sawah == x.Value[2])
                {
                    result.Add(getCompareSawah_TRUE(val_sawah, x.Value[2]));
                }
                else
                {
                    result.Add(getCompareSawah_FALSE(val_sawah, x.Value[2]));
                }
            }
            return result;
        }

        //Count All
        public void Count_All()
        {
            RESULT.count_of_tanaman = new float[RESULT.val_of_tanaman.Capacity];
            RESULT.count_of_periode = new float[RESULT.val_of_periode.Capacity];
            RESULT.count_of_sawah = new float[RESULT.val_of_sawah.Capacity];

            int idx_tanaman = 0;
            foreach (var x in RESULT.val_of_tanaman)
            {
                RESULT.count_of_tanaman[idx_tanaman] = (x * (bobot.bobot_val["Jenis Tanaman"]));
                ++idx_tanaman;
            }

            int idx_periode = 0;
            foreach (var x in RESULT.val_of_periode)
            {
                RESULT.count_of_periode[idx_periode] = (x * (bobot.bobot_val["Periode"]));
                ++idx_periode;
            }

            int idx_sawah = 0;
            foreach (var x in RESULT.val_of_sawah)
            {
                RESULT.count_of_sawah[idx_sawah] = (x * (bobot.bobot_val["Jenis Sawah"]));
                ++idx_sawah;
            }

        }

        public void RUN_PROCESS(string item, string periode, string sawah)
        {
            foreach (var x in bulan_periode.bulan_periode_val)
            {
                if (periode == x.Key)
                {
                    periode = x.Value;
                }
            }

            RESULT.val_of_tanaman = Compare_Tanaman(item);
            RESULT.val_of_periode = Compare_Periode(periode);
            RESULT.val_of_sawah = Compare_Sawah(sawah);
            Count_All();
        }

    }
}
