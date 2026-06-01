using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Me = new User { name = "Bob", RegistrationDate = "1998" };

            Me.PrintInfo();

           // Me.RegistrationDate = "1999";

            Me.name = "John";

            Me.PrintInfo();

            

        }
    }
}
