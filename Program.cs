namespace Ej3.fechas;
 

class Program
{

    public static void Main(string[] args)
    {

        Random numeroRamdom = new Random();

        DateTime fecha = DateTime.Now;
        Console.WriteLine("Fecha hoy");
        Console.WriteLine(fecha);
        int restaAños = numeroRamdom.Next(0, 4);
        DateTime fechaFinal = fecha.AddDays(1).AddMonths(-24).AddYears(-restaAños);
        Console.WriteLine("Resultado");
        Console.WriteLine(fechaFinal);
        Console.WriteLine("Comparación de fechas");
        int compararFechas = fechaFinal.CompareTo(fecha);
        if (compararFechas > 0)
        {
            Console.WriteLine("El hoy es mas pequeño");
        }
        else
        {
            Console.WriteLine("El hoy es mas grande");
        }






    }



}