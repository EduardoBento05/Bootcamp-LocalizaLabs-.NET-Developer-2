// See https://aka.ms/new-console-template for more information


using Colecoes.Helper;
using System.Collections.Generic;




int [] arrayNumeros = new int [10] {1,4,8,14,18,23,100,4,100,14};




var minimo = arrayNumeros.Min();
var maximo = arrayNumeros.Max();
var medio = arrayNumeros.Average();
var soma = arrayNumeros.Sum();
var arrayUnico = arrayNumeros.Distinct().ToArray();


Console.WriteLine($"Mínimo: {minimo}");
Console.WriteLine($"Máximo: {maximo}");
Console.WriteLine($"Médio: {medio}");
Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Array Original: {string.Join(",",arrayNumeros)}");
Console.WriteLine($"Array Distinto: {string.Join(",",arrayUnico)}");







//var numerosParesQuery = 
//    from num in arrayNumeros
//    where num % 2 == 0
//    orderby num 
//    select num;


//var numerosParesMetodo  = arrayNumeros.Where(num => num % 2 == 0).OrderBy(num => num).ToList();

//Console.WriteLine("Números Pares query:"+String.Join(",",numerosParesQuery));
//Console.WriteLine("Números Pares query:" + String.Join(",", numerosParesMetodo));

//Dictionary<string,string> estados = new Dictionary<string,string>();


//estados.Add("SP", "São Paulo");
//estados.Add("PR", "Paraná");
//estados.Add("RS", "Rio Grande do Sul");

//foreach (KeyValuePair<string,string> item in estados)
//{
//    //Console.WriteLine($"Chave: {item.Key},Valor: {item.Value}");
//}


//string valorProcurado = "sc";

////var teste = estados["SC"];

//if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
//{
//    Console.WriteLine(estadoEncontrado);
//}
//else
//{
//    Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
//}


//Console.WriteLine($"Removendo o Valor: {valorProcurado}");

//estados.Remove(valorProcurado);

//foreach (KeyValuePair<string, string> item in estados)
//{
//    Console.WriteLine($"Chave: {item.Key},Valor: {item.Value}");
//}



//string valorProcurado = "RS";
//Console.WriteLine("Valor Original");
//Console.WriteLine(estados[valorProcurado]);

//estados[valorProcurado] = "RS - teste Atualização";

//Console.WriteLine("Valor Atualizado");
//Console.WriteLine(estados[valorProcurado]);


//Stack<string> pilhalivros = new Stack<string>();    


//pilhalivros.Push(".NET");
//pilhalivros.Push("Senhor dos Anéis");
//pilhalivros.Push("Código Limpo");

//Console.WriteLine($"Livros para a Leitura: {pilhalivros.Count}");
//do
//{
//    Console.WriteLine($"Próximo Livro para a Leitura: {pilhalivros.Peek()}");
//    Console.WriteLine($"{pilhalivros.Pop()} lido com sucesso");

//} while (pilhalivros.Count > 0 );
//Console.WriteLine($"Livros para a Leitura: {pilhalivros.Count}");


//Queue <string> fila = new Queue <string> ();

//fila.Enqueue("Eduardo");
//fila.Enqueue("Lucas");
//fila.Enqueue("Laís");

//Console.WriteLine($"Pessoas na Fila: {fila.Count}");
//while (fila.Count > 0)
//{
//    Console.WriteLine($"Vez de {fila.Peek()}");
//    Console.WriteLine($"{fila.Dequeue()} atendido");
//}
//Console.WriteLine($"Pessoas na Fila: {fila.Count}");

//OperacoesLista oplista = new OperacoesLista();

//List <string> estados = new List<string>();    
//string[] estadosArray = new string[2] {"SC","RN"};

//estados.Add("SP");
//estados.Add("PR");
//estados.Add("MG");

//Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");


//oplista.ImprimirListaString(estados);

////Console.WriteLine("Removendo o elemento");
////estados.Remove("MG");

////estados.AddRange(estadosArray);

//estados.Insert(1, "RS");

//oplista.ImprimirListaString(estados);





//foreach (var item in estados)
//{
//    Console.WriteLine(item);
//}


//using Colecoes.Helper;

//OperacoesArray op  = new OperacoesArray();

//int [] array = new int[5] { 6, 3, 8, 1 ,9};
//int [] arrayCopia = new int[10];
//string[] arrayString = op.ConverterParaArrayString(array);




//int valorProcurado = 9;


//Console.WriteLine($"Capacidade Atual do Array {array.Length}");

//op.RedimensionarArray(ref array, array.Length * 2);


//Console.WriteLine($"Capacidade Atual do Array Após Redimensionar {array.Length}");




//int indice = op.ObterIndice(array,valorProcurado);

//if(indice > -1)
//{
//    Console.WriteLine("O indice do elemento {0} é : {1}",valorProcurado,indice);
//}
//else
//{
//    Console.WriteLine("Valor não existente no Array");
//}

//int valorAchado = op.ObterValor(array , valorProcurado);

//if (valorAchado > 0)
//{
//    Console.WriteLine("Encontrei o Valor");
//}
//else
//{
//    Console.WriteLine("Não Encontrei o Valor");
//}



//bool todosMaiorQue = op.TodosMaiorQue(array,valorProcurado);


//if (todosMaiorQue)
//{
//    Console.WriteLine("Todos os Valores são maior que {0}",valorProcurado);
//}
//else
//{
//    Console.WriteLine("Existem Valores que não são maiores que {0}",valorProcurado);
//}


//bool existe = op.Existe(array, valorProcurado);


//if (existe)
//{
//    Console.WriteLine($"Encontrei o Valor {valorProcurado}");
//}
//else
//{
//    Console.WriteLine($"Não Encontrei o Valor {valorProcurado}");
//}


//Console.WriteLine("Array Original: ");
//op.ImprimirArray(array);

////op.OrdenarBubbleSort(array);
//op.Ordenar(ref array);

//Console.WriteLine("Array Ordenado");
//op.ImprimirArray(array);

//Console.WriteLine("Array após a Copia:");
//op.Copiar(ref array,ref arrayCopia);
//op.ImprimirArray(arrayCopia);


////decçaração de uma array multidimensional(matriz) com 3 linhas e 3 colunas
//int[,] arrayMultidimensional = new int[3, 3]
//{
//    {1,8,4},
//    {2,1,3},
//    {9,10,1}
//};


//for (int i = 0; i < arrayMultidimensional.GetLength(0); i++)
//{
//    for (int j = 0; j < arrayMultidimensional.GetLength(1); j++)
//    {
//        Console.WriteLine(arrayMultidimensional[i,j]);
//    }

//}


//int[] vetorInteiro = new int[4]; //declaração de array com capadiade de 4 valores inteiros

//vetorInteiro[0] = 85;
//vetorInteiro[1] = 20;
//vetorInteiro[2] = 35;
//vetorInteiro[3] = 123;


//Console.WriteLine("Percorrendo o Array pelo for");
//for (int i = 0; i < vetorInteiro.Length ; i++)
//{
//    Console.WriteLine($"v[{i}] = {vetorInteiro[i]}");
//}

//Console.WriteLine("\n");

//Console.WriteLine("Percorrendo o Array pelo Foreach");
//foreach (var item in vetorInteiro)
//{
//    Console.WriteLine(item);
//}
