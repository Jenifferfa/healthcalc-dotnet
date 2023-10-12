using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Interfaces;

namespace healthcalc_test_dotnet.Pack
{
    public class IIMCTest
    {
        [Fact]
        public void CalculaIMC_QuandoPesoEAlturaValidos_EntaoRetornaIndice()
        {
            //Arrange
            IIMC imc = new IMC();
            double Peso = 66;
            double Altura = 1.59;
            double IndiceIMC = 26.1;

            //Act
            var IndiceIMCRetornardo = imc.CalcularIMC(Peso, Altura);

            //Asserts
            Assert.Equal(IndiceIMC, IndiceIMCRetornardo);
        }

        [Fact]
        public void CalculaIMC_QuandoPesoEAlturaValidos_EntaoRetornaExcecao()
        {
            //Arrange
            IIMC imc = new IMC();
            double Peso = 66;
            double Altura = 1.59;

            //Act
            try
            {
                imc.CalcularIMC(Peso, Altura);
            }
            catch (Exception ex)
            {
                Assert.Equal("ALTURA INVÁLIDA!", ex.Message.ToString().ToUpper());
            }
        }

        [Fact]
        public void RetornarClassificacaoIMC_AcimaDoPesoIndiceDentroDaFaixa()
        {
            //Arrange
            IIMC imc = new IMC();
            double IndiceIMC = 26.1;

            //Act
            var Classificacao = imc.RetornarClassificacaoIMC(IndiceIMC);

            //Asserts
            Assert.Equal("Sobrepeso", Classificacao); 
        }

        [Theory]
        [InlineData(15.23, "Abaixo do peso")]
        [InlineData(17.66, "Abaixo do peso")]
        [InlineData(18.50, "Abaixo do peso")]

        [InlineData(18.60, "Peso normal")]
        [InlineData(22.00, "Peso normal")]
        [InlineData(24.90, "Peso normal")]

        [InlineData(25.00, "Sobrepeso")]
        [InlineData(26.21, "Sobrepeso")]
        [InlineData(27.81, "Sobrepeso")]
        [InlineData(28.35, "Sobrepeso")]
        [InlineData(29.90, "Sobrepeso")]

        [InlineData(30.00, "Obesidade I")]
        [InlineData(32.00, "Obesidade I")]
        [InlineData(34.99, "Obesidade I")]

        [InlineData(35.00, "Obesidade II")]
        [InlineData(38.33, "Obesidade II")]
        [InlineData(39.90, "Obesidade II")]

        [InlineData(40.00, "Obesidade III")]
        [InlineData(40.10, "Obesidade III")]
        [InlineData(50.00, "Obesidade III")]
        public void RetornaClassificacaoIMC_AcimaDoPeso_QuandoIndiceDentroFaixa(double IndiceIMC, string Classificacao)
        {
            //Arrange
            IIMC imc = new IMC();

            //Act
            var Classificado = imc.RetornarClassificacaoIMC(IndiceIMC);

            //Asserts
            Assert.Equal(Classificacao, Classificado);
        }
    }
}
