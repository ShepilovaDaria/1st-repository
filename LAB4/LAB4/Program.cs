namespace LAB4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy");


            Searcher s = new Searcher();
            int[] array = {2,5, 8,12, 19,23,98};
            int t = 23;
            Console.WriteLine("Массив: " + string.Join(", ", array));
            s.Setstrategy(new Linearsearch());

            int i1 = s.FindEl(array, t);
            Console.WriteLine($" Индекс элемента {t} :{i1}");

            s.Setstrategy(new Binarysearch());

            int i2 = s.FindEl(array, t);
            Console.WriteLine($"Индекс элемента {t}: {i2}.");
            Console.WriteLine();


            Console.WriteLine("Responsibility chain");

            Security waterM = new WaterShutoff();
            Security fireM = new Firefight();
            Security guardM = new Guardcall();
            waterM.SetnextM(fireM);
            fireM.SetnextM(guardM);
            waterM.Processevent(new Event(Alert.Waterleak));

            waterM.Processevent(new Event(Alert.Smoke));
            waterM.Processevent(new Event(Alert.Break_in));
            Console.WriteLine(); 


            Console.WriteLine("Iterator");

            List<string> tracks = new List<string> {"Bohemian Rhapsody", "Overdose", "Город под подошвой", "The world we knew", "Stressed Out"};
            Playlist_<string> playlist = new Playlist_<string>(tracks);
            Iterator<string> iterator = playlist.CreateIterator();
            while (iterator.Hasnext())
            {
                Console.WriteLine(iterator.Next());
            }

            Console.WriteLine();
        }
    }
}
