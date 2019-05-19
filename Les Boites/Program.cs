using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Boites
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Box box = new Box("Man! Hey!!!\r\nceci est un test\r\nmultiligne");
        //    Box.Display(box);
        //    Box box1 = new Box("Yo\nMamamama\nokok");
        //    Box box2 = new Box("youkoulele");

        //    HorizontalBox hb = new HorizontalBox(box1, box2);
        //    Box.Display(hb);



        //    VerticalBox vb = new VerticalBox(new Box("Yo\nMamamama\nokok"), new Box("youkoulele"));
        //    Box.Display(vb);
        //}


        static void Main(string[] args)
        {
            Box b = new Box();
            Box.Display(b);
            Box.Display(new Box("yo"));
            string texte = @"Man! Hey!!!
ceci est un test
multiligne";
            string aut_texte = "Ceci\nitou, genre";
            Box b0 = new Box(texte);
            Box b1 = new Box(aut_texte);
            Box.Display(b0);
            Box.Display(b1);
            VerticalBox cv = new VerticalBox(b0, b1);
            Box.Display(new Box(cv));
            HorizontalBox ch = new HorizontalBox(b0, b1);
            Box.Display(new Box(ch));
            VerticalBox cvplus = new VerticalBox(new Box(cv), new Box(ch));
            Box.Display(new Box(cvplus));
            HorizontalBox chplus = new HorizontalBox(new Box(cv), new Box(ch));
            Box.Display(new Box(chplus));
            VerticalBox cvv = new VerticalBox(new Box(chplus), new Box("coucou"));
            Box.Display(new Box(cvv));
            Box.Display(new Box(
               new HorizontalBox(
                  new Box("a\nb\nc\nd\ne"),
                     new Box(
                        new VerticalBox(
                           new Box("allo"), new Box("yo")
                        )
                     )
                  )
               )
            );
            Box.Display(
               new Box(new HorizontalBox(new Box("Yo"), new Box()))
            );
            Box.Display(
               new Box(new HorizontalBox(new Box(), new Box("Ya")))
            );
            Box.Display(
               new Box(new HorizontalBox(new Box(), new Box()))
            );
            Box.Display(
               new Box(new VerticalBox(new Box(), new Box()))
            );
            Box.Display(
               new Box(new VerticalBox(new Box("Yip"), new Box()))
            );
            Box.Display(
               new Box(new VerticalBox(new Box(), new Box("Yap")))
            );
        }
    }
}