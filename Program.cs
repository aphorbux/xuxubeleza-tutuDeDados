using Modelo;

/*              Questão 1
double N1 = Convert.ToDouble(Console.ReadLine());
double N2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Adicao.Somar(N1, N2));
*/



/*              Questão 3
double N1 = Convert.ToDouble(Console.ReadLine());
double N2 = Convert.ToDouble(Console.ReadLine());
double N3 = Convert.ToDouble(Console.ReadLine());

Maximus.Max(N1, N2, N3);
*/

int Menores = 0;
int Maiores = 0;

int[] notas = new int [20] {5,6,3,8,5,3,4,5,7,5,3,10,2,8,2,5,8,8,9,4};
    for(int i = 0; i < notas.Length; i++){
        Console.WriteLine(notas[i]);
        if(notas[i] >=6)
            Maiores++;

        if(notas[i] <6)
            Menores++;
    }

Console.WriteLine("Maiores: " + Maiores + "\nMenores: " + Menores);