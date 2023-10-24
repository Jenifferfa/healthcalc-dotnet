# Health calc 💪

## Descrição
O projeto calcula o Índice de Massa Corporal (IMC), classifica o resultado e também faz o cálculo de macronutrientes pode ser uma ferramenta valiosa para pessoas que desejam monitorar sua saúde e bem-estar. Abaixo, descrevo em detalhes como essa aplicação pode funcionar:

## Funcionamento:
A aplicação realiza os seguintes cálculos e processos:

##  Cálculo do IMC:

O IMC é calculado utilizando a fórmula IMC = peso (kg) / (altura (m) * altura (m)).
O resultado é categorizado de acordo com a classificação padrão do IMC.

## Cálculo de Macronutrientes:

A proporção de macronutrientes (carboidratos, proteínas e gorduras) é determinada com base no objetivo (perda de peso, manutenção de peso, ganho de peso) e nas diretrizes nutricionais recomendadas.
Os valores de carboidratos, proteínas e gorduras são calculados em gramas e exibidos na tela.

## Benefícios:

Os usuários podem monitorar seu IMC, o que é uma métrica importante para avaliar o peso corporal.
A aplicação ajuda os usuários a entender sua classificação de IMC e os riscos associados à sua categoria.
A determinação dos macronutrientes fornece uma orientação dietética personalizada, auxiliando os usuários em suas metas de saúde e condicionamento físico.

## Notas Adicionais:

É importante lembrar que essa aplicação fornece informações gerais e não substitui a orientação de um profissional de saúde ou nutricionista. A consulta a um profissional de saúde é recomendada antes de fazer mudanças significativas na dieta ou no estilo de vida.

## Pré-requisitos

- Visual Studio 2022 ou posterior.
- .NET 8.0 SDK.
- xUnit.net para a execução dos testes

## Configuração do Projeto

1. Clone este repositório em sua máquina local:
```
https://github.com/Jenifferfa/healthcalc-dotnet.git
```

2. Certifique-se de que você tem o .NET 8.0 SDK instalado.

3. Restaure as dependências do NuGet usando o seguinte comando

  - Selecione o comando de menu ferramentas > NuGet Gerenciador de Pacotes > Gerenciador de Pacotes Configurações.
  - Marque as duas opções em Restauração de Pacote.
  - Selecione OK.
  - Compile o projeto novamente.


## Estrutura do Projeto

![Untitled](https://github.com/Jenifferfa/healthcalc-dotnet/assets/32148606/9a2c4b35-d940-45c3-ab3f-e3e5e761a310)

## Executando Testes

Para verificar a cobertura de testes instalar a extensão fine code coverage

## Uso do pacote

Você pode usar opacote fornecido para calcular o IMC e os macronutrientes. O pacote está disponível no NuGet. Para instalá-lo, execute o seguinte comando:

```
![image](https://github.com/Jenifferfa/healthcalc-dotnet/assets/32148606/044741e5-1f9f-4d3e-8a6b-6aee0204421c)

dotnet add package healthcalc-pack-dotnet2 --version 1.0.0

````

## Contribuição

Se desejar contribuir para este projeto, siga estas etapas:

1. Faça um clone do repositório.
2. Crie uma nova branch para sua contribuição: `git checkout -b feature/sua-contribuicao`.
3. Faça suas alterações e adicione testes, se necessário.
4. Envie um pull request.

## Autores
- Jeniffer Santos
- Silas Ribeiro
- Vinicius Oliveira


