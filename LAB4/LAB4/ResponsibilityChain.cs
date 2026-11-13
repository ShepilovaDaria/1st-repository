using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4
{
    public enum Alert //разные сигналы с датчиков
    {
        Waterleak,
        Smoke,
        Break_in
    }
    public class  Event // событие для цепочки
    {
        public Alert alert { get; }
        public Event(Alert type) {alert = type; }
    }
    //интерфейс модуля ьезопасности
    public interface Security 
    {
        void Processevent(Event sensorevent);
        void SetnextM(Security nextmodule);
    }

    public class WaterShutoff: Security //модуль перекрытия воды
    {
        private Security nextmodule;

        public void Processevent(Event sensorevent)
        {
            if (sensorevent.alert == Alert.Waterleak)
                Console.WriteLine("WaterShutoff: перекрытие подачи воды");
            else if (nextmodule != null)
                nextmodule.Processevent(sensorevent);
            else
                Console.WriteLine($"Пропущен сигнал {sensorevent.alert}. ");
        }
        public void SetnextM(Security nextm) => nextmodule = nextm;
    }
    public class Firefight :  Security //модуль тушения пожара
    {
        private Security nextmodule;

        public void Processevent(Event sensorevent)
        {
            if (sensorevent.alert == Alert.Smoke)
                Console.WriteLine("Firefight: включение противопожарной системы");
            else if (nextmodule != null)
                nextmodule.Processevent(sensorevent);

            else
                Console.WriteLine($"Пропущен сигнал {sensorevent.alert}.");
        }

        public void SetnextM(Security nextm) => nextmodule = nextm;
    }

    public class Guardcall: Security //Модуль вызова охраны
    {
        private Security nextmodule;
        public void Processevent(Event sensorevent)
        {
            if (sensorevent.alert == Alert.Break_in)
                Console.WriteLine("Guardcall: включение сирены и вызов охраны.");
            else if (nextmodule != null)
                nextmodule.Processevent(sensorevent);
            else
                Console.WriteLine($"Пропущен сигнал {sensorevent.alert}.");
        }

        public void SetnextM(Security nextm) => nextmodule = nextm;
    }
}
