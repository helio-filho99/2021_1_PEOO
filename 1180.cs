using System; 

class URI {

    static void Main(string[] args) { 

      int n = int.Parse(Console.ReadLine());
      int menor = 0;
      int posicao = 0;

      string v = Console.ReadLine();
      string[] valores = v.Split(' ');

      int[] A = new int[n];

      for (int i = 0; i < n; i++) {

        A[i] = int.Parse(valores[i]);

        if (i == 0) {
          menor = A[i];
        }
        else {
          if (A[i] < menor) {
            menor = A[i];                         
            posicao = i;
            }
        }

      }
      Console.WriteLine($"Menor valor: {menor}");
      Console.WriteLine($"Posicao: {posicao}");
    }

}
