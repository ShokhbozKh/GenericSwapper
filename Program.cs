namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=1, b=2;

            Console.WriteLine($"a:{a}  b:{b}");
            

            Swapper<int>.Swap(ref a,ref b);
            Console.WriteLine($"a:{a}  b:{b}");

        }
    }

    class Swapper<T>
    {
        public static void Swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;


        }

    }
    

    static class Amallar<T>
    {
        public static T Plas(T a, T b)
        {
            return (dynamic)a + (dynamic)b;

        }
    }

    
}