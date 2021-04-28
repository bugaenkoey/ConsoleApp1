using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataAccessLayer.Entities
{
    /*
•	Название игры;
•	Студия или фирма создатель игры;
•	Стиль игры;
•	Дата релиза. 
     */
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Company { get; set; }

        public DateTime DateRelease { get; set; }
    }
}
