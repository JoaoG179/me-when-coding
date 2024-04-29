using System;

class MainClass:Administrador{
    static void Main(string[] args){
        string Name,Birth,Add,Phone;
        int ID=1, CPF;
        double Pay=5000, Tax=0, Cost, TPay=0, Prod=0, CommV=0, Comm=0, Sell=0;
        

        Empregado empregado = new Empregado();
        Administrador administrador = new Administrador();
        Operario operario = new Operario();
        Vendedor vendedor = new Vendedor();


        //input usuario
        Console.WriteLine("Qual o seu nome?");
        Name = Console.ReadLine();
        Console.WriteLine("Qual a sua data de nascimento?");
        Birth = Console.ReadLine();
        Console.WriteLine("Qual o seu endereço?");
        Add = Console.ReadLine();
        Console.WriteLine("Qual o seu número de telefone?");
        Phone = Console.ReadLine();
        Console.WriteLine("Qual o seu CPF?");
        CPF = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual a ajuda de custo do Admin?");
        Cost = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual o valor de Produção?");
        Prod = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual o valor de Venda?");
        CommV = Convert.ToDouble(Console.ReadLine());



        //metodos
        empregado.inicializarPessoa(Name, Birth, Add, Phone, ID, CPF);
        empregado.inicializarSalario(Pay, Tax, TPay);
        empregado.imprimir();
        empregado.calcularSalario();
        administrador.inicializarAdmin(Cost);
        administrador.calcularSalario();
        operario.inicializarOperario(Prod,Comm);
        operario.calcularSalario();
        vendedor.inicializarVendedor(Sell,CommV);
        vendedor.calcularSalario();
        //to perdendo o valor do salario do empregado e n sei resolver :sob:
    }
}