namespace LecturasApi.DTOs
{
    public class LecturaResponseDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }
        public int MedidorId { get; set; }
        public int NumeroMedidor { get; set; }
        public string TipoMedidor { get; set; } = string.Empty;
    }
}