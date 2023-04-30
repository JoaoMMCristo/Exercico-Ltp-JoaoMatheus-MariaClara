using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;


int opçao;
do
{
    Console.WriteLine("\n  Escolha  \n");
    Console.WriteLine("0: acabar o programa");
    Console.WriteLine("1: Somar 2 números");
    Console.WriteLine("2: Calcular Aumento");
    Console.WriteLine("3: calcular Aluguel de Carro");
    Console.WriteLine("4: calcular Tabuada");
    Console.WriteLine("5: calcular Desconto");
    Console.WriteLine("6: calcular o Imposto de Renda");
    Console.WriteLine("7: calcular o Metros em Milimitros");
    Console.WriteLine("8: Aposentadoria ");
    Console.WriteLine("9: Calcular Financiamento");
    Console.WriteLine("10: Calcular os Multipos de 3");
    Console.WriteLine("11: Calcular Fatorial ");
    Console.WriteLine("12: Calcular IMC");
    Console.WriteLine("13: Adivinhar um Numero de 0 a 100");
    Console.WriteLine("Digite Sua opção: ");
    string entrada = Console.ReadLine();
    opçao = int.Parse(entrada);


    switch (opçao)
    {
        case 0:
            Console.WriteLine("Encerrando o programa");
            return;
        case 1:
            some();
            break;

        case 2:
            aumento();
            break;

        case 3:
            aluguel();
            break;

        case 4:
            tabuada();
            break;
        case 5:
            desconto();
            break;
        case 6:
            impostorenda();
            break;
        case 7:
            metros();
            break;
        case 8:
            aposentadoria();
            break;
        case 9:
            financiamento();
            break;
        case 10:
            multiplosde3();
            break;
        case 11:
            fatorial();
            break;
        case 12:
            imc();
            break;
        case 13:
            adivinhacao();
            break;

    }

} while (opçao != 0);



adivinhacao();
financiamento();
imc();
metros();
aposentadoria();
impostorenda();
aluguel();
desconto();
tabuada();
multiplosde3();
fatorial();
aumento();
some();








void some()
{
    Console.WriteLine("digite o primeiro numero ");
    byte num1 = byte.Parse(Console.ReadLine());
    Console.WriteLine("digiter o segundo numero ");
    byte num2 = byte.Parse(Console.ReadLine());
    byte soma = (byte)(num1 + num2);
    Console.WriteLine("Resultado " +  soma);
}

void aumento()
{
    Console.WriteLine("Informe o salario ");
    double salario = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe percentual de aumento");
    double porcentagemdeaumento = double.Parse(Console.ReadLine()) / 100;
    double percentualaumento = (double)(salario * porcentagemdeaumento);
    Console.WriteLine("Percentual de aumento é " + percentualaumento);
    double novsal = (double)(salario + percentualaumento);
    Console.WriteLine( "O novo valor do salario é " + novsal);
    Console.WriteLine("Salario inicial é " + salario);

}

void aposentadoria()
{
    double juroscompost = 0, acumulador = 0, montante = 0;
    Console.WriteLine("Informe a sua idade");
    double idade = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a idade que quer se aposentar");
    double idadefinal = int.Parse(Console.ReadLine());
    Console.WriteLine("Valor para aposentadoria");
    double valoraposentadoria = double.Parse(Console.ReadLine());
    double taxarendimento = 0.01;
    double anosrendimento = (idadefinal - idade) * 12;

    for (double i = 0; i <= anosrendimento; i++)
    {
        acumulador = acumulador + valoraposentadoria;
        juroscompost = juroscompost + (acumulador * 0.01);
        montante = acumulador + juroscompost;

    }

    double salarioliquido = montante * taxarendimento;
    Console.WriteLine("Montante igual a " + montante);
    Console.WriteLine($"Salario liquido igual a {salarioliquido}");
}

void financiamento()
{
    int i;
    double divisaodoveiculo = 0, valortaxa = 0, valortotal = 0;
    Console.WriteLine("Informe o valor do veiculo");
    double valorVeiculo = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o numero de parcelas");
    double NumeroParcelas = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe taxa mensal ");
    double taxamensal = double.Parse(Console.ReadLine()) / 100;

    for (i = 0; i != NumeroParcelas; i++)
    {
        divisaodoveiculo = valorVeiculo / NumeroParcelas;
        valortaxa = divisaodoveiculo + (divisaodoveiculo * taxamensal);
        valortotal = valortaxa + valorVeiculo;


    }
    Console.WriteLine("Valor do Veiculo Total igual a :" + valortotal);

}

void aluguel()
{
    Console.WriteLine("Informe o numero de dias ");
    byte numerosdedias = byte.Parse(Console.ReadLine());
    Console.WriteLine("Informe Quilometro inicial");
    byte quilometroinicial = byte.Parse(Console.ReadLine());
    Console.WriteLine("Informe Quilometro Final");
    byte quilometrofinal = byte.Parse(Console.ReadLine());

    int valorpordia = (int)(numerosdedias * 95);
    double valorporquilometro = (double)(quilometrofinal - quilometroinicial) * 0.35;
    double valortotal = (double)(valorporquilometro + valorpordia);
    Console.WriteLine("Valor a ser pago é :" + valortotal);

}

