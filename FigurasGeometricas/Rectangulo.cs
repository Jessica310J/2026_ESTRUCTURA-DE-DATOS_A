using System;

namespace FigurasGeometricas
{
    // La clase Rectangulo usa la base y la altura.
    public class Rectangulo
    {
        // === ENCAPSULACIÓN: Tipos de datos primitivos (double) ===
        private double baseRectangulo;
        private double altura;

        // Propiedad pública para acceder a la Base.
        public double BaseRectangulo
        {
            get { return baseRectangulo; }
            set { baseRectangulo = value; }
        }

        // Propiedad pública para acceder a la Altura.
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        // Constructor
        public Rectangulo(double baseR, double alturaR)
        {
            this.BaseRectangulo = baseR;
            this.Altura = alturaR;
        }

        // === MÉTODOS DE CÁLCULO ===

        // CalcularArea: calcula el área (Base * Altura).
        public double CalcularArea()
        {
            return BaseRectangulo * Altura;
        }

        // CalcularPerimetro: calcula el perímetro (2 * Base + 2 * Altura).
        public double CalcularPerimetro()
        {
            return 2 * (BaseRectangulo + Altura);
        }
    }
}