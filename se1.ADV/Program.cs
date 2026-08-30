using System.Net.Http.Headers;

namespace se1.ADV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*1)A generic class:is a class designed with a placeholder for the data type it operates on,
             * rather than being bound to a specific type. You define it using a type parameter (commonly <T>),
             * allowing the actual data type to be specified when the class is instantiated.
             * Using generics : type safety, code reusability, better performance and cleaner code.
             */
            #endregion
            #region Q2
            //Container<int> C1 = new Container<int>();
            //C1.Add(22);
            //Console.WriteLine(C1.Get());
            //Container<string> C2 = new Container<string>();
            //C2.Add("Hello");
            //Console.WriteLine(C2.Get());
            #endregion
            #region Q3
            /*Multiple Type Parameter: A generic class can have more than one type parameter.
             */
            //var student = new Pair<int, string>(22, "Ahmed");
            //student.PrintPair();
            //var product = new Pair<string, double>("Laptop", 12.430);
            //product.PrintPair();
            #endregion
            #region Q4
            /*Generic Method: is a method declared with type parameters (<T>) inside either a generic or a non-generic class.
             */
            //int a = 1;
            //int b = 2;
            //Swaping.swap<int>(ref a, ref b);
            //Swaping.swap(ref a, ref b);
            //Swaping.Test();

            #endregion
            #region Q5
            //int maxInt = Utility.FindMax(15, 42);
            //Console.WriteLine(maxInt); 
            //string maxString = Utility.FindMax("Apple", "Zebra");
            //Console.WriteLine(maxString); 
            #endregion
            #region Q6

            #endregion
            #region Q7
            /*The struct constraint (where T : struct) restricts the generic type parameter T to be a non-nullable value type 
             * (such as int, double, bool, char, or any user-defined struct).
             * This prevents passing reference types (like string or class) 
             * or nullable value types (like int?) as type arguments.
             */
            //var wrapper = new ValueWrapper<int>(100);
            //wrapper.PrintData();
            //var dateWrapper = new ValueWrapper<DateTime>(DateTime.Now);
            #endregion
            #region Q8
            //Inventory<string> I3 = new Inventory<string>("");
            #endregion
            #region Q9
            /*The new() constraint (where T : new()) specifies that a generic type argument T must have a public parameterless constructor (a default constructor).
             * This allows you to instantiate new objects of type T inside the generic class or method using new T().
             */
            //var carFactory = new Factory<Car>();
            //Car myCar = carFactory.CreateInstance();
            #endregion
            #region Q10
            //Printer<Document> Test = new Printer<Document>();
            //Test.PrintItem(new Document());
            #endregion
            #region Q11
            //var dogHandler = new PetHandler<Dog>();
            //var myDog = new Dog { Name = "Rex" };
            //dogHandler.Handle(myDog);
            #endregion
            #region Q12
            //Repository<Order> orderRepo = new Repository<Order>();
            //Order myOrder = orderRepo.Create();
            //myOrder.ID = 101;
            //Console.WriteLine($"Order ID: {myOrder.ID}");
            //myOrder.Audit();
            #endregion
            #region Q13
            /*The default keyword in generics returns the default value of a given type parameter T. It is essential because, at compile time, C# does not know whether T will be a reference type or a value type.
             * For reference types (e.g., string, class), default(T) returns null.
             * For numeric value types (e.g., int, double), it returns 0.
             * For boolean value types, it returns false.
             * For structs, it returns a struct with all its fields set to their default values.
             */
            //var numbers = new SafeList<int>();
            //numbers.Add(10);
            //numbers.Add(20);
            //Console.WriteLine(numbers[0]);  
            //Console.WriteLine(numbers[5]);  
            //Console.WriteLine(numbers[-1]); 
            //var names = new SafeList<string>();
            //names.Add("Alice");
            //Console.WriteLine(names[0]);                  
            //Console.WriteLine(names[3] == null ? "Null" : names[3]);
            #endregion
        }
    }
}
