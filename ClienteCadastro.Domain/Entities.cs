namespace ClienteCadastro.Domain.Entities
{
    public enum PorteEmpresa
    {
        Pequena,
        Media,
        Grande
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string NomeEmpresa { get; set; }
        public PorteEmpresa Porte { get; set; }
    }
}
