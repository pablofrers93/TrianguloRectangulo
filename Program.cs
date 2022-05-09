using System;

namespace TrianguloRectangulo   
{
    class Program
    {
        static void Main(string[] args)
        {
            TrianguloRectangulo miTriangulo = new TrianguloRectangulo();

            miTriangulo.cateto1 = 9;
            miTriangulo.cateto2 = 0;
            miTriangulo.hipotenusa = 15;

            Console.WriteLine($"El perimetro es: {miTriangulo.GetPerimetro()}");
            Console.WriteLine($"La superficie es: {miTriangulo.GetSuperficie()}");
            Console.ReadKey();
        }
    }
}
