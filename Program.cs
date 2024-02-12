namespace Ej3.fechas;
 

class Program
{

    public static void Main(string[] args)
    {

        Random numeroRamdom = new Random();

        DateTime fecha = DateTime.Now;
        Console.WriteLine("Fecha hoy");
        Console.WriteLine(fecha);
        int numeroRestaAños = numeroRamdom.Next(0, 4);
        DateTime fechaModificada = fecha.AddDays(1).AddMonths(-24).AddYears(-numeroRestaAños);
        Console.WriteLine("Resultado");
        Console.WriteLine(fechaModificada);
        Console.WriteLine("Comparación de fechas");
        int comparFechas = fechaModificada.CompareTo(fecha);
        if (comparFechas > 0)
        {
            Console.WriteLine("El hoy es mas pequeño");
        }
        else
        {
            Console.WriteLine("El hoy es mas grande");
        }






    }



}