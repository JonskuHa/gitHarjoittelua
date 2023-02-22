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
        }
    }
}