using healthcalc_pack_dotnet.Interfaces;

namespace healthcalc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double CalcularIMC(double Peso, double Altura)
        {
            if (Altura == 0)
                throw new Exception("Altura invalida");
            return Math.Round(Peso / (Altura * Altura), 2);
        }

        public string RetornarClassificacaoIMC(double IMC)
        {
            if (IMC <= 18.5)
                return "Abaixo do peso";
            else if (IMC >= 18.6 && IMC <= 24.9)
                return "Peso normal";
            else if (IMC > 24.9 && IMC <= 29.9)
                return "Sobrepeso";
            else if (IMC > 29.9 && IMC <= 34.9)
                return "Obesidade I";
            else if (IMC > 34.9 && IMC <= 39.9)
                return "Obesidade II";
            else
                return "Obesidade III";
        }
    }
}
