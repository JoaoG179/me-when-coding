using System;

public class Jogador{
    public int peso, altura, idade;
    public string nome, posicao, nacionalidade;


    //inicializando o jogador
    public void inicializarJogador(string no, string po, string na, int wei, int hei, int age){
        nome = no;
        idade = age;
        posicao = po;
        nacionalidade = na;
        altura = hei;
        peso = wei;
    }

    //metodo para imprimir os dados do jogador
    public void imprimir(){
        Console.WriteLine("Nome: {0}", this.nome);
        Console.WriteLine("Idade: {0} Anos", this.idade);
        Console.WriteLine("Posição: {0}", this.posicao);
        Console.WriteLine("Nacionalidade: {0}", this.nacionalidade);
        Console.WriteLine("Altura: {0}Cm", this.altura);
        Console.WriteLine("Peso: {0}Kg", this.peso);
    }

    //metodo para verificar se o jogador pode aposentar
    public void aposentar(){
        int tempo = 0;
        //calculando a idade para aposentar
        if (this.posicao == "defesa"){
            tempo = 40 - this.idade;
        }else if (this.posicao == "meio-campo"){
            tempo = 38 - this.idade;
        }else if (this.posicao == "atacante"){
            tempo = 35 - this.idade;
        }

        //verificando se o jogador pode aposentar
        if (idade >= 40 && posicao == "defesa"){
            Console.WriteLine("Aposentado, ou pode se aposentar");
        }else if (idade >= 38 && posicao == "meio-campo"){
            Console.WriteLine("Aposentado, ou pode se aposentar");
        }else if (idade >= 35 && posicao == "atacante"){
            Console.WriteLine("Aposentado, ou pode se aposentar");
        }else{
            Console.WriteLine("Faltam {0} anos para se aposentar", tempo);
        }
    }
}