// See https://aka.ms/new-console-template for more information
using Aula12Classes;

Console.WriteLine("Welcome to fuck world!");

/*Personagem guerreiro = new Personagem();
guerreiro.nome = "Moisés";
guerreiro.raca = "Humano";
guerreiro.poder = 100;

guerreiro.mostra(); 

Personagem mago = new Personagem();
mago.nome = "Marinete";
mago.raca = "Orc";
mago.poder = 150;

mago.mostra();

Personagem arqueiro = new Personagem();
arqueiro.nome = "Regis";
arqueiro.raca = "Elfo";
arqueiro.poder = 130;

arqueiro.mostra();
*/

//Produtos

Produto chocolate = new Produto();
chocolate.nome_produto = "Chocolate";
chocolate.descricao = "Feito com cacau made in Brasil";
chocolate.quantidade = 500;
chocolate.preco = 5.50;
chocolate.status = true;

chocolate.mostraProduto();

Produto refrigerante = new Produto();
refrigerante.nome_produto = "Refrigerante";
refrigerante.descricao = "Feito com açucar e aguá gasificada com sabor";
refrigerante.quantidade = 500;
refrigerante.preco = 7;
refrigerante.status = true;

refrigerante.mostraProduto();
refrigerante.desativaProduto();
refrigerante.mostraProduto();

Produto salgadinho = new Produto();
salgadinho.nome_produto = "Salgadinho";
salgadinho.descricao = "Feito com milho e sal";
salgadinho.quantidade = 500;
salgadinho.preco = 3.50;
salgadinho.status = true;

salgadinho.mostraProduto();
salgadinho.desativaProduto();
salgadinho.mostraProduto();
Console.ReadLine();
