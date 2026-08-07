// 1. Escreva um programa que leia ou gere um vetor de N elementos inteiros (N deve ser informado pelo
// usuário) e passe o mesmo como parâmetro para uma função que retorne a soma de seus elementos.

using System;
class Exercicio01
{
    static int[] GeraVetor(int tamanhoVetor)
    {
        Random rnd = new Random(); // instanciando a class Random, para utilizar seu método Next() para gerar um número aleatório
        int[] vetor = new int[tamanhoVetor];

        for(int i = 0; i < tamanhoVetor; i++){
            int intAleatorio = rnd.Next(100); //Limita o numero aleatorio gerado para um interio entre 0 a 99.
            vetor[i] = intAleatorio;
        }
        return vetor;
    }

    static int SomaVetor(int[] vetor)
    {
        int resultado = 0;
        for(int i = 0; i<vetor.Length; i++)
        {
            resultado += vetor[i];
        }
        return resultado;
    }

    static void Main()
    {
        Console.WriteLine("Insira o tamanho do vetor que deseja gerar: ");
        int tamanhoVetor = int.Parse(Console.ReadLine());

        int[] vetor = GeraVetor(tamanhoVetor);

        Console.WriteLine("---------------------------------");
        Console.WriteLine("Vetor Gerado:");
        for(int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Posição {i} = {vetor[i]}");
        }
        Console.WriteLine("---------------------------------");

        int soma = SomaVetor(vetor);
        Console.WriteLine("Soma dos números do vetor: " + soma);
    }
}