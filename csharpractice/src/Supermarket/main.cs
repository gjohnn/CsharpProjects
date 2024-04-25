namespace csharpractice;

public class main
{
    static void Main(string[] args)
    {
        Console.Write("Enter first name:");
        string firstName = Console.ReadLine();
        Console.Write("Enter last name:");

        string lastName = Console.ReadLine();

        Console.Write("Enter age:");

        int nashe = 2;

        int age = int.Parse(Console.ReadLine());

        Market market = new Market("Nashe");

        Console.WriteLine("Are you employee?");
        string response = Console.ReadLine();
        bool isEmployee = response.ToLower().Equals("yes");

        if (isEmployee)
        {
            int option;
            Employee employee = new Employee(firstName,age,lastName);
            Console.WriteLine("-- Empleado --");
            employee.getInfo();
            bool action = true;
            while (action)
            {
                Console.WriteLine("1) Show products");
                Console.WriteLine("0) Exit");
                Console.Write("Choose operation: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        // show products
                        market.showProducts();
                        break;
                    case 0:
                        action = false;
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("Select a valid operation!");
                        break;
                }
            }
        }

        if (!isEmployee)
        {
            Client person = new Client(firstName,age,lastName);
            Console.WriteLine("Welcome "+person.first_name+ " to market "+market.name);
        }
    }
}