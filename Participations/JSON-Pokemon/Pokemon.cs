using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Pokemon
{
    class Pokemon
    {

        public InfoObject info { get; set; }

        public class InfoObject
        {
            public int weight { get; set; }

            public int id { get; set; }

            public int height { get; set; }

            public List<Sprite> sprites { get; set; }


        }

        public class Sprite
        {
            public string front_default { get; set; }

            public string front_shiny { get; set; }
        }

        public class Types
        {
            public List<Type> type { get; set; }
        }

        public class Type
        {
            public string name { get; set; }

            public string url { get; set; }
        }
    }
}
