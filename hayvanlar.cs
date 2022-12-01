using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public  class hayvanlar:canlilar
    {
        protected  void adaptasuon()
        {
            Console.WriteLine("hayvanlar adaptasyon ozelligi gosterirler.");
        }


    }

    public class surungenler:hayvanlar
    {
        public surungenler()
        {
            base.adaptasuon();
            base.beslenme();
            base.bosaltim();
            base.solunum();
        }
        public void surunerekHareketEtmek()
        {
            Console.WriteLine("surungenler surunerek hareket eder .");
        }
    }

    public class kuslar:hayvanlar
    {
        public kuslar()
        {
            base.adaptasuon();
            base.beslenme();
            base.bosaltim();
            base.solunum();
        }
        public void ucmak()
        {
            Console.WriteLine("kuslar ucarak hareket eder.");
        }
    }
   
}
