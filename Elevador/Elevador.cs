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

class Elevador{
    //variaveis
    private int andarAtual, andarTotal, capacidade, pessoas;

    //gets e sets
    public int AA{
        get {return andarAtual;}
        set {andarAtual=value;}
    }public int AT{
        get {return andarTotal;}
        set {andarTotal=value;}
    }public int CAP{
        get {return capacidade;}
        set {capacidade=value;}
    }public int PES{
        get {return pessoas;}
        set {pessoas=value;}
    }

    //inicializando o elevador
    public void inicializarElevador(int andarAtual, int andarTotal, int capacidade, int pessoas){
        AA = andarAtual = 0;
        AT = andarTotal;
        CAP = capacidade;
        PES = pessoas = 0;
    }
    
    //metodos
    //imprimindo os status do elevador
    public void imprimir(){
        Console.WriteLine("Andar Atual: {0}", this.andarAtual);
        Console.WriteLine("Total de andares do predio: {0}", this.andarTotal);
        Console.WriteLine("Quantidade de pessoas presentes no elevador: {0}", this.pessoas);
        Console.WriteLine("capacidade total do elevador: {0}", this.capacidade);
    }

    //acrescentando uma pessoa ao elevador
    public void entrar(){
        if (pessoas<capacidade){
            pessoas++;
            Console.WriteLine("Uma pessoas entrou no elevador. {0} pessoas estão dentro do elevador", this.pessoas);
        }else{
            Console.WriteLine("O elevador está cheio.");
        }
    }

    //removendo uma pessoa do elevador
    public void sair(){
        if (pessoas>0){
            pessoas--;
            Console.WriteLine("Uma pessoas siu do elevador. {0} pessoas estão dentro do elevador", this.pessoas);
        }else{
            Console.WriteLine("O elevador está já vazio.");
        }
    }
        //Subindo um andar
        public void subir(){
        if (andarAtual<andarTotal){
            andarAtual++;
            Console.WriteLine("O elevador subiu ate o andar {0}.", this.andarAtual);
        }else{
            Console.WriteLine("O elevador ja está no ultimo andar.");
        }
    }
        //descendo um andar
        public void descer(){
        if (andarAtual>0){
            andarAtual--;
            Console.WriteLine("O elevador desceu ate o andar {0}", this.andarAtual);
        }else{
            Console.WriteLine("O andar já está no terreo");
        }
    }
}

