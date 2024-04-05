/*Escreva um programa em java que preencha um vetor com 15 números inteiros aleatórios entre 1 e 50. 
Verifique se o número 20 existe nesse vetor e retorne seu índice caso ele exista. 
*/

using System;
class Array5
{
    static void Main(String[]args){
        int min=1, max=50, a, b;
        Random rng = new Random();
        int[] randomNumbers = new int [15];
        for (a=0; a<randomNumbers.Length; a++){
            randomNumbers[a]=rng.Next(min, max);
            Console.WriteLine(randomNumbers[a]);
        }
        if (randomNumbers.Contains(20)){
            b = Array.IndexOf(randomNumbers, 20);
            Console.WriteLine("O vetor contem o número 20 !, Ele está no indice {0}", b);
        }else{
            Console.WriteLine("O vetor não Contem o número 20! :(");
        }
        
    }
}

