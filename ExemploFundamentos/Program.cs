using ExemploFundamentos.Models; //Importando a localização da Classe.



// //OPERADORES DE ATRIBUIÇÃO
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
