using System;
using System.Data.Common;

class Jogo{
    public static void Main(string[] args){
        
        Superheroi superheroi = new Superheroi("Hulk", 0, 0, "Bruce Banner", [], 0);
        Vilao vilao = new Vilao("Abominavel", 0, 0, "Emil Blonsky", [], 0, 20);
        Confronto confronto= new Confronto();

        superheroi.adicionarPoder([]);
        vilao.adicionarPoder([]);
        confronto.Confrontada();

    }
}