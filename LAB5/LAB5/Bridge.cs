using System;
using System.Collections.Generic;
using System.Text;

namespace LAB5
{
    public interface Presentationtype 
    {
        void Present(string inf);
    }
    public class Screendisplay :Presentationtype 
    {
        public void Present(string inf)
        {
            Console.WriteLine("Playing on museum screen:" + inf);

        }
    }

    public class Audioguide: Presentationtype 
    {

        public void Present(string inf)
        {
            Console.WriteLine("Playing in museum audio guide: "+ inf);
        }
    }
    public abstract class Exhibit 
    {
        protected readonly Presentationtype presentation;
        protected Exhibit(Presentationtype pr)
        {
            presentation = pr;
        }

        public abstract void Showinf(string t);
    }
    public class Painting: Exhibit 
    {
        public Painting(Presentationtype pr) : base(pr) { }
        public override void Showinf(string t)
        {
      
            presentation.Present("Painting -'" + t + "'");
        }

    }

    public class Sculpture : Exhibit
    {
        public Sculpture(Presentationtype pr) : base(pr) { }

        public override void Showinf(string t)
        {
            presentation.Present("Sculpture '" + t+ "'");
        }
    }

}
