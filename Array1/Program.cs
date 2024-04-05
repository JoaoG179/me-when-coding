/*Faça um programa que preencha um vetor com dez números inteiros, 
calcule e mostre os números primos e suas respectivas posições.*/



using System;
using System.Globalization;

class PrimeNumbers{
    static void Main(String[]args){
        int [] numbers = new int [10];
        int i, j, num, a;
        Console.WriteLine("Insira 10 números: ");
        for (i = 0; i<10; i++){
                numbers[i]=Convert.ToInt32(Console.ReadLine());
                for (num = numbers[i]; ; num++;){
                for (j = 2; j <= num; / 2; j++);{
        if (i % j ==0){
                    Console.WriteLine(numbers[i]);
                    }
                }
            }
        }
    }
}
//EU N SEI FAZER ISSO EU VOU CHORAR :SOB: