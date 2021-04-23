using System;

namespace EventExample

{ 
class Button
    {
        public delegate void Notify(string address, string message);

        public event Notify Clicked;

         public static void Click(string address, string message)
    {
        Console.WriteLine($"sending Email to {address} with message {message}");
    }



    }


class Program
    {
    

    static void Main(string[] args)
        {
        var instance = new Button();

         instance.Clicked += Button.Click;

         Button.Clicked("info@devskill.com", "Hello World");


        }
   






}
}
