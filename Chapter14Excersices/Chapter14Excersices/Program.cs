using System;
using System.Threading;

namespace Chapter14Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone.Display display = new Phone.Display(40, "Black");
            Phone.Battery battery = new Phone.Battery(BatteryType.NiMH, 10, 14);

            Phone phone = new Phone("Iphone", "Apple", 1000, "Me", BatteryType.NiCd, 14, 12, 14, "Black");
            Phone iphone = new Phone("IPhone", "Apple", 1000, "Me");
            Phone.Display display1 = new Phone.Display(14, "White");
            Phone.PrintPhoneInfo(Phone.NokiaN95);
            Phone.Battery battery1 = new Phone.Battery(BatteryType.LiIon, 14, 15);
            Phone.PrintPhoneInfo(iphone);
            Console.WriteLine(battery1.BatteryModel);
            Phone phone1 = new Phone("Samsun", "Samsung", 1440, "Me", battery1, display1);
            Phone.PrintPhoneInfo(phone1);
            Phone.NokiaN95.

            phone.Call("Gogo1");
            phone.EndCall();
            phone.Call("Gogo2");
            phone.EndCall();
            phone.Call("Gogo3");
            phone.EndCall();
            phone.Call("Gogo4");
            phone.EndCall();
            phone.Call("Gogo5");
            phone.EndCall();
            phone.DeleteCall(3);
            Phone.PrintCalls(phone);
            Phone.PrintTax(phone, 1);
            phone.PayTax();
        }
    }
}
