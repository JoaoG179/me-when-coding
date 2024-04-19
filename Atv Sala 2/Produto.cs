using System;

class Produto{
  
  //variaveis
  private int preco, id, ultimo_id;
  private string nome;

  //inicializando variaveis
  private void inicializarProduto(int ID, int pri, int lastId, string name){
    id = ID;
    preco = pri;
    ultimo_id = lastId;
    nome = name;
  } 

  //metodos
  public void Exibe(){
    Console.WriteLine("Produto: {0}", this.nome);
    Console.WriteLine("ID: {0}", this.id);
    Console.WriteLine("Nome: {0}", this.nome);
  }

  public void ReajustaPreco(int percentual){
    //recebe um percentual e reajusta o preço do produto de acordo com o percentual
    this.preco = this.preco + (this.preco * percentual);
    Console.WriteLine("Novo preço: {0}", this.preco);
  }
}