using System;
using System.Collections.Generic;
using System.Text;

namespace VegetablesAndFruits
{
    public class SelectVF
    {
        public SelectVF(string text, string select)
        {
            Text = text;
            Select = select;
        }

        public string Text {get;set;}
        public string Select { get; set; }

        public override string ToString()
        {
            return Text.ToString();
        }
    }
}
