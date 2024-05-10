using System;

class Personagem:Superpoder{

    //variaveis
    private string nome, nomeReal;
    private static int PTotal;
    private static int[] poderes = new int [4];
    private string[] poderNome = new string[4];

    //construtor
    public Personagem(string nome, int categoria, int input, string nomeReal, int[] poderes, int PTotal) : base(nome, categoria, input){
        this.nome = NHero;
        this.nomeReal = NIRL;
    }

    //get set
    public string NHero{
        get{return nome;}
        set{nome = value;}
    }
    public string NIRL{
        get{return nomeReal;}
        set{nomeReal = value;}
    }
    public static int[] Powers{
        get{return poderes;}
        set{poderes=value;}
    }
    public static int PT{
        get{return PTotal;}
        set{PTotal=value;}
    }
    public string[] PN{
        get{return poderNome;}
        set{poderNome=value;}
    }

    //metodos
    public void adicionarPoder(string[] PN){
        for (int i = 0; i<=4; i++){
        if (i < 4){
        getNomePoder(Name);
        PN[i] = this.Name;
        getCategoriaPoder(RNG, Cat);
        Powers[i]=Cat;
        Console.WriteLine("Deseja adicionar mais poderes?/n '1' = Sim");
            if (Input == 1){
                getNomePoder(Name);
                PN[(i)] = Name;
                Powers[(i)]=Cat;
            }else{
                Console.WriteLine("Comando errado.");
                }
            }else if (i >=4){
                Console.WriteLine("Você já tem o maximo de poderes selecionados.");
                break;
            }
        }
    }

    public virtual int poderTotal(int[] Powers){
        int PT = Powers[1] + Powers[2] + Powers[3] + Powers[4];
        return PT;
    }

}