using System;

public class Infos : Jogador{

    public static void Main(string[] args){
        string no, na, po;
        int wei, hei, age;

        //criando o jogador 1
        Jogador jogador1 = new Jogador();

        //pegando input do usuario
        Console.WriteLine("Qual o nome do jogador?");
        no = Console.ReadLine();
        Console.WriteLine("Qual a idade do jogador?");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual a posição do jogador?");
        po = Console.ReadLine();
        Console.WriteLine("Qual a nacionalidade do jogador?");
        na = Console.ReadLine();
        Console.WriteLine("Qual a altura do jogador?");
        hei = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual o peso do jogador?");
        wei = Convert.ToInt32(Console.ReadLine());

        //inicializando o jogador
        jogador1.inicializarJogador(no, po, na, wei, hei, age);
        jogador1.imprimir();
        jogador1.aposentar();
    }
}