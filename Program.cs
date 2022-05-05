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
//bool encontrouNumeroRepetido = false;

//for (int i = 0; i < numero.Length; i++)
//{
//    int numeroTemp = int.Parse(Console.ReadLine());
//    for (int j = 0; j < numero.Length; j++)
//    {
//        if (numero[i] == numeroTemp)
//        {
//            Console.WriteLine("numero ja informado");
//            encontrouNumeroRepetido = true;
//            i--;
//            break;
//        }
//    }
//    if (encontrouNumeroRepetido)
//    {
//        i--;
//        encontrouNumeroRepetido = false;

//    }
//    else
//    {
//        numero[i] = numeroTemp;
//    }
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
//        Console.WriteLine($"O número 10 está na posição {i + 1} do vetor");
//    }


//}
//if (numero != 10)
//{
//    Console.WriteLine("Não foi encontrado nenhum número 10");
//}

//string[] resposta = new string[4];
//string[] gabarito = new string[4];
//int qtdAcertor = 0;

//string finalizarProva = null;
//string validadeRespostas = "";
//while (finalizarProva != "SAIR")
//{

//    if (validadeRespostas == "A" || validadeRespostas == "B" || validadeRespostas == "C" || validadeRespostas == "D")
//    {
//        Console.WriteLine("Digite uma alternativa correta");

//    }
//    else
//    {

//        for (int i = 0; i < resposta.Length; i++)
//        {
//            Console.WriteLine($"Informe a resposta da prova na posição {i}");
//            resposta[i] = Console.ReadLine();
//            Console.WriteLine($"Informe o gabarito{i}");
//            gabarito[i] = Console.ReadLine();

//            if (resposta[i] == gabarito[i])
//            {
//                qtdAcertor++;
//            }

//        }


//    }
//    Console.WriteLine($"você acertou : {qtdAcertor}");
//    qtdAcertor = 0;
//    Console.WriteLine("Deseja finalizar o teste?");
//    finalizarProva = Console.ReadLine();

//}

//int[] vetor = new int[15];
//int numerosPares = 0;
//int numerosImpares = 0;
//int soma = 0;
//double media = 0;
//int maior = 0;
//int menor = 0;
//int qtdNegativos = 0;
//int qtdNeutros = 0;
//int qtdPositivos = 0;

//for (int i = 0; i < vetor.Length; i++)
//{
//    Console.WriteLine($"Informe o numero da posição {i} do vetor");
//    vetor[i] = int.Parse(Console.ReadLine());
//    soma += vetor[i];
//    media = soma / 15;

//    if (vetor[i] < 0)
//    {
//        qtdNegativos++;
//    }
//    else if (vetor[i] == 0)
//    {
//        qtdNeutros++;
//    }
//    else
//    {
//        qtdPositivos++;
//    }
//    if (vetor[i] % 2 == 0)
//    {
//        numerosPares++;
//    }
//    else if (vetor[i] % 2 == 1)
//    {
//        numerosImpares++;
//    }

//}
//Console.WriteLine($"Soma: {soma}, " +
//    $"Média: {vetor.Average()}, " +
//    $"qtdNegativos: {qtdNegativos}, " +
//    $"qtdNeutros: {qtdNeutros}, " +
//    $"qtdPositivos: {qtdPositivos}," +
//    $"Maior numero: {vetor.Max()}," +
//    $"Menor numero: {vetor.Min()}" +
//    $"Numeros Pares: {numerosPares}," +
//    $"Numeros ímpares: {numerosImpares}");

//Console.WriteLine("Digite uma frase");
//string frase = Console.ReadLine();

//string[] palavras = frase.Split(";");

//for (int i = 0; i < palavras.Length; i++)
//{
//    Console.WriteLine(palavras[i]);
//}

//int[] vetor = new int[5];
//Random random = new Random();   
//for (int i = 0; i < vetor.Length; i++)
//{

//    if (vetor[i] == vetor[i])
//    {
//        vetor[i] = random.Next(10);
//    }
//}
//for (int i = 0; i < vetor.Length; i++)
//{
//    Console.WriteLine(vetor[i]);
//}

//parametro dado a ser passado(podendo ser obrigatorio ou não), para um metodo processar
//cast conversão de dados no C# podendo ser utilizados em sua maior parte, de numeros oara outros numeros
//retorno resposta do processamento de um metodo é facultativo o armazenamento desta resposta
// int double string bool
//int.parse double.parse
//convert.toint
//if elseif else
//while for
//vetor[]


//int[] numero = new int[10];
//bool encontrouNumeroRepetido = false;

//for (int i = 0; i < numero.Length; i++)
//{
//    int numeroTemp = int.Parse(Console.ReadLine());
//    for (int j = 0; j < numero.Length; j++)
//    {
//        if (numero[i] == numeroTemp)
//        {
//            Console.WriteLine("numero ja informado");
//            encontrouNumeroRepetido = true;
//            i--;
//            break;
//        }
//    }
//    if (encontrouNumeroRepetido)
//    {
//        i--;
//        encontrouNumeroRepetido = false;

//    }
//    else
//    {
//        numero[i] = numeroTemp;
//    }
//}

