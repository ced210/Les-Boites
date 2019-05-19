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
        public string SetTopBottom(int size) // size of 4 should give +----+
        {
            TopBottom = "+";
            for (int i = 0; i < size; ++i)
            {
                TopBottom += "-";
            }
            TopBottom += "+";

            return TopBottom;
        }

     
        public string SetCenter(string center, int size)
        {
            Center = "|" + center;
            for (int i = center.Length; i < size; ++i) // yo should give |yo| if size == 4 should give |yo  | instead
            {
                Center += " ";
            }
            Center += "|";
            return Center;
        }

       
        public string SetCenterHorizontalCombo(Box box1, Box box2, int heightIndex)
        {

            Center = "|" + box1.Text[heightIndex];
            for (int i = box1.Text[heightIndex].Length; i < box1.Width; ++i) 
            {
                Center += " ";
            }
            Center += "|" + box2.Text[heightIndex];
            for (int i = box2.Text[heightIndex].Length; i < box2.Width; ++i)
            {
                Center += " ";
            }
            Center += "|";
            return Center;
        }
    }
}
