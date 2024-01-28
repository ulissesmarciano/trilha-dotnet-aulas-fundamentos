using ExemploFundamentos.Models; //Importando a localização da Classe.

// //USANDO A CLASSE PESSOA
// Pessoa p1 = new Pessoa(); //Aqui eu declaro uma nova pessoa que utilizei o p1.
// p1.Nome = "Ulisses"; //quando utilizo p1. eu estou dizendo que o nome daquela pessoa declarada é o que vou utilizar agora.
// p1.Idade = 35;

// p1.Apresentar();















// //DECLARANDO TIPOS E VARIÁVEIS
// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// quantidade = 10; //No caso eu alterei a linha de cima por se tratar de uma variável. Agora o programa será executado por ordem e o resultado será  a alteração.

// double altura = 1.80; //Ao imprirmir sem tratamento o logo reporta 1,8 para tratar utilizamos altura.ToString("0,00")

// decimal preco = 1.80M; 

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);










// //O TIPO DATETIME

// DateTime dataAtual = DateTime.Now; //Posso utilizar outros complementos para alterar minha data
// Console.WriteLine(dataAtual.ToString("dd/MM HH:mm" )); //Posso utilizar o tratamento para mostrar somente o que eu quero como o exemplo que retirei o ano e os segundos.



















// int a = 10;// O sinal de igual é o operador de atribuição. No caso replicando eu digo que a está recebendo 10.
// int b = 20;

// int c = a + b;

// //COMBINAÇÃO DE OPERADORES
// //c = c + 5; //Como eu já declarei c não posso iniciar declarando ele como inteiro pois o mesmo já é. Quando utilizo esta equação eu estou subscrevendo c com outra operação.
// c += 5; //A forma mais simplificada de declarar o que está na linha de cima. 

// Console.WriteLine(c);

















//CONVERTENDO TIPOS EM VARIÁVEIS
//O caso nos chama a fazer um Casting que é converter uma variável em outra.
//int a = Convert.ToInt32("5"); //Aqui convertemos uma informação que recebe uma string direto nosta variável e a converte para inteiro. Esse modo aceita o valor null (0).

//int a = int.Parse("5");//Faz o mesmo processo que acima sem dizer o que quero. Automaticamente converte para Int 32. Esse modo não aceita o valor null


//Poso utilizar o X.toParse onde X é o objeto que quero a conversão.
//Console.WriteLine(a);












//CONVERSÃO PARA STRING

//int inteiro = 5;
//string a = Convert.ToString(inteiro);//FORMA COMO SE CONVERTE O VALOR INTEIRO EM STRING
//string a = inteiro.ToString();//FORMA SIMPLIFICADA PARA CONVERTER O VALOR INTEIRO EM STRING

//Console.WriteLine(a);
















//CASTING IMPLÍCITO
//Forma na qual o código é convertido sem usar os argumentos de conversão.

//int a = 5;
//double b = a; //No caso um inteiro cabe no double.

//Console.WriteLine(b);

















//ORDEM DOS OPERADORES

//double a = 4 / 2 + 2; // =4
//double a = 4 / (2 + 2); // =1

//EM UMA OPERAÇÃO PRIMEIRO O PROGRAMA RESOLVE PARENTESES > EXPO0ENTE > MULTIPLICAÇÃO E DIVISÃO > ADIÇÃO E SUBTRAÇÃO

//Console.WriteLine(a);





















// //CONVERSÃO DE MANEIRA SEGURA

// string a = "15-"; //da forma convencional esse valor atribuido dá erro.

// //int b = Convert.ToInt32(a);//quando há um erro o código para aqui na leitura da variável.


// int b = 0;
// int.TryParse(a, out b); //Neste caso utilizamos o TryParse para que ele tente converter e se não houver a possibilidade de conversão ele retorna o valor de b para que o programa não pare na linha citada acima.

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");























//OPERADORES CONDICIONAIS
//Permite mudar o fluxo de execução do código indicando o caminho que ele deve percorrer.

// int quantidadeEmEstoque = 10;

// int quantidadeCompra = 4;


// if(quantidadeEmEstoque >= quantidadeCompra ) //Aqui coloco a condição que desejo na minha operação
// { //Caso minha condição acima seja viável eu peço na primeira chave a primeira saída
//     Console.WriteLine("Venda Realizada");
// }
// else
// {// Caso não seja possível eu peço a seguinte saída
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }


// //Código Incrementado
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a transação? {possivelVenda}");

// if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada");
// }
// else
// {
//     Console.WriteLine("Não foi possível realizar essa venda.");
// }

// // IF ANINHADO

// //quando colocamos o 0 na quantidade de compra o valor true é retornado, mas quero tratar esse código e dizer que o valor 0 é inválido, se eu coloco outro if ele retorna inválido mas em seguida diz que é valido, para isso uso o else if que aninha todas as condições em um esquema só.
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra; //Neste caso faço um tratamento para a pergunta "É possivel realizar a tranação?"

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a transação? {possivelVenda}");

// if (quantidadeCompra == 0){
//     Console.WriteLine("Venda Inválida!");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada!");
// }
// else
// {
//     Console.WriteLine("Não foi possível realizar essa venda.");
// }





















//SWITCH CASE

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();//Este comando permite que o console aguarde uma entrada do usuário para que possa prosseguir

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é uma vogal");
        break;
}

