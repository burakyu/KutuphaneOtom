﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using Oracle.ManagedDataAccess.Client;

namespace Kutuphane_Otomasyonu
{
    class DbCon
    {
        public OracleConnection connection()
        {
            OracleConnection baglanti = new OracleConnection("User Id = USER1;Password = 1234;Data Source = localhost:1521/XEPDB1;"); baglanti.Open();
            return baglanti;
        }

    }
}
