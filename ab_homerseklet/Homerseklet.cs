using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ab_homerseklet
{
    internal class Homerseklet
    {
        const string szerver = "server=linsql.verebely.dc;uid=diak57;database=diak57;password=HXPEFG";
        MySqlConnection kapcsolat;
        MySqlCommand parancs;
        MySqlDataReader dr;

        public MySqlDataReader Dr { get => dr; set => dr = value; }
    
        public Homerseklet(string sql)
        {
            kapcsolat = new MySqlConnection(szerver);
            kapcsolat.Open();
            parancs = new MySqlCommand(sql, kapcsolat);
            dr = parancs.ExecuteReader();
        }

        public void lezaras()
        {
            kapcsolat.Close();
        }

        ~Homerseklet()
        {
            kapcsolat.Close();
        }
    }
}
