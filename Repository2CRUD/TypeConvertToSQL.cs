namespace Repository2CRUD
{
    public static class TypeConvertToSQL
    {
       public static string Convert( string type)
        {
            /*
            switch (type)
            {
                case "System.Int32":
                    return "INT";
                    
                case "System.String":
                    return "NVARCHAR(50)";
                    
                default:
                    return string.Empty;
            }
             */
            return type switch
            {
                "System.Int32" => "INT",
                "System.String" => "NVARCHAR(50)",
                _ => string.Empty,
            };
        }
    }
}
