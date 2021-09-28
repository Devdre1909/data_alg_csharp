using System;

namespace MutiplicationTable
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] table = new int[20, 20];

      for (int number = 1; number <= table.GetLength(0); number++)
      {
        for (int multiplier = 1; multiplier <= table.GetLength(1); multiplier++)
        {
          table[number - 1, multiplier - 1] = number * multiplier;
        }
      }

      for (int i = 0; i < table.GetLength(0); i++)
      {
        for (int j = 0; j < table.GetLength(1); j++)
        {
          Console.Write("{0,5}", table[i, j]);
        }
        Console.WriteLine();
      }

    }
  }
}
