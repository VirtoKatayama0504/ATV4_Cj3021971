using System.ComponentModel.Design;

namespace ATV4_Cj3021971
{
    internal class Program
    {
        static void Main(string[] args)
        {



            /*
            Console.WriteLine("Digite um numero inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o outro numero inteiro: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a operação - 1:Adição 2:Subtração 3:Multiplicação 4:Divisao");
            int num = int.Parse(Console.ReadLine());
            int adicao = (n1 + n2);
            int subtracao = (n1 - n2);
            int vezes = (n1 * n2);
            int divisao = (n1 / n2);
            switch (num)
            {
                case 1:
                    
                    Console.WriteLine("soma: {0}", adicao);
                    break;
                 
                case 2:
                    
                    Console.WriteLine("subtracao: {0} ", subtracao);
                    break;
                case 3:
                    
                    Console.WriteLine("multiplicaçao: {0} ", vezes);
                    break;
                case 4:
                    
                    Console.WriteLine("Divisao: {0}", divisao);
                    break;
                default:
                    Console.WriteLine("opção invalida");
                    break;
            }   
            

            Console.WriteLine("Exercicio 1");
            Console.WriteLine("Digite um numero de 1 a 7");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                    case 3:
                    Console.WriteLine("Terça");
                    break; 
                    case 4:
                    Console.WriteLine("Quarta");
                    break;
                    case 5:
                    Console.WriteLine("Quinta");
                    break;
                    case 6:
                    Console.WriteLine("Sexta");
                    break;
                    case 7:
                    Console.WriteLine("Sabado");
                    break;
                    default: Console.WriteLine("Opçao invalida");
                        break;
            }
            
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("Digite o valor da compra");
            float compra = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a forma de pagamento: 1-A vista no dinheiro 2-A vista no PIX 3-Compra no debito 4-Cartao de Credito");
            float valor = float.Parse(Console.ReadLine());
            switch (valor)
            {
                case 1:
                    float vista = compra -((compra / 100) * 15);
                    Console.WriteLine("O valor final da compra é de: {0} ", vista); 
                    break;
                    case 2:
                    float pix = compra - ((compra / 100) * 10) ;
                    Console.WriteLine("O valor final da compra é de {0}" , pix);
                    break;
                    case 3:
                    float debito = ((compra / 100) * 5) + compra;
                    Console.WriteLine("O valor final da compra é de {0}", debito);
                        break;
                    case 4: 
                    float credito = ((compra / 100) * 10) + compra;
                    Console.WriteLine("O valor final da compra é de {0}", credito);
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
            
            Console.WriteLine("Exercicio 3");
            Console.WriteLine("Digite um numero entre 1 a 12");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("O ano é bissexto? 1-SIM 2-NAO");
            int ano = int.Parse(Console.ReadLine());
            if (ano == 1)
            {
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Janeiro, 31 dias");
                        break;
                    case 2:
                        Console.WriteLine("Fevereiro, 29 dias");
                        break;
                    case 3:
                        Console.WriteLine("Março, 31 dias");
                        break;
                    case 4:
                        Console.WriteLine("abril, 30 dias");
                        break;
                    case 5:
                        Console.WriteLine("maio, 31 dias");
                        break;
                        case 6:
                        Console.WriteLine("Junho, 30 dias");
                        break;
                    case 7:
                        Console.WriteLine("Julho, 31 dias");
                        break;
                    case 8:
                        Console.WriteLine("Agosto, 31 dias");
                        break;
                    case 9:
                        Console.WriteLine("Setembro, 30 dias");
                        break;
                    case 10:
                        Console.WriteLine("Outubro, 30 dias");
                            break;
                    case 11:
                        Console.WriteLine("Novmebro, 30 dias");
                        break;
                    case 12:
                        Console.WriteLine("Dezembro, 31 dias");
                        break;
                        default: Console.WriteLine("Opção invalida");
                        break;


                }
            }
            if(ano == 2)
            {
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Janeiro, 31 dias");
                        break;
                    case 2:
                        Console.WriteLine("Fevereiro, 28 dias");
                        break;
                    case 3:
                        Console.WriteLine("Março, 31 dias");
                        break;
                    case 4:
                        Console.WriteLine("abril, 30 dias");
                        break;
                    case 5:
                        Console.WriteLine("maio, 31 dias");
                        break;
                    case 6:
                        Console.WriteLine("Junho, 30 dias");
                        break;
                    case 7:
                        Console.WriteLine("Julho, 31 dias");
                        break;
                    case 8:
                        Console.WriteLine("Agosto, 31 dias");
                        break;
                    case 9:
                        Console.WriteLine("Setembro, 30 dias");
                        break;
                    case 10:
                        Console.WriteLine("Outubro, 30 dias");
                        break;
                    case 11:
                        Console.WriteLine("Novmebro, 30 dias");
                        break;
                    case 12:
                        Console.WriteLine("Dezembro, 31 dias");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
              
    

    
            }
            
            Console.WriteLine("Exercicio 4");
            Console.WriteLine("Digite um numero inteiro");
            int n1x = int.Parse(Console.ReadLine());
            Console.WriteLine("DIgite outro numero inteiro");
            int n2x = int.Parse(Console.ReadLine());
            Console.WriteLine("[+] [-] [*] [/] [^]");
            string nnn = Console.ReadLine();
            switch (nnn)
            {
                case "+":
                    int adicaox = n1x + n2x;
                    Console.WriteLine("Adição {0}", adicaox); break;
                    case "-":
                    int menosx = n1x- n2x;
                    Console.WriteLine("Subtração {0^}", menosx); break;
                    case "*":
                    int vezesx = n1x * n2x;
                    Console.WriteLine("Vezes`{0}", vezesx); break;
                    case "/":
                    float dividirx = n1x / n2x;
                    Console.WriteLine("Dividido {0}", dividirx); break;
                case "^":
                    Math.Pow(n1x, n2x);
                    Console.WriteLine("Exponenciacao {0}", Math.Pow(n1x, n2x));

                    break;
                    default: Console.WriteLine("opção invalida");
                    break;
            }
            */
            Console.WriteLine("Exercicio 5");
            Console.WriteLine("Digite o salario");
            float salariox = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o cargo do funcionario(com numeros)");
            int cargo = int.Parse(Console.ReadLine());
            switch (cargo)
            {
                case 1:
                    double prof = ((salariox /100) * 7.5) +salariox;
                    Console.WriteLine("O salario apos o aumento é {0}", prof);
                        break;

            }


                
             
               
            
            

            
        } 
    }
}
