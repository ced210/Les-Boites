using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Boites
{
    public class Frame
    {
        public string TopBottom { get; private set; }
        public string Center { get; private set; }

        public void setTopBottom(int size) // size of 4 should give +----+
        {
            TopBottom = "+";
            for (int i = 0; i < size; ++i)
            {
                TopBottom += "-";
            }
            TopBottom += "+";
        }
        public void setCenter(string center, int size)
        {
            Center = "|" + center;
            for (int i = center.Length; i < size; ++i) // yo should give |yo| if size == 4 should give |yo  | instead
            {
                Center += " ";
            }
            Center += "|";
        }
    }
}
