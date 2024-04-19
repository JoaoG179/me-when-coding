/*Crie uma classe Elevador para armazenar as informações de um elevador de prédio. 
A classe deve armazenar o andar atual (terreo = 0), total de andares no predio (desconsiderando o terreo), capacidade do elevador e quantas pessoas estao presentes nele.
A classe deve também disponibilizar os seguintes metodos:
Inicializar: que deve receber como parametros a capacidade do elevador e o total de andares no predio (os elevadores sempre comecam no terreo e vazio);
Entrar: para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaco);

Sair: para remover uma pessoa do elevador (so deve remover se houver alguem dentro dele);

Subir: para subir um andar (nao deve subir se ja estiver no ultimo andar);

Descer: para descer um andar (nao deve descer se ja estiver no térreo);

Crie uma classe Elevador para armazenar as informacoes de um elevador de predio.*/
using System;

class MainClass:Elevador{
    static void Main(string[] args){
        int AA=0, AT, CAP, PES=0;
        string input;

        //criando o elevador
        Elevador elevador = new Elevador();

        //input do usuario
        Console.WriteLine("Quantos andares tem o predio?");
        AT = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a capacidade do elevador");
        CAP = Convert.ToInt32(Console.ReadLine());
        elevador.inicializarElevador(AA, AT, CAP, PES);
        elevador.imprimir();
        Console.WriteLine("Oque deseja fazer?");
        Console.WriteLine("Adicionar/Remover uma pessoa do elevador?/n ou /n Subir/Descer um andar?");
        //loop para checar oque o usuario deseja fazer
        while(true){
            input = Console.ReadLine();
            //if para subir e descer andares
            if (input == "Subir" || input == "subir"){
                elevador.subir();
                elevador.imprimir();
                Console.WriteLine("Digite o proximo comando. /n Subir/Descer - Adicionar/Remover - Finalizar.");
            }else if (input == "Descer" || input == "descer"){
                elevador.descer();
                elevador.imprimir();
                Console.WriteLine("Digite o proximo comando. /n Subir/Descer - Adicionar/Remover - Finalizar.");
            //if para adicionar e remover pessoas
            }else if (input == "Adicionar" || input == "adicionar"){
                elevador.entrar();
                elevador.imprimir();
                Console.WriteLine("Digite o proximo comando. /n Subir/Descer - Adicionar/Remover - Finalizar.");
            }else if (input == "Remover" || input == "remover"){
                elevador.sair();
                elevador.imprimir();
                Console.WriteLine("Digite o proximo comando. /n Subir/Descer - Adicionar/Remover - Finalizar.");
                //if para finalizar o programa
            }else if (input == "Finalizar" || input == "finalizar"){
                break;
            }else{
                Console.WriteLine("Esse não é um comando válido.");
            }
        }
        //imprimindo os status do elevador uma ultima vez no fim do processo
        elevador.imprimir();
    }
}