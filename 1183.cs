using System; 

class URI {

    static void Main(string[] args) { 

        int colunas = 12;
        int linhas = 12;

        string O = Console.ReadLine();

        float soma = 0, aux1 = 0;
        
        float[,] valores = new float[colunas, linhas];

        for (int i = 0; i < linhas; i++) {

          for (int j = 0; j < colunas; j++) {

            valores[i, j] = float.Parse(Console.ReadLine());

            if (j > aux1) {

              soma += valores[i, j];
            }
          }
          aux1++;
        }
        if (O == "S") {
           Console.WriteLine($"{soma:0.0}");
        }
        else {
           Console.WriteLine($"{soma/66.0:0.0}");
        }
         

    }

}
