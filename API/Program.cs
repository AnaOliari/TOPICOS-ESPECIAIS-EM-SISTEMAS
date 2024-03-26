using API.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = 
[
  new Produto("Celular", "Android", 400.00),
  new Produto("Televisao", "Sansung", 500.00),
  new Produto("Celular", "Iphone", 1.500)
];
//End Points = Funcionalidades - JSON
//Post: http://localhost:5090/api/produto/cadastrar
//cadastrar um produto na lista 
//a)atraves das informações na url
//b) atraves das informações no corpo da requisição
//Realizar as operações alterações e remoção da lista 
app.MapPost("/api/produto/cadastrar", () => "Hello World!");

//GET: http://localhost:5090/api/produto/listar
app.MapGet("/api/produto/listar", () => produtos);

//GET: http://localhost:5090/api/produto/buscar/{nomedoproduto}
app.MapGet("/api/produto/buscar/{nome}", ([FromRoute] string nome) => 
{
  //Enpoint com varias linhas de codigo
  // Console.WriteLine(nome);
  for (int i = 0; i < produtos.Count; i++)
  {
    if (produtos[i].Nome == nome)
    {
      return Results.Ok(produtos[i]);
    }
  }
  return Results.NotFound();


});


// cadastrar um produto na lista produto 
app.Run();

// Produto produto = new Produto;
// // produto.setNome("Nome do produto");
// // Console.WriteLine(produto.getNome);

// produto.Nome = "Nome do produto";
// Console.WriteLine(produto.Nome);


