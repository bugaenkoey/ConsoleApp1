using System;
using System.Collections.Generic;
using System.Text;

namespace Repository2CRUD
{
    public static class TypeConvertToSQL
    {
       public static string Convert( string type)
        {
            string typeToString= string.Empty;
            switch (type)
            {
                case "System.Int32":
                    return "INT";
                    
                case "System.String":
                    return "NVARCHAR(50)";
                    
                default:
                    break;
            }


            return typeToString;
        }
    }
}
