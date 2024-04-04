using System;

namespace Desafio_tecnico
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;

            do
            {
                Console.WriteLine("Escolha o que deseja ");
                Console.WriteLine("1. Personagem");
                Console.WriteLine("2. Grupo Jura");
                Console.WriteLine("3.Papo no grupo Jura");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Sobre o personagem");
                        Console.WriteLine("Ola meu nome Scorpion");
                        Console.WriteLine("Minha Arma e Ninja Sword");
                        Console.WriteLine("Umas das minhas habilidades e Teletransporte");
                        break;

                    case "2":
                        Console.WriteLine("Sobre o Grupo Jura");
                        Console.WriteLine("E um Grupo de jovens Catolicos");
                        Console.WriteLine("Um Grupo focado em Oracao");
                        break;

                    case "3":
                        Console.WriteLine("OLa eu sou o Scorpion e vim da papo no Jura,Vou comecar com uma dinamica,A Dinamica e pensar em nomes de Santos e Santas");
                        Console.Write("Vou citar alguns Santos,entao ecolha quais santos deseja:(1 - Homens , 0 - Mulheres):");
                        int PapoJura = Convert.ToInt32(Console.ReadLine());
                        string[] nomes = { "Sao Joao ", "Sao Jose", "Sao Pedro", "Sao Sebastiao", "Santo Antonio" };
                        string[] nomes1 = { "Santa Maria ", "N S Aprecida", "Santa Rita de Cassia", "Santa Terezinha", "Santa Barbara " };
                        for (int i = 0; i < 5; i++)
                        {
                            if (PapoJura == 1)
                            {
                                Console.WriteLine("Os Santos sao " + nomes[i]);
                            }
                            else
                            {
                                Console.WriteLine("As Santas sao " + nomes1[i]);
                            }
                        }
                        break;
                }

            } while (escolha != "sair");
        }
    }
}
