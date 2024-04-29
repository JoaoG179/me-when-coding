using System;

class Empregado:Pessoa{

    //variaveis
    private double salarioBase, imposto, salarioTotal;

    //get set
    public double Pay{
        get{return salarioBase;}
        set{salarioBase = value;}
    }
    public double Tax{
        get{return imposto;}
        set{imposto = salarioBase*10/100;}
    }
    public double TPay{
        get{return salarioTotal;}
        set{salarioTotal = value;}
    }

    //metodos
    public void inicializarSalario(double salarioBase, double imposto, double salarioTotal){
        Pay = salarioBase;
        Tax = imposto;
        TPay=salarioTotal;
    }
    public virtual void calcularSalario(){
        salarioTotal = salarioBase - imposto;
        Console.WriteLine("Salario empregado: {0}", TPay);
    }
}