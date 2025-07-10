namespace ValidadorCorreo.Logica.Generadores
{
    public static class GeneradorCorreo
    {
        private static readonly string[] dominios = {
            "gmail.com", "outlook.com", "hotmail.com", "yahoo.com"
        };

        public static List<string> GenerarCorreos(string nombre, string apellido, string palabraClave)
        {
            List<string> sugerencias = new();

            nombre = nombre.Trim().ToLower();
            apellido = apellido.Trim().ToLower();
            palabraClave = palabraClave.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
                return new List<string> { "❌ Nombre y apellido son obligatorios." };

            var random = new Random();
            int numero = random.Next(10, 10000); // Genera un número de 2 a 4 dígitos

            foreach (var dominio in dominios)
            {
                // Solo letras
                sugerencias.Add($"{nombre}{apellido}{palabraClave}@{dominio}");
                sugerencias.Add($"{nombre}.{apellido}.{palabraClave}@{dominio}");
                sugerencias.Add($"{nombre[0]}{apellido}{palabraClave}@{dominio}");
                sugerencias.Add($"{apellido}{nombre}@{dominio}");
                sugerencias.Add($"{nombre}{palabraClave}@{dominio}");

                // Con números
                sugerencias.Add($"{nombre}{apellido}{palabraClave}{numero}@{dominio}");
                sugerencias.Add($"{nombre}.{apellido}.{palabraClave}{numero}@{dominio}");
                sugerencias.Add($"{nombre[0]}{apellido}{palabraClave}{numero}@{dominio}");
                sugerencias.Add($"{apellido}{nombre}{numero}@{dominio}");
                sugerencias.Add($"{nombre}{palabraClave}{numero}@{dominio}");
            }

            return sugerencias;
        }
    }
}