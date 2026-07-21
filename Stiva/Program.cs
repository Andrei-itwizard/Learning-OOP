
namespace Stack_with_oop
{
    internal class Program
    {   
        static void Main(string[] args)
        {  
            Stiva stiva = new Stiva(10);

            stiva.Push(23);
            stiva.Push(45);
            stiva.Push(12);

            stiva.Pop();
            stiva.Peek(); 
            stiva.Pop();
            stiva.Peek(); 
        }
    }
}
