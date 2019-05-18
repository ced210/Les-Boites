using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Boites
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box("Man! Hey!!!\r\nceci est un test\r\nmultiligne");
            Box.Display(box);
            Box box1 = new Box("Yo\nMamamama\nokok");
            Box box2 = new Box("youkoulele"); 

            HorizontalBox hb = new HorizontalBox(box1, box2);
            Box.Display(hb);

        }
    }
}
