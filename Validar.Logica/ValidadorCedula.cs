namespace Validar.Logica;

public class Class1
{
    public static bool Escedulavalida(string cedula)
    {
        if (cedula.Length != 10 || !cedula.All(char.IsDigit))
            return false;
        int provincia = int.Parse(cedula.Substring(0, 2));
        if (provincia < 1 || provincia > 24)
            return false;

        int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
        int suma = 0;
        for (int i = 0; i < coeficientes.Length; i++)
        {
            int valor = int.Parse(cedula[i].ToString()) * coeficientes[i];
            if (valor >= 10)
                valor -= 9;
            suma += valor;
        }
        int digitoVerificador = int.Parse(cedula[9].ToString());
        int decenaSuperior = ((suma + 9) / 10) * 10;
        int resultado = decenaSuperior - suma;

        return resultado == digitoVerificador || (resultado == 10 && digitoVerificador == 0);
        
    }

}
