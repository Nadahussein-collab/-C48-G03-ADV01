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
        }
    }
}
