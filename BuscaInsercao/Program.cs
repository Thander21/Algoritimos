using System.Diagnostics;


//Declara o arryavariaveis
int tamanho = 10;
int[] numerosAleatorio = new int[tamanho];
Random random = new Random();
Stopwatch stopwatch = new Stopwatch();

//Escreve Numeros na tela

static void EscreveNumerosTela(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} - ");
    }
}

//crias os numeros aleatorio
stopwatch.Start();

for (int i = 0; i < numerosAleatorio.Length; i++)
{
    numerosAleatorio[i] = random.Next(0, tamanho);
}

stopwatch.Stop();
Console.WriteLine("Tempo de Gerar Aleatorio: " + stopwatch.ElapsedMilliseconds);
EscreveNumerosTela(numerosAleatorio);


//Ordenarção por Inserção
stopwatch.Start();

for (int i = 0; i < numerosAleatorio.Length; i++)
{
    bool maior = false;
    if (maior == false)
    {
        if (i != 0)
        {
            if (numerosAleatorio[i] < numerosAleatorio[i - 1])
            {
                int temp = numerosAleatorio[i - 1];
                numerosAleatorio[i - 1] = numerosAleatorio[i];
                numerosAleatorio[i] = temp;
            }
            else maior = true;
        }
    }
}

stopwatch.Stop();
Console.WriteLine("Tempo de Ordenar Aleatorio: " + stopwatch.ElapsedMilliseconds);
EscreveNumerosTela(numerosAleatorio);


//BuscaPiorCaso On
stopwatch.Start();
for (int i = 0; i != numerosAleatorio[0]; i++)
{

}
stopwatch.Stop();
Console.WriteLine("Tempo Busca: " + stopwatch.ElapsedMilliseconds);