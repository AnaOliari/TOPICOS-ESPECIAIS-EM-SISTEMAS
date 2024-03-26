namespace API.Models;

public class Produto
{
  public Produto(string nome, string descricao, double preco)
  {
    Nome = nome;
    Descricao = descricao;
    Preco = preco;
  }
  //Aributo ou propriedade - nome e descrição
  public string? Nome { get; set;}
  public string? Descricao { get; set;}

  //prop+tab
  public double Preco { get; set; }


  // private string nome;
  // private string descrição;

  // public string getNome(){
  //   return this.nome;
  // }

  // public void setNome(string nome){
  //   this.nome = nome;
  // }
}
