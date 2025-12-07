using System;

namespace FigurasGeometricas
{
    public class Program
    {
        // El método Main es donde comienza la ejecución del programa.
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Deber POO: Cálculo de Área y Perímetro ---");
            Console.WriteLine("-------------------------------------------\n");

            // 1. Prueba de la clase Rectángulo
            // Creamos una instancia y usamos las propiedades encapsuladas (get/set)
            Rectangulo miRectangulo = new Rectangulo(120.0, 20.0);
            
            Console.WriteLine("== PRUEBA: RECTÁNGULO ==");
            Console.WriteLine($"Base: {miRectangulo.BaseRectangulo}, Altura: {miRectangulo.Altura}");
            
            Console.WriteLine($"Área Calculada: {miRectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro Calculado: {miRectangulo.CalcularPerimetro()}\n");

            // 2. Prueba de la clase Círculo
            // Creamos otra instancia
            Circulo miCirculo = new Circulo(53.0);
            
            Console.WriteLine("== PRUEBA: CÍRCULO ==");
            Console.WriteLine($"Radio: {miCirculo.Radio}");
            
            Console.WriteLine($"Área Calculada: {miCirculo.CalcularArea()}");
            Console.WriteLine($"Perímetro (Circunferencia) Calculado: {miCirculo.CalcularPerimetro()}");
            
            Console.WriteLine("\n--- Fin de Pruebas ---");
        }
    }
}