using System.Security.Cryptography.X509Certificates;

namespace HelloWorld;

public class Kertoma
{
    public int LaskeKertoma(int luku)
    {
        int tulos = 0;
        if (luku > 0)
        {
            tulos = tulos * luku;
            LaskeKertoma(luku - 1);
        }
        return tulos;
    }
}