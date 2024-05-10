using System;
using System.Formats.Tar;
class Confronto{

    public void Confrontada(){
        int Poderheroi = Superheroi.PT;
        int Podervilao = Vilao.PT;
        if(Poderheroi > Podervilao){
            Console.WriteLine("1");
        }else if(Poderheroi>Podervilao){
            Console.WriteLine("2");
        }else if (Poderheroi==Podervilao){
            Console.WriteLine("0");
        }
    }
}