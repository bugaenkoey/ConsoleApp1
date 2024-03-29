﻿namespace Repository2CRUD
{
    public class MyElement :IElementId
    {
        /*https://codverter.com/src/sqltoclass
         * 
CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Count] INT NOT NULL
)
*/

        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public MyElement(int Id_, string Name_, int Count_)
        {
            this.Id = Id_;
            this.Name = Name_;
            this.Count = Count_;
        }
        public MyElement(int Id_, string Name_)
        {
            this.Id = Id_;
            this.Name = Name_;
            Name = $"MyElement {Count}";

        }

        public MyElement()
        {
        }

        public override string ToString()
        {
            return $"Id = {Id}\tName = {Name}\tCount = {Count}\n";
        }
    }
}
