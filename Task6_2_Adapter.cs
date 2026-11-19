using System;

namespace AdapterExample
{
    interface IEuropeanSocket
    {
        void ConnectRoundPlugs();
    }

    class AmericanPlug
    {
        public void ConnectFlatPlugs()
        {
            Console.WriteLine("Підключено американську плоску вилку (110 V)");
        }
    }

    class PlugAdapter : IEuropeanSocket
    {
        private AmericanPlug plug;
        public PlugAdapter(AmericanPlug plug) { this.plug = plug; }
        public void ConnectRoundPlugs()
        {
            Console.WriteLine("Адаптер: перетворюю круглі штирі на плоскі...");
            plug.ConnectFlatPlugs();
        }
    }

    public class AdapterTask
    {
        public static void Run()
        {
            AmericanPlug plug = new AmericanPlug();
            IEuropeanSocket socket = new PlugAdapter(plug);
            socket.ConnectRoundPlugs();
        }
    }
}