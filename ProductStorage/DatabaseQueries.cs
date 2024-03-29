﻿using System.Data.SqlClient;

namespace ProductStorage
{
    internal class DatabaseQueries
    {
        public string textqueri;
        public string Queri { get; set; }
        public SqlParameter[] sqlParameters;

        public DatabaseQueries(string textqueri, string queri)
        {
            this.textqueri = textqueri;
            this.Queri = queri;
        }

        public DatabaseQueries(string textqueri, string queri, SqlParameter[] sqlParameters):this (textqueri,  queri)
        {
          //  this.textqueri = textqueri;
          //  this.queri = queri;
            this.sqlParameters = sqlParameters;
        }

        public override string ToString()
        {
            return textqueri.ToString();
        }
    }
}