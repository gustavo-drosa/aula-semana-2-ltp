//Vetores em C#
//Vetores e Funções C#

using System;
class Aula02
{

  static void LerVetor(int[] vetor)
  {
    Console.WriteLine("Entre com os dados do vetor: ");
    for(int i = 0; i < vetor.Length; i++)
    {
      Console.Write($"Array[{i}]: ");
      vetor[i] = int.Parse(Console.ReadLine());
    }
  }

  static void MostrarVetor(int[] vetor)
  {
     Console.WriteLine("Dados do Vetor:");
    for(int i = 0; i < vetor.Length; i++)
      Console.Write("|" + vetor[i]);

    Console.WriteLine("|");
  }

  static void GerarVetor(int[] vetor)
  {
    Random aleatorio = new Random();
    for(int i = 0; i < vetor.Length; i++)
      vetor[i] = aleatorio.Next(1,100);

  }

  static void Main()
  {
    int[] meuArray = new int[5];

    GerarVetor(meuArray);
    MostrarVetor(meuArray);
  }
}