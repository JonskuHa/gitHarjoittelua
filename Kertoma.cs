using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld;

public class Kertoma
{
    public int LaskeKertoma(int luku)
    {
        if (luku == 1)
        {
            return luku;}

        return luku * LaskeKertoma(luku - 1);
    }
}