namespace LABB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Archer lenya = new Archer("Лёня", 0, 0, 90, 30, 4);
            Archer kostya = new Archer("Костя", 1, 1, 75, 25, 3);
            MobileHome cart = new MobileHome("Дом", 2, 2, 1);
            Fort fort = new Fort("Крепость", 5, 5, 2, 70, 17);

            // начальное состояние
            Console.WriteLine(lenya);
            Console.WriteLine(kostya);
            Console.WriteLine(cart);
            Console.WriteLine(fort);
            Console.WriteLine();

            // постройка крепости
            fort.OnTurn();
            fort.OnTurn();

            // постройка дома и он едет
            cart.OnTurn();
            cart.MoveTo(10, 10);
            Console.WriteLine("Дом: " + cart.GetX() + "," + cart.GetY());

            // атака лучника
            lenya.Attack(kostya);
            Console.WriteLine("HP Кости: " + kostya.GetHp());

            lenya.MoveTo(3, 0);
            Console.WriteLine("Лёня: " + lenya.GetX() +"," + lenya.GetY());
            //крепость стреляет
            fort.Attack(lenya);
            Console.WriteLine("HP Лёни: " + lenya.GetHp());


            // убиваем лучника
            lenya.ReceiveDamage(200);
            Console.WriteLine("Лёня остался в живых?" + lenya.IsAlive());
            lenya.MoveTo(1, 1);   
            Console.WriteLine("Лёня: " + lenya.GetX() + ","+ lenya.GetY());
        }
    }
}
