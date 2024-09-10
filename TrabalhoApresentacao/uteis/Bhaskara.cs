using System;

namespace TrabalhoApresentacao.uteis
{
    public static class Bhaskara
    {
        //calcular as raízes da equação
        public static (bool sucesso, double raiz1, double raiz2) CalcularRaizes(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            //verifica se as raízes são reais
            if (delta < 0)
            {
                return (false, 0, 0); //não há raízes reais
            }

            //calcula as raízes
            double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

            return (true, raiz1, raiz2);
        }
    }
}