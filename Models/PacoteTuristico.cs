namespace AT_CSharp_DB.Models
{
    public class PacoteTuristico
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public DateTime DataInicio { get; set; }

        public int CapacidadeMaxima { get; set; }

        public decimal Preco {  get; set; }

        public List<CidadeDestino> Cidades { get; set; }
    }
}
