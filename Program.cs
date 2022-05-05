//int[] vetor1 = new int[5];
//int[] vetor2 = new int[5];
//int[] soma = new int[5];
//int[] subtrair= new int[5];
//double multiplicar = 0;
//double dividir = 0;

//for (int i = 0; i < vetor1.Length; i++)
//{
//    Console.WriteLine($"Digite o numero do vetor 1 posicao {i}");
//    vetor1[i] = int.Parse(Console.ReadLine());
//    Console.WriteLine($"Digite o numero do vetor 2 posicao {i}");
//    vetor2[i] = int.Parse(Console.ReadLine());


//}
//Console.WriteLine("Digite qual tipo de cálculo deseja executar");
//string tipoCalculo = Console.ReadLine();
//if (tipoCalculo == "Soma")
//{
//    for (int i = 0; i < vetor2.Length; i++)
//    {
//        soma[i] = vetor1[i] + vetor2[i];

//    }
//    for (int i = 0; i < vetor1.Length; i++)
//    {
//        Console.WriteLine(soma[i]);
//    }
//}else if(tipoCalculo == "Subtrair")
//{
//    for (int i = 0; i < vetor2.Length; i++)
//    {
//        soma[i] = vetor1[i] - vetor2[i];

//    }
//    for (int i = 0; i < vetor1.Length; i++)
//    {
//        Console.WriteLine(soma[i]);
//    }
//}else if(tipoCalculo == "Multiplicar")
//{
//    for (int i = 0; i < vetor2.Length; i++)
//    {
//        soma[i] = vetor1[i] * vetor2[i];

//    }
//    for (int i = 0; i < vetor1.Length; i++)
//    {
//        Console.WriteLine(soma[i]);
//    }
//}
//else if (tipoCalculo == "Dividir")
//{
//    for (int i = 0; i < vetor2.Length; i++)
//    {
//        soma[i] = vetor1[i] / vetor2[i];

//    }
//    for (int i = 0; i < vetor1.Length; i++)
//    {
//        Console.WriteLine(soma[i]);
//    }
//}

//int[] numero = new int[10];

//for (int i = 0; i < numero.Length; i++)
//{
//    Console.WriteLine($"Informe o numero{i}");
//    numero[i] = int.Parse(Console.ReadLine());

//}
//for (int i = numero.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(numero[i]);
//}

//int[] vetor = new int[5];
//int numero = 0;

//for (int i = 0; i < vetor.Length; i++)
//{
//    Console.WriteLine($"Informe o numero vetor posicao{i}");
//    vetor[i] = int.Parse(Console.ReadLine());

//}
//for (int i = 0; i < vetor.Length; i++)
//{
//    if (vetor[i] == 10)
//    {
//        numero = numero + vetor[i];
//        Console.WriteLine($"O número 10 está na posição {i+1} do vetor");
//    }


//}
//if (numero != 10)
//{
//    Console.WriteLine("Não foi encontrado nenhum número 10");
//}

string[] resposta = new string[4];
string[] gabarito = new string[4];
int qtdAcertor = 0;

string finalizarProva = null;
while (finalizarProva != "SAIR")
{

    for (int i = 0; i < resposta.Length; i++)
    {
        Console.WriteLine($"Informe a resposta da prova na posição {i}");
        resposta[i] = Console.ReadLine();
        Console.WriteLine($"Informe o gabarito{i}");
        gabarito[i] = Console.ReadLine();

        if (resposta[i] == gabarito[i])
        {
            qtdAcertor++;
        }

    }
    Console.WriteLine($"você acertou : {qtdAcertor}");
    finalizarProva = Console.ReadLine();    
}