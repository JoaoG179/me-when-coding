class Fornecedor:Pessoa{

    //variaveis
    private double valorCredito, valorDivida;

    //get set
    public double Cred{
        get{return valorCredito;}
        set{valorCredito = value;}
    }
    public double Div{
        get{return valorDivida;}
        set{valorDivida = value;}
    }    

    //metodo
    public void inicializarSaldo(double valorCredito, double valorDivida){
        Cred = valorCredito;
        Div = valorDivida;
    }
    public void obterSaldo(){
        double saldo = Cred-Div;
        Console.WriteLine("Saldo: {0}", saldo);
    }
}
    