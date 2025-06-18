namespace AT_CSharp_DB.Subscribers
{
    public class CapacityEventSubscriber
    { 
        public void CapacityAlertMessage()
        {
            Console.WriteLine("Todos os quartos foram preenchidos. Capacidade máxima atingida.");
        }
    }
}