void metros()
{

    Console.WriteLine("Informe o valor em metro ");
    float metro = float.Parse(Console.ReadLine());
    Console.WriteLine("O valor informado em  metro foi : " + metro);
    double milimetros = metro * 1000;
    Console.WriteLine($"Valor informado em milimetros foi " + milimetros);

}

void imc()
{
    Console.WriteLine("Informe a altura em metros : ");
    float altura = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe o peso em kg : ");
    float peso = float.Parse(Console.ReadLine());
    float imc = peso / (altura * altura);
    Console.WriteLine("Imc igual:" + imc);
    if (imc < 18.5)
    {
        Console.WriteLine("Abaixo do peso");
    }
    else if (imc <= 24.9)
    {
        Console.WriteLine("Peso ideal");
    }
    else if (imc <= 29.9)
    {
        Console.WriteLine("Levemente acima do peso");
    }
    else if (imc <= 34.9)
    {
        Console.WriteLine("Obesidade grau 1");
    }
    else if (imc <= 39.9)
    {
        Console.WriteLine("Obesidade grau 2");
    }
    else if (imc >= 40)
    {
        Console.WriteLine("Obesidade morbida");
    }
}

void adivinhacao()
{
    int chances = 0;
    int num = 0;
    Random ran = new Random();
    int f = ran.Next(0, 100);
    while (true)
    {
        chances++;

        Console.WriteLine("Advinha o numero!");
        try
        {
            num = int.Parse(Console.ReadLine());
        }
        catch { Console.WriteLine("EU falei numero o imbecil."); }
        if (num < f) { Console.WriteLine("Maior..."); }
        else if (num > f) { Console.WriteLine("Menor..."); }
        if (chances >= 10)
        {
            Console.WriteLine("Voce errou");
            Console.WriteLine("O numero era " + f);
            break;
        }
        if (num ==f)
        {
            Console.WriteLine("Acertou!");
            Console.WriteLine("\nDepois de {0} tentativas.", chances);
            break;
        }
    }
}

void fatorial()
{

    float[] fatorial = new float[11];
    fatorial[0] = 1;

    for (int i = 1; i < fatorial.Length; i++){
      
        fatorial[i] = fatorial[i - 1] * i;
        Console.WriteLine($"O fatorial de: {i} é: {fatorial[i]}");
    }
}

void tabuada()
{
    int form, cont, num;


    Console.Write("Digite o numero para ter a taboada : ");
    num = int.Parse(Console.ReadLine());


    for (cont = 1; cont <= 10; ++cont){
       
        form = num * cont;
        Console.WriteLine(num + " X " + cont + " = " + form);

    }
}

void desconto()
{
    Console.WriteLine("Informe o valor ");
    float real = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe a porcentagem do desconto");
    float desconto = float.Parse(Console.ReadLine());
    float valorcomdesconto = real - (real * desconto) / 100;
    Console.WriteLine("Valor com desconto igual a " + valorcomdesconto);
    Console.WriteLine("Valor sem desconto " + real);
    Console.WriteLine("Desconto foi de " + desconto + "%");
}

void multiplosde3()
{
    float[] multiplosde3 = new float[101];
    multiplosde3[0] = 3;
    for (int i = 1; i < multiplosde3.Length; i++)
    {
        multiplosde3[i] = i + 1;
        if (i % 3 == 0){
            
            Console.WriteLine("Multipo de 3:" + i);
        }
    }
    Console.WriteLine("Esses foram os multiplos de 3 :3");
}

void impostorenda()
{
    Console.WriteLine("Informe seu salario");
    double salarioBruto = double.Parse(Console.ReadLine());
    if (salarioBruto < 1903.93){
        
        Console.WriteLine("Não recebe desconto");
    }
    else if (salarioBruto <= 2826.65){
       
        double porcentagemdesconto = 7.5 / 100;
        double Salariocomdesconto = salarioBruto - (salarioBruto * porcentagemdesconto);
        Console.WriteLine("Salario com desconto igual a " + Salariocomdesconto);
    }
    else if (salarioBruto <= 3751.05){
        
        double porcentagemdedesconto = 15.0 / 100;
        double salariocomdesconto = salarioBruto - (salarioBruto * porcentagemdedesconto);
        Console.WriteLine("Salario com desconto igual a " + salariocomdesconto);
        var valordaporcentagem = (salarioBruto * porcentagemdedesconto);
        double valorapagar = valordaporcentagem - 142.80;
        Console.WriteLine("Valor a pagar = " + valorapagar);
    }
    else if (salarioBruto <= 4664.68){
       
        double porcentagemdedesconto = 22.5 / 100;
        double salariocomdesconto = salarioBruto - (salarioBruto * porcentagemdedesconto);
        Console.WriteLine("Salario com desconto igual a " + salariocomdesconto);
        var valordaporcentagem = (salarioBruto * porcentagemdedesconto);
        double valorapagar = valordaporcentagem - 142.80;
        Console.WriteLine("Valor a pagar = " + valorapagar);

    }
    else if (salarioBruto > 4664.68){
       
        double porcentagemdedesconto = 27.5 / 100;
        double salariocomdesconto = salarioBruto - (salarioBruto * porcentagemdedesconto);
        Console.WriteLine("Salario com desconto igual a " + salariocomdesconto);
        var valordaporcentagem = (salarioBruto * porcentagemdedesconto);
        double valorapagar = valordaporcentagem - 142.80;
        Console.WriteLine("Valor a pagar = " + valorapagar);
    }
}
