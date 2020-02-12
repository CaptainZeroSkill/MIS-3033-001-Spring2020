using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Pokemon
{
    class PokemonAPI
    {

        public InfoObject info { get; set; }

        public List<ResultObject> results { get; set; }

        public class InfoObject
        {
            public int count { get; set; }

            public string next { get; set; }

            public string previous { get; set; }

            public List<ResultObject> results { get; set; }
        }

        public class ResultObject
        {

            public string name { get; set; }

            public string url { get; set; }
            public override string ToString()
            {
                return $"{name.ToUpper()}";
            }
        }
    }
}
