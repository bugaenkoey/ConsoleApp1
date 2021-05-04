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
    public partial class FormInputStringParameter : Form
    {
       // public string Parameter;
        public FormInputStringParameter()
        {
            InitializeComponent();
        }

        /*  public FormInputStringParameter(SqlParameter[] sqlParameters)
          {
              SqlParameters = sqlParameters;
          }*/
        public FormInputStringParameter(SqlParameter sqlParameter): this()
        {
     //       SqlParameter = sqlParameter;
        }

    //    public SqlParameter SqlParameter { get; }

      

        internal object GetParam()
        {
            return textBox.Text;
        }
    }
}
