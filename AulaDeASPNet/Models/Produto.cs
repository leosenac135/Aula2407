namespace AulaDeASPNet.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string VidaUtil { get; set; } = string.Empty;
        public string Garantia { get; set; }
        public string Preços { get; set; }
    }
}
