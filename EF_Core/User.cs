using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Home Home { get; set; }
    }
}
