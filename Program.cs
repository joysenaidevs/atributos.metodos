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
            personagem1.armadura = "Hulk supremo";

            Personagem personagem2 = new Personagem();

            personagem2.nome = "Joyce";
            personagem2.idade = 18;
            personagem2.armadura = "flash";

            Personagem personagem3 = new Personagem();
            personagem3.nome = "Paulo";
            personagem3.idade = 30;
            personagem3.armadura = "Poder da inpiração";

            Console.WriteLine($"Personagem 1 = {personagem1.nome} - {personagem1.Atacar()}");
            Console.WriteLine($"Personagem 2 = {personagem2.nome} - {personagem2.Defender()}");
            Console.WriteLine($"Personagem 3 = {personagem3.nome} - {personagem3.Anota()}");
        }
    }
}
