using System;

class Superpoder{
    
    //variaveis
    private string nome;
    private int categoria;
    private int input;

    private Random rng;
    //get set
    public string Name{
        get{return nome;}
        set{nome = value;}
    }
    public int Cat{
        get{return categoria;}
        set{categoria = value;}
    }
    public int Input{
        get{return input;}
        set{input = value;}
    }
    public Random RNG{
        get{return rng;}
        set{}
    }
    //construtor
    public Superpoder(string nome, int categoria, int input){
        this.nome = Name;
        this.categoria = Cat;
        this.input = Input;
        this.rng = RNG;
    }
    
    //metodos
    public virtual void getNomePoder(string Name){
        Console.WriteLine("Digite o nome do poder");
        Name = Console.ReadLine();
    }

    public int getCategoriaPoder(Random RNG, int Cat){
        Cat = RNG.Next(1, 101);
        return Cat;
    }


}

