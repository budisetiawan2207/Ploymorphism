using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class PrinterWindows
    {
        public string name { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("IKI BAKAL KETIMPA KARO SHOW LE NENG EPSON, CANON, LaserJet");
        }
         public  virtual void Print()
        {
            Console.WriteLine("IKI BAKAL KETIMPA KARO PRINT LE NENG EPSON, CANON, LaserJet");
        }
    }
}
