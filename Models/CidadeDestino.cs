namespace AT_CSharp_DB.Models
{
    public class CidadeDestino
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public int PaisDestinoId { get; set; }
        public PaisDestino Pais {  get; set; }
    }
}
