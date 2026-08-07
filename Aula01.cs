//Review Funções em C#

using System;
class Aula01
{
  static double notaFinalDisciplina(double notaReg, double notaProvaFinal)
  {
    double resultado;
    resultado = (notaProvaFinal * 2 + notaReg) / 3;
    return resultado;
  }
  static void Main()
  {
    double notaRegular, notaProvaFinal, mediaFinal;

    while (true)
    {
      Console.WriteLine("Entre com a nota regular e em seguida a nota final: ");
      notaRegular = double.Parse(Console.ReadLine());
      notaProvaFinal = double.Parse(Console.ReadLine());
      mediaFinal = notaFinalDisciplina(notaRegular, notaProvaFinal);
      Console.WriteLine($"A média final da disciplina é: {mediaFinal:F2}");
    }
  }
}