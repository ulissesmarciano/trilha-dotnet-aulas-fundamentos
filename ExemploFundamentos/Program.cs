using ExemploFundamentos.Models; //Importando a localização da Classe.

//ORDEM DOS OPERADORES

//double a = 4 / 2 + 2; // =4
//double a = 4 / (2 + 2); // =1

//EM UMA OPERAÇÃO PRIMEIRO O PROGRAMA RESOLVE PARENTESES > EXPO0ENTE > MULTIPLICAÇÃO E DIVISÃO > ADIÇÃO E SUBTRAÇÃO

//Console.WriteLine(a);





















//CASTING IMPLÍCITO
//Forma na qual o código é convertido sem usar os argumentos de conversão.

//int a = 5;
//double b = a; //No caso um inteiro cabe no double.

//Console.WriteLine(b);





















//CONVERSÃO PARA STRING

//int inteiro = 5;
//string a = Convert.ToString(inteiro);//FORMA COMO SE CONVERTE O VALOR INTEIRO EM STRING
//string a = inteiro.ToString();//FORMA SIMPLIFICADA PARA CONVERTER O VALOR INTEIRO EM STRING

//Console.WriteLine(a);




















//CONVERTENDO TIPOS EM VARIÁVEIS
//O caso nos chama a fazer um Casting que é converter uma variável em outra.
//int a = Convert.ToInt32("5"); //Aqui convertemos uma informação que recebe uma string direto nosta variável e a converte para inteiro. Esse modo aceita o valor null (0).

//int a = int.Parse("5");//Faz o mesmo processo que acima sem dizer o que quero. Automaticamente converte para Int 32. Esse modo não aceita o valor null


//Poso utilizar o X.toParse onde X é o objeto que quero a conversão.
//Console.WriteLine(a);


















// int a = 10;// O sinal de igual é o operador de atribuição. No caso replicando eu digo que a está recebendo 10.
// int b = 20;

// int c = a + b;

// //COMBINAÇÃO DE OPERADORES
// //c = c + 5; //Como eu já declarei c não posso iniciar declarando ele como inteiro pois o mesmo já é. Quando utilizo esta equação eu estou subscrevendo c com outra operação.
// c += 5; //A forma mais simplificada de declarar o que está na linha de cima. 

// Console.WriteLine(c);












// //O TIPO DATETIME

// DateTime dataAtual = DateTime.Now; //Posso utilizar outros complementos para alterar minha data
// Console.WriteLine(dataAtual.ToString("dd/MM HH:mm" )); //Posso utilizar o tratamento para mostrar somente o que eu quero como o exemplo que retirei o ano e os segundos.














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











// //USANDO A CLASSE PESSOA
// Pessoa p1 = new Pessoa(); //Aqui eu declaro uma nova pessoa que utilizei o p1.
// p1.Nome = "Ulisses"; //quando utilizo p1. eu estou dizendo que o nome daquela pessoa declarada é o que vou utilizar agora.
// p1.Idade = 35;

// p1.Apresentar();
