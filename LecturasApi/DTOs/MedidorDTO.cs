namespace LecturasApi.DTOs
{
    public class MedidorDTOView
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; } = string.Empty;
    }
}