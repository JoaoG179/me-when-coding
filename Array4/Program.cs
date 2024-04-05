/*Escreva um programa em java que preencha um vetor com 20 números inteiros aleatórios entre 1 e 30 
depois verifique se o número 25 existe neste vetor.*/

using System;
class Array4
{
    static void Main(String[]args){
        int min=1, max=30, a;
        Random rng = new Random();
        int[] randomNumbers = new int [20];
        for (a=0; a<randomNumbers.Length; a++){
            randomNumbers[a]=rng.Next(min, max);
            Console.WriteLine(randomNumbers[a]);
        }
        if (randomNumbers.Contains(25)){
            Console.WriteLine("O vetor contem o número 25 !");
        }else{
            Console.WriteLine("O vetor não Contem o número 25! :(");
        }
        
    }
}

