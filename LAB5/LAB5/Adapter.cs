using System;
using System.Collections.Generic;
using System.Text;

namespace LAB5
{
    public class Oldprinter 
    {
        public void Printdoc(string text)
        {
            Console.WriteLine("Old printer printing: " + text);

        }


    }
    public interface Printer // target
    {
        void Print(string doc);
    }

    public class Printeradapter: Printer 
    {

        private readonly Oldprinter prev_printer;
        public Printeradapter(Oldprinter printer)
        {
            prev_printer = printer;
        }

        public void Print(string document)
        {
            prev_printer.Printdoc(document);
        }
    }

}
