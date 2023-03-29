// Hello World! program
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            var a = new RekursiivinenKertomaLaskuri();
            var kertoma = a.LaskeKertoma(5);
            Console.WriteLine(kertoma);
            Console.ReadLine();
            var a = new Kertoma();
            Console.WriteLine(a.LaskeKertoma(3));
            Console.ReadLine();

        }
    }
}