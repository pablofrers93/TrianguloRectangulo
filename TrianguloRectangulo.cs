using System;
namespace TrianguloRectangulo
{
    public class TrianguloRectangulo
    {

        public double cateto1 { get; set; }
        public double cateto2 { get; set; }
        public double hipotenusa { get; set; }


        // Verifica que (CatetoA^2) + (CatetoB^2) = (Hipotenusa^2)
        private bool ValidarTriangulo(double catetoA, double catetoB, double Hipotenusa)
        {
            return Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2) == Math.Pow(Hipotenusa,2);
        }

        public TrianguloRectangulo()
        {
            
        }

        // Si valida que es un triangulo rectangulo calcula el perimetro sino devuelve 0.
        // Como se usa varias veces lo hice como métod aparte y usarlo cada vez que se necesita
        // para no repetir el código...
        private double InformaPerimetro()
        {
            if (ValidarTriangulo(this.cateto1, this.cateto2, this.hipotenusa))
                return this.cateto1 + this.cateto2 + this.hipotenusa;
            else
                return 0;
        }

        // Comprueba en cual de los 4 escenarios se encuentra para luego calcular, si es necesario,
        // el lado faltante y retornar el perimetro haciendo uso del métod InformaPerimetro()
        public double GetPerimetro()
        {

            if (this.cateto1 > 0 && this.cateto2 == 0 && this.hipotenusa > 0)
            {
                this.cateto2 = Math.Sqrt(Math.Pow(this.hipotenusa, 2) - Math.Pow(this.cateto1, 2));
                return InformaPerimetro();
            }

            else if (this.cateto1 == 0 && this.cateto2 > 0 && this.hipotenusa > 0)
            {
                this.cateto1 = Math.Sqrt(Math.Pow(this.hipotenusa, 2) - Math.Pow(this.cateto2, 2));
                return InformaPerimetro();
            }
            else if (this.cateto1 > 0 && this.cateto2 > 0 && this.hipotenusa == 0)
            {
                this.hipotenusa = Math.Sqrt(Math.Pow(this.cateto1, 2) + Math.Pow(this.cateto2, 2));
                return InformaPerimetro();
            }
            else return InformaPerimetro();
        }

        // El área de un triángulo rectángulo es igual al producto de los catetos partido por 2.
        public double GetSuperficie()
        {
            if (this.cateto1 == 0)
            {
                this.cateto1 = Math.Sqrt(Math.Pow(this.hipotenusa, 2) - Math.Pow(this.cateto2, 2));
                return (this.cateto1*this.cateto2) / 2;
            }
            else  if (this.cateto2 == 0)
            {
                this.cateto2 = Math.Sqrt(Math.Pow(this.hipotenusa, 2) - Math.Pow(this.cateto1, 2));
                return (this.cateto1 * this.cateto2) / 2;
            }

            else return (this.cateto1 * this.cateto2) / 2; 
        }
    }
}
