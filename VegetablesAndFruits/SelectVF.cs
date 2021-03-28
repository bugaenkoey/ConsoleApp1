using System.Data.SqlClient;

namespace VegetablesAndFruits
{
    public class SelectVF
    {
        public SelectVF(string text, string select)
        {
            Text = text;
            Select = select;
        }
 
        public SelectVF(string text, string select, SqlParameter[] @params) : this(text, select)

        {
            Params = @params;
          //  ListSqlParameters.AddRange(@params);
        }


     //   public static List<SqlParameter> ListSqlParameters = new List<SqlParameter>();
        public SqlParameter[] Params { get; set; }
        
        public string Text { get; set; }
        public string Select { get; set; }

        public override string ToString()
        {
            return Text.ToString();
        }
    }
}
