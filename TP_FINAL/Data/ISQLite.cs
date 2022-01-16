using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP_FINAL.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConexao();

    }
}
