using System;

class Vilao:Personagem{

    //variavel
    private int tempoDePrisao;

    //get set
    public int PrisonTime{
        get{return tempoDePrisao;}
        set{tempoDePrisao=value;}
    }

    //construtor
    public Vilao(string nome, int categoria, int input, string nomeReal, int[] poderes, int PTotal, int tempoDePrisao) : base(nome, categoria, input, nomeReal, poderes, PTotal){
        this.NHero = NHero;
        this.NIRL = NIRL;
        this.PrisonTime=PrisonTime;
    }

    //metodo
    public override int poderTotal(int[] Powers){
        int PT = (Powers[1] + Powers[2] + Powers[3] + Powers[4])*100/10;
        return PT;
    }
}