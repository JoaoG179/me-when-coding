using System;

class Superheroi:Personagem{
    //construtor
    public Superheroi(string nome, int categoria, int input, string nomeReal, int[] poderes, int PTotal) : base(nome, categoria, input, nomeReal, poderes, PTotal){
        this.NHero = NHero;
        this.NIRL = NIRL;
    }

    //metodo
    public override int poderTotal(int[] Powers){
        base.poderTotal(Powers);
        PT = PT*10/100;
        return PT;
    }
}