using System;
class Array3
{
    static void Main(String[]args){
        int min=0, max=1000, a, sum;
        Random rng = new Random();
        int[] randomNumbers = new int [10];
        for (a=0; a<randomNumbers.Length; a++){
            randomNumbers[a]=rng.Next(min, max);
            Console.WriteLine(randomNumbers[a]);
        }
        sum = randomNumbers.Sum() / randomNumbers.Length;
        Console.WriteLine(sum);
    }
}

