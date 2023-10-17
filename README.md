```markdown
# Projeto de Cálculo de IMC e Macronutrientes em .NET

## Descrição

Este é um projeto .NET que fornece funcionalidade para calcular o Índice de Massa Corporal (IMC) e os macronutrientes com base nos dados fornecidos. Ele inclui uma API pública que pode ser consumida para realizar esses cálculos.

## Pré-requisitos

- Visual Studio 2019 ou posterior.
- .NET 5.0 SDK ou posterior.
- xUnit.net para a execução dos testes

## Configuração do Projeto

1. Clone este repositório em sua máquina local:
```

git clone https://github.com/seurepositorio/seuprojeto.git

```

2. Abra o projeto em sua IDE (como o Visual Studio).

3. Certifique-se de que você tem o .NET 5.0 SDK instalado.

4. Restaure as dependências do NuGet usando o seguinte comando

```

dotnet restore:

```

## Estrutura do Projeto

- `IMCCalculator`: O núcleo do projeto que contém as classes para calcular o IMC e os macronutrientes.
- `IMCCalculator.Tests`: Testes unitários usando xUnit.net.

## Executando Testes

Para executar os testes unitários, use o seguinte comando:

```

dotnet test IMCCalculator.Tests

```

## Uso da API

Você pode usar a API fornecida para calcular o IMC e os macronutrientes. A API está disponível como um pacote NuGet. Para instalá-lo, execute o seguinte comando:

```

dotnet add package IMCCalculator

````

Exemplo de uso da API:

```csharp
using IMCCalculator;

double weightKg = 70;
double heightCm = 170;

var imc = IMCCalculator.CalculateIMC(weightKg, heightCm);
var macronutrients = IMCCalculator.CalculateMacronutrients(weightKg, heightCm);

Console.WriteLine($"IMC: {imc}");
Console.WriteLine($"Macronutrientes: Proteína {macronutrients.Protein}g, Carboidratos {macronutrients.Carbohydrates}g, Gordura {macronutrients.Fat}g");
````

## Contribuição

Se desejar contribuir para este projeto, siga estas etapas:

1. Faça um fork do repositório.
2. Crie uma nova branch para sua contribuição: `git checkout -b feature/sua-contribuicao`.
3. Faça suas alterações e adicione testes, se necessário.
4. Envie um pull request.

## Autor

Seu Nome
Seu E-mail

## Licença

Este projeto é licenciado sob a Licença MIT. Consulte o arquivo `LICENSE` para obter mais informações.

```

Certifique-se de substituir os marcadores de posição (como `seurepositorio`, `seuprojeto`, `Seu Nome` e `Seu E-mail`) com as informações reais do seu projeto.
```
