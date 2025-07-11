namespace CalculadoraWeb.Models
{
    public class ClienteDTO
    {
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
    }

    public class ClienteDTOView
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
    }

    public class MedidorDTO
    {
        public int Numero { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public int ClienteId { get; set; }
    }

    public class MedidorDTOView
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public int ClienteId { get; set; }
    }

    public class LecturaDTO
    {
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }
        public int MedidorId { get; set; }
    }

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
