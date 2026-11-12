using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3.Abstractfactory
{
    public interface Closet
    {
        void Place();
    }
    public interface Table
    {
        void Place();
    }
    //конкретные продукты в совремнном стиле
    public class ModernCloset: Closet
    {
        public void Place() => Console.WriteLine("Modern closet");
    }
    public class ModernTable : Table
    {

        public void Place() => Console.WriteLine("Modern table ");
    }
    // конкретные продукты в готическом стиле
    public class Gothiccloset : Closet
    {
        public void Place() => Console.WriteLine("Gothic closet.");
    }

    public class GothicTable :Table
    {
        public void Place() => Console.WriteLine("Gothic table");
    }
    public interface Furnfactory
    {
        Closet Createcloset();
        Table Createtable();

    }

    public class ModernFactory: Furnfactory
    {
        public Closet Createcloset() => new ModernCloset();
        public Table Createtable() => new ModernTable();
    }
    public class GothicFactory: Furnfactory
    {
        public Closet Createcloset() => new Gothiccloset();
        public Table Createtable() => new GothicTable();
    }
    public class Room
    {
        private readonly Closet closet;
        private readonly Table table;
        public Room(Furnfactory factory)
        {
            closet = factory.Createcloset();

            table = factory.Createtable();
        }


        public void Place()
        {
            closet.Place();
            table.Place();
        }
    }

}
