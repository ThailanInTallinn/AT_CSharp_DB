namespace AT_CSharp_DB.Models
{
    public class Reserva
    {

        public int Id { get; set; }

        public int ClienteID {  get; set; }

        public Cliente Cliente { get; set; }

        public int PacoteTuristicoId { get; set; }  

        public PacoteTuristico PacoteTuristico { get; set; }

        public DateTime DataReserva {  get; set; }


        public List<string> memoryLog = new List<string>();

        public delegate double CalculaDelegate(double preco);

        public static double CalculaDesconto(double preco)
        {
            double precoComDesconto = preco - (preco * 0.1);
            return precoComDesconto;
        }

        public static string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public void LogToConsole(string reserva)
        {
            Console.WriteLine(reserva);
        }

        public void LogToFile(string reserva)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "reservasLogFile.txt")))
            {
                outputFile.WriteLine(reserva);
            }
        }

        public void LogToMemory(string reserva) => this.memoryLog.Add(reserva);

        public static Func<int, int, decimal> calculaValorReserva = (numeroDeDiarias, valorCadaDiaria) =>
        {
            return numeroDeDiarias * valorCadaDiaria;
        };


        public delegate void Notify();

        public event Notify CapacityReached;

        public void warnCapacity()
        {
            CapacityReached?.Invoke();
        }



    }
}
