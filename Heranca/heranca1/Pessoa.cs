using System;

class Pessoa{

    //variaveis
    private string nome, nascimento, endereco, telefone;
    private int numero, cpf;

    //get set
    public string Name{
        get{return nome;}
        set{nome = value;}
    }
    public string Birth{
        get{return nascimento;}
        set{nascimento = value;}
    }
    public string Add{
        get{return endereco;}
        set{endereco = value;}
    }
    public string Phone{
        get{return telefone;}
        set{telefone = value;}
    }
    public int ID{
        get{return numero;}
        set{numero = value;}
    }
    public int CPF{
        get{return cpf;}
        set{cpf = value;}
    }

    //metodo
    public void inicializarPessoa(string nome, string nascimento, string endereco, string telefone, int numero, int cpf){
        Name = nome;
        Birth = nascimento;
        Add = endereco;
        Phone = telefone;
        ID = numero;
        CPF = cpf;
    }
    public void imprimir(){
        Console.WriteLine("Nome: {0}",Name);
        Console.WriteLine("Data de Nascimento: {0}", Birth);
        Console.WriteLine("Endereço: {0}", Add);
        Console.WriteLine("Número de Telefone: {0}", Phone);
        Console.WriteLine("ID: {0}", ID);
        Console.WriteLine("CPF: {0}", CPF);
    }
}