/*Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário
mostrando uma mensagem de erro e voltando a pedir as informações.*/

using System;

class name{
    static void Main(string[] args){
        string name, password;
        Console.Write("insira o nome de usuario: ");
        name=Console.ReadLine();
        for(;;){
            Console.Write("insira a senha: ");
            password=Console.ReadLine();
            if (password != name){
                Console.WriteLine("Processo completo.");
                break;
            }else{
                Console.WriteLine("Sua senha não pode ser igual ao seu nome de usuário. Tente novamente");
            }
        }
    }
}