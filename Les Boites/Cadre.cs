using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Boites
{
    public  class Cadre
    {
        public string VerticalFrame { get; set; }
        
        public Cadre(int width)
        {
            VerticalFrame = "+" + new string('-', width) + "+";
        }
    }
}