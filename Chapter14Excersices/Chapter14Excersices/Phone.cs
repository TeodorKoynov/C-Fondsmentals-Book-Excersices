using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Chapter14Excersices
{
    class Phone
    {
        private string model;
        private string manifactuor;
        private int price;
        private string owner;
        private Battery battery;
        private Display display;
        private static Phone nokiaN95 = new Phone("Nokia N95", "Microsoft", 100, "You", BatteryType.NiMH, 14, 14, 40, "Black");
        private List<Call> calls = new List<Call>();
        private int callIndex = 0;
        private List<Call> autheniticCalls = new List<Call>();
        private List<Call> HistoryOfCalls = new List<Call>();
        private bool inCall = false;
        private int tax = 0;

        public static Phone NokiaN95
        {
            get
            {
                return nokiaN95;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }
        public string Manifactuor
        {
            get
            {
                return this.manifactuor;
            }
        }
        public int Price
        {
            get
            {
                return this.price;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
        }
        // TO DO Method Change Battery
        public Battery TheBattery
        {
            get
            {
                if(battery == null)
                {
                    throw new NullReferenceException("The Phone does not have a battery!");
                }
              
                return this.battery;
            }
        }
        // TO DO Method Change Display
        public Display TheDsplay
        {
            get
            {
                if (display == null)
                {
                    throw new NullReferenceException("The Phone does not have a battery!");
                }
                return this.display;
            }
        }
       
        // Classes
        public class Battery
        {
            private BatteryType batteryModel;
            private int idleTime;
            private int hoursTalk;

            public BatteryType BatteryModel
            { 
                get
                {
                    return this.batteryModel;
                }
            }
            public int IdleTime
            { 
                get
                {
                    return this.idleTime;
                }
            }
            public int HoursTalk
            {
                get
                {
                    return this.hoursTalk;
                }
            }

            public Battery(BatteryType batteryType, int idleTime, int hoursTalk)
            {
                this.batteryModel = batteryType;
                this.idleTime = idleTime;
                this.hoursTalk = hoursTalk;
            }
        }

        public class Display
        {
            private int size;
            private string color;

            public int Size
            {
                get
                {
                    return this.size;
                }
            }
            public string Color
            { 
                get
                {
                    return this.color;
                }
            }

            public Display(int size, string color)
            {
                this.size = size;
                this.color = color;
            }
        }
        
        // Constructors for Phone

        public Phone(string model, string manifactuor, int price, string owner, BatteryType batteryType, int idleTime, int hoursTalk, int size, string color)
        {
            this.model = model;
            this.manifactuor = manifactuor;
            this.price = price;
            this.owner = owner;
            battery = new Battery(batteryType, idleTime, hoursTalk);
            display = new Display(size, color);
        }

        public Phone(string model, string manifactuor, int price, string owner)
        {
            this.model = model;
            this.manifactuor = manifactuor;
            this.price = price;
            this.owner = owner;
            this.battery = null;
            this.display = null;

        }

        public Phone(string model, string manifactuor, int price, string owner, Battery battery, Display display)
            :this(model, manifactuor, price, owner)
        {
            this.battery = battery;
            this.display = display;
        }

        // Phone Methods
        public static void PrintPhoneInfo(Phone phone)
        {
            if (phone.battery == null && phone.display == null)
            {
                Console.WriteLine($"{phone.model}{phone.manifactuor}{phone.price}{phone.owner} With battery: No battery, With Display: No display");
                return;
            }
            else if (phone.battery == null)
            {
            Console.WriteLine($"{phone.model}{phone.manifactuor}{phone.price}{phone.owner} With battery: No battery, With Display: {phone.display.Size}{phone.display.Color}");
                return;
            }
            else if(phone.display == null)
            {
                Console.WriteLine($"{phone.model}{phone.manifactuor}{phone.price}{phone.owner} With battery: {phone.battery.BatteryModel}{phone.battery.HoursTalk}{phone.battery.IdleTime} With Display: No display");
                return;
            }
            else
            {
                Console.WriteLine($"{phone.model}{phone.manifactuor}{phone.price}{phone.owner} With battery: {phone.battery.BatteryModel}{phone.battery.HoursTalk}{phone.battery.IdleTime}  With Display: {phone.display.Size}{phone.display.Color}");
                return;
            }
        }

        // TODO Better logic for the TimeCall To use Call and EndCall
        public void Call(String callPerson)
        {
            // TODO Better logic for the TimeCall To use Call and EndCall
            if(inCall == true)
            {
                throw new Exception("You are in Call. Can NOT use Call!");
            }
            Random rnd = new Random();
            int number = rnd.Next(0, 10);
            this.calls.Add(new Call(callPerson, DateTime.Today, DateTime.Now, number));
            callIndex++;
            this.autheniticCalls.Add(new Call(callPerson, DateTime.Today, DateTime.Now, number));
            inCall = true;
            this.HistoryOfCalls.Add(new Call(callPerson, DateTime.Today, DateTime.Now, number));
            inCall = true;

        }
        
        public void EndCall()
        {
            inCall = false;
        }

        public void DeleteCall(int number)
        {
            if (calls[number - 1] != null)
            {
                calls[number - 1] = null;
                for (int i = number - 1; i < calls.Count - 1; i++)
                {
                    calls[i] = calls[i + 1];
                }
                calls.Remove(calls[calls.Count - 1]);
            }


        }

        public void DeleteAllCall()
        {
            calls.RemoveRange(0, calls.Count);
        }

        public static void PrintCalls(Phone phone)
        {
            if(phone.calls.Count == 0)
            {
                Console.WriteLine("The CallBox is Empty!");
                return;
            }
            int callNumber = 1;
            foreach(Call call in phone.calls)
            {
                Console.WriteLine($"Call Number: {callNumber} Call To {call.CallerName} {call.Date.Day}.{call.Date.Month}.{call.Date.Year}  {call.StartTime.Hour}:{call.StartTime.Minute} {call.TimeCall}");
                callNumber++;
            }
            
        }

        public static void PrintTax(Phone phone, int callPrice)
        {
            int sum = 0;
            int minutes = 0;
            foreach(Call call in phone.autheniticCalls)
            {
                minutes += call.TimeCall;
            }
            sum = minutes * callPrice;
            phone.tax = sum;
            Console.WriteLine("The tatal cost of All the calls is: {0}", sum);
        }

        public void PayTax()
        {
            tax = 0;
            Console.WriteLine("The tax has been paid. Thank you!");
            autheniticCalls.RemoveRange(0, autheniticCalls.Count);
        }
    }
}
