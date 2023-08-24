using System.Runtime.Intrinsics.Arm;

namespace ObserverDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a Product with Out of Stock Status
            Subject Redmi = new Subject("Redmi Mobile", 10000, "Out Of Stock");

            //User will be created and the user1 object will be registered to the subject
            Observer user1 = new Observer("Anurag");
            user1.AddSubscriber(Redmi);

            Observer user2 = new Observer("Pranaya");
            user2.AddSubscriber(Redmi);

            Observer user3 = new Observer("Priyanka");
            user3.AddSubscriber(Redmi);

            Console.WriteLine("Redmi Mobile current state : " + Redmi.GetAvailability());
            Console.WriteLine();

            user3.RemoveSubscriber(Redmi);

            // Now the product is available
            Redmi.SetAvailability("Available");
            Console.Read();
        }

    }
}