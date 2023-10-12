using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Interfaces;

IIMC objeto  = new IMC();

var imc = objeto.CalcularIMC(66.00, 1.59);
var resultado = objeto.RetornarClassificacaoIMC(imc);

Console.WriteLine("Seu resultado e: " + resultado);