namespace LAB5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunProxy();
            Console.WriteLine();

            RunAdapter();
            Console.WriteLine();
            RunBridge();
        }
        private static void RunProxy()
        {

            Console.WriteLine("Proxy");

            Videoservice freeuser = new VSProxy(false);
            Videoservice vipuser = new VSProxy(true);
            freeuser.Watchvid("49 минут, которые ИЗМЕНЯТ ваше понимание Вселенной");
            vipuser.Watchvid("49 минут, которые ИЗМЕНЯТ ваше понимание Вселенной");
        }

        private static void RunAdapter()
        {
            Console.WriteLine("Adapter");
            Oldprinter oldprinter = new Oldprinter();
            Printer printer = new Printeradapter(oldprinter);
            printer.Print("Доклад Кант");
        }
        private static void RunBridge()
        {
            Console.WriteLine("Bridge");
            Presentationtype screen = new Screendisplay();
            Presentationtype sound = new Audioguide();
            Exhibit paint_screen = new Painting(screen);
            Exhibit paint_sound = new Painting(sound);
            paint_screen.Showinf("Girl with Peaches");
            paint_sound.Showinf("Girl with Peaches");
            Exhibit sculptureOnScreen = new Sculpture(screen);
            sculptureOnScreen.Showinf("Le Penseur");
        }
    }
}
