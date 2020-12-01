using System;

namespace atributos.metodos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Personagem personagem1 = new Personagem();

            personagem1.nome = "Tsukamoto";
            personagem1.idade = 39;
            personagem1.armadura = "NOTA ZERO";
            personagem1.vida = 100;

            Personagem personagem2 = new Personagem();

            personagem2.nome = "Joyce";
            personagem2.idade = 18;
            personagem2.armadura = "INTELECTUAL";
            personagem2.vida2 = 100;

            Personagem personagem3 = new Personagem();
            personagem3.nome = "Paulo";
            personagem3.idade = 30;
            personagem3.armadura = "inspiração";
            personagem3.vida3 = 100;

            Console.WriteLine($"Personagem 1 = {personagem1.nome} - {personagem1.Atacar()}");
            Console.WriteLine($"Personagem 2 = {personagem2.nome} - {personagem2.Defender()}");
            Console.WriteLine($"Personagem 3 = {personagem3.nome} - {personagem3.Anota()}");
            Console.WriteLine($"Personagem 2 = {personagem2.nome} - {personagem2.Poder()}");

            Console.WriteLine($"Personagem 1 = {personagem1.nome} - {personagem1.Ataque()} ");
            // Console.WriteLine($"Vida util = {personagem1.vida}")
            Console.WriteLine($"Personagem 2 = {personagem2.nome} - {personagem2.Defesa()}");
            Console.WriteLine($"Personagem 3 = {personagem3.nome} - {personagem3.Inspiracao()}");
            Console.WriteLine($"Personagem 2 = {personagem1.nome} - {personagem1.ZeroDesativado()}");
            Console.WriteLine($"Personagem 1 = {personagem1.nome} - {personagem1.Demissao()}");


            //Batalha

            int vidaJogador1 = personagem1.Defender(personagem2.Atacar1());

            //Condicao

            if()
            
        }
    }
}
