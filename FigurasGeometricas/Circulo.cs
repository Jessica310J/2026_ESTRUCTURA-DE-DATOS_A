
using System;

namespace FigurasGeometricas
{
    // La clase Circulo usa el radio como su única dimensión.
    public class Circulo
    {
        // === ENCAPSULACIÓN: Tipo de dato primitivo (double) ===
        private double radio;

        // Propiedad pública 'Radio' que encapsula el campo privado.
        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        // Constructor
        public Circulo(double radio)
        {
            this.Radio = radio;
        }

        // === MÉTODOS DE CÁLCULO ===

        // CalcularArea: función que calcula el área del círculo (π * Radio²).
        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        // CalcularPerimetro (Circunferencia): función que calcula el perímetro (2 * π * Radio).
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}