/*Faça um programa que peça uma nota, entre zero e dez. 
Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.*/

using System;

class score{
    static void Main(string[] args){
        int score;
        for (;;)
        {
            Console.Write("Qual nota foi sua nota no teste?");
            if (int.TryParse(Console.ReadLine(), out score))
            {
                if (score >=0 && score <=10)
                {
                    Console.WriteLine("sua nota no teste foi de {0} pontos.", score);
                    break;
                }else
                {
                    Console.WriteLine("essa não é uma nota valida, tente novamente");
                }
            }else
            {
                Console.WriteLine("essa não é uma nota valida, tente novamente");
            }
        }
    }
}

