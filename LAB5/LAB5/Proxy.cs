using System;
using System.Collections.Generic;
using System.Text;

namespace LAB5
{
    public interface Videoservice
    {
        void Watchvid(string t);
    }
    public class RealVS: Videoservice
    {
        public void Watchvid(string t)
        {

            Console.WriteLine("Playing video:" + t);
        }
    }

    public class VSProxy :  Videoservice
    {
        private readonly RealVS realVS;

        private readonly bool hassub;
        public VSProxy(bool hassub_)
        {
            realVS = new RealVS();
            hassub = hassub_;
        }
        public void Watchvid(string title)
        {
            if (hassub)
            {

                realVS.Watchvid(title);
            }
            else
            {
                Console.WriteLine("No access:You need subscription to watch. ");

            }
        }
    }
}
