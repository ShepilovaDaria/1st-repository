using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3.Singleton
{
    public class AppSettinngs
    {
        private static AppSettinngs instance;//  поле с экземпляром
        public string Theme { get; set; }
        public string Language { get; set; }
        private AppSettinngs()   //приватный конструктор
        {
            Theme = "Dark";
            Language = "Serbian";
        }
        public static AppSettinngs Instance
        {
            get
            {
                if (instance == null)
                    instance = new AppSettinngs();
                return instance;
            }
        }
        public void Print()
        {
            Console.WriteLine($"Theme: {Theme}, Language: {Language}");
        }
    }
}
