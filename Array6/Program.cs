/*Escreva um programa em java que preencha um vetor com 30 números inteiros aleatórios entre 1 e 100. 
Peça ao usuário para digitar um valor, verifique se este valor existe no vetor e remova ele do vetor.*/

using System;
using System.Globalization;
class Array6
{
    static void Main(String[]args){
        //inicializando as variaveis e vetores
        int min=1, max=100, a, b, c, e=0;
        Random rng = new Random();
        int[] randomNumbers = new int [30];

        //primeiro loop, para preencher o vetor
        for (a=0; a<randomNumbers.Length; a++){
            randomNumbers[a]=rng.Next(min, max);
            Console.WriteLine(randomNumbers[a]);
        }

        //começo da ação de remover o numero do vetor, pegando input do usuario
        Console.WriteLine("Digite um número para ser removido se estiver presente no vetor: ");
        b = Convert.ToInt32(Console.ReadLine());

        //loop checando se o input do usuario está presente no vetor
        if (randomNumbers.Contains(b)){
            c = Array.IndexOf(randomNumbers, b);
            Console.WriteLine("O vetor contem o número {0} ! Ele está no indice {1}!\nPortanto, ele será removido do vetor.", b, c);

            //transforma o vetor em lista para remover o input do usuario para depois transformar a lista de volta em vetor
            List<int> randomList = randomNumbers.ToList();
            randomList.RemoveAt(c);
            randomNumbers=randomList.ToArray();
            
            //"reseta o contador" do vetor
            randomNumbers[0]=randomNumbers[e];

            //imprime o novo vetor
            for(e=0; e<randomNumbers.Length; e++){
            Console.WriteLine(randomNumbers[e]);
            }

            //finaliza o codigo se o input não está no vetor
        }else{
            Console.WriteLine("O vetor não Contem o número {0}. :(", b);
        }
        
    }
}

