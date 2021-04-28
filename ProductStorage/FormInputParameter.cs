using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProductStorage
{
    public partial class FormInputParameter : Form
    {
        public FormInputParameter()
        {
            InitializeComponent();
        }

        public FormInputParameter(SqlParameter[] sqlParameters)
        {
            SqlParameters = sqlParameters;
        }

        public SqlParameter[] SqlParameters { get; }
    }
}
