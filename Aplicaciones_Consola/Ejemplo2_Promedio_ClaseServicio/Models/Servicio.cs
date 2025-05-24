namespace Ejemplo2.Models
{
    internal class Servicio
    {
        double acum;
        int contador;

        public double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
                promedio = acum / contador;
            return promedio;
        }
        public void RegistrarNota(double nota)
        {
            acum += nota;
            contador++;
        }
    }
}
