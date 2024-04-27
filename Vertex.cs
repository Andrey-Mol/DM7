using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM7
{
    public class Vertex
    {
        public int Number { get; set; }
        public List<int> Neighbors { get; set; }
        public int Color { get; set; }

        public Vertex(int number, List<int> neighbors) 
        { 
            Number = number;
            Neighbors = neighbors;
            Color = 0;
        }

    }
}
