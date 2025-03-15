namespace FormatearFechas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime();


            fecha = DateTime.Now;

            string fechaString = fecha.ToString();

            Console.WriteLine(fechaString);


            string fechaString1 = string.Format("La fecha de hoy es {0:dddd mm yyy}", DateTime.Now);

            Console.WriteLine(fechaString1);

           

        }
    }
}
