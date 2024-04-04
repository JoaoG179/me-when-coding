/*Faça um programa que leia e valide as seguintes informações:
Nome: maior que 3 caracteres;
Idade: entre 0 e 150;
Salário: maior que zero;
Sexo: 'f' ou 'm';
Estado Civil: 's', 'c', 'v', 'd';*/

using System;

class Information{
    static void Main(string[] args){
        string name;
        int age;
        double salary;
        char sex, status;

        //pego o nome do usuario
        while(true){
            Console.Write("insira o nome de usuario(maior que 3 caracteres): ");
            name=Console.ReadLine();
            if (name.Length>3)
            {
                break;
            }else
            {
                Console.WriteLine("Wrong");
            }
        }

            // pego a idade do usuario
        while(true){
            Console.WriteLine("insira a sua idade(entre 0 - 150 anos): ");
            age=Convert.ToInt32(Console.ReadLine());
            if (age >0 && age <151)
            {
                Console.WriteLine("pog");
                 break;
            }else
            {
                Console.WriteLine("no");
            }
        }

            //pego o salario do usuario
            while(true){
                Console.WriteLine("qual o seu salario? (deve ser maior que 0): ");
                salary = Convert.ToDouble(Console.ReadLine());
                if(salary>0){
                    Console.WriteLine(salary);
                    break;
                }else
                {
                    Console.WriteLine("nuh uh !!!");
                }
            }

            //pego o sexo do usuario
            while(true){
                Console.WriteLine("Qual o seu sexo? (F ou M): ");
                sex=Console.ReadLine()[0];
                if(sex == 'M' || sex == 'm' || sex == 'f' || sex == 'F'){
                    Console.WriteLine(sex);
                    break;
                }else{
                    Console.WriteLine("blerp!");
                }
            }

            //pego o estado civil do usuario
            for(;;){
                Console.WriteLine("Qual o seu estado civil? ('S', 'C', 'V', 'D'): ");
                status=Console.ReadLine()[0];
                if(status == 'S' || status == 's' || status == 'C' || status == 'c' || status == 'V' || status == 'v' || status == 'D' || status == 'd'){
                    break;
                }else{
                    Console.WriteLine("bruh");
                }
            }

            Console.WriteLine("The way i can't use .ToLower on Char variables ICANT. well, here's the results:");
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(salary);
            Console.WriteLine(status);
    }
}