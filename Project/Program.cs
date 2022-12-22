using APM.SL;
using System;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();
            System.Console.WriteLine($" Margin = {product.CalculateMargin(priceInput: "1000", costInput: "500")}");

            var util = Utility.SendEmail(subject: "Day Metting", recipient: "Mohamed", body: "waiting you", sendDate: DateTime.Now, saveCopy: true);
            System.Console.WriteLine($"Mail Details = {util}");
        }
    }
}
