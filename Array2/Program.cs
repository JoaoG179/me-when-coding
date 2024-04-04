using System;

class Intercalation{
    static void Main(){
        //inicializando os arrays e as variaveis
        int a, b, c, d, e;
        int [] numbers1 = new int[10];
        int [] numbers2 = new int [10];

        //perguntando os 10 primeiros numeros
        Console.WriteLine("Insira os 10 primeiros Números");
        for(a=0; a<10; a++){
            numbers1[a]=Convert.ToInt32(Console.ReadLine());
        }

        //perguntando os proximos 10
        Console.WriteLine("Insira outros 10 Números");
        for(b=0; b<10; b++){
            numbers2[b]=Convert.ToInt32(Console.ReadLine());
        }

        //juntando as 2 arrays
        int [] intercalated = new int [numbers1.Length+numbers2.Length];
        intercalated[0]=numbers1[0];

        //intercalando os 20 numeros em uma nova array
        for (c = 1, d = 1; c<numbers1.Length; c++){
            intercalated[d++] = numbers2[c-1];
            intercalated[d++] = numbers1[c];
        }

        //escrevendo a nova array
        e=0;
        intercalated[0]=intercalated[e];
        for (e=0; e<20; e++){
            Console.WriteLine(intercalated[e]);
        }
    }
}

//pq q o ultimo numero sempre fica como 0 :sob: :gun:
