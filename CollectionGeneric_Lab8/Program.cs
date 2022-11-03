namespace CollectionGeneric_Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating 5 objects of the Employee-class
            var emp1 = new Employee("Thanos", "Male", 25000);
            var emp2 = new Employee("Wanda", "Female", 26000);
            var emp3 = new Employee("Thor", "male", 22000);
            var emp4 = new Employee("Hulk", "Male", 29000);
            var emp5 = new Employee("Doctor Strange", "Male", 26000);

            //Creating a stack of type Employee
            var employees = new Stack<Employee>();

            //Adding the 5 objects to the stack using Push-method.
            employees.Push(emp1);
            employees.Push(emp2);
            employees.Push(emp3);
            employees.Push(emp4);
            employees.Push(emp5);

            Console.WriteLine("Utskrift av objekten med hjälp av ToString-metoden:\n");

            //Looping through the stack
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
                Console.WriteLine("Antal artiklar i stacken: {0}\n", employees.Count());
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Hämtad med hjälp av Pop-metoden:\n");

            //Using Pop method to remove items from the stack.
            while (employees.Count > 0)
            {
                Console.WriteLine(employees.Pop());
                Console.WriteLine("Antal artiklar i stacken: {0}\n", employees.Count);
            }

            //Adding the items back to the stack.
            employees.Push(emp1);
            employees.Push(emp2);
            employees.Push(emp3);
            employees.Push(emp4);
            employees.Push(emp5);

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Hämtad med hjälp av Peek-metoden:\n");

            //Peeking through the last 2 objects in the stack.
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(employees.Peek());
                Console.WriteLine("Antal artiklar i stacken: {0}\n", employees.Count);
            }

            Console.WriteLine("-----------------------------------");

            //Checking to see if "emp3" is in the stack.
            Console.WriteLine(employees.Contains(emp3) ? "Emp3 finns med i stacken." : "Emp3 finns inte med i stacken.");

            //Creating a list and copying over the content of the stack "employees".
            var employeesList = new List<Employee>(employees);

            Console.WriteLine("-----------------------------------");

            Employee x = emp5;
            Console.WriteLine(employeesList.Contains(x) ? x.Name + " är med i listan!" : "Den anstälde finns inte med i listan.");

            Console.WriteLine("-----------------------------------");

            //Since we created the list "employeesList" from a stack,
            //the order of the list is from last to first.
            //The value we get here is the top in the List but it should be the last in the Stack.
            Console.WriteLine(employeesList.Find(f => f.Gender == "Male"));

            Console.WriteLine("-----------------------------------");

            //FindAll returns a list which is copied over to "item" and then printed out.
            foreach (var item in employeesList.FindAll(f => f.Gender == "Male"))
            {
                Console.WriteLine(item);
            }
        }
    }
}