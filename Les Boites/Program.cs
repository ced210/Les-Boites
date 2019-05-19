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
            MasterBoite mb = new MasterBoite("yo\ncornet");

            Console.WriteLine(mb.ToString());


            Boite simpleBox = new Boite("yo");
            Boite multiLineBox = new Boite("yo\ncornet");

            Boite.Display(simpleBox);

            ComboHorizontal cb = new ComboHorizontal(simpleBox, multiLineBox);
            Boite.Display(new Boite(cb));
        }
    }
}


//        static void Main(string[] args)
//        {
//            Box b = new Box();
//            Box.Display(b);
//            Box.Display(new Box("yo"));
//            string texte = @"Man! Hey!!!
//ceci est un test
//multiligne";
//            string aut_texte = "Ceci\nitou, genre";
//            Box b0 = new Box(texte);
//            Box b1 = new Box(aut_texte);
//            Box.Display(b0);
//            Box.Display(b1);
//            VerticalBox cv = new VerticalBox(b0, b1);
//            Box.Display(new Box(cv));
//            HorizontalBox ch = new HorizontalBox(b0, b1);
//            Box.Display(new Box(ch));
//            VerticalBox cvplus = new VerticalBox(new Box(cv), new Box(ch));
//            Box.Display(new Box(cvplus));
//            HorizontalBox chplus = new HorizontalBox(new Box(cv), new Box(ch));
//            Box.Display(new Box(chplus));
//            VerticalBox cvv = new VerticalBox(new Box(chplus), new Box("coucou"));
//            Box.Display(new Box(cvv));
//            Box.Display(new Box(
//               new HorizontalBox(
//                  new Box("a\nb\nc\nd\ne"),
//                     new Box(
//                        new VerticalBox(
//                           new Box("allo"), new Box("yo")
//                        )
//                     )
//                  )
//               )
//            );
//            Box.Display(
//               new Box(new HorizontalBox(new Box("Yo"), new Box()))
//            );
//            Box.Display(
//               new Box(new HorizontalBox(new Box(), new Box("Ya")))
//            );
//            Box.Display(
//               new Box(new HorizontalBox(new Box(), new Box()))
//            );
//            Box.Display(
//               new Box(new VerticalBox(new Box(), new Box()))
//            );
//            Box.Display(
//               new Box(new VerticalBox(new Box("Yip"), new Box()))
//            );
//            Box.Display(
//               new Box(new VerticalBox(new Box(), new Box("Yap")))
//            );
//        }
//    }
//}