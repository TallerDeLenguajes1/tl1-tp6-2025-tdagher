// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a = 10;
// b = a;
// Console.WriteLine("valor de a:" + a);
// Console.WriteLine("valor de b:" + b);


int numero;
bool esNumero;
string texto;
do
{
    Console.WriteLine("ingrese un numero valido para invertir");
    texto = Console.ReadLine();
    esNumero = int.TryParse(texto, out numero);
    if (!esNumero)
    {
        Console.WriteLine("ingrese un numero porfavor ");
    }
    if (numero <= 0)
    {
        Console.WriteLine("ingrese un numero mayor a 0 ");
    }
} while (!esNumero || numero <= 0);

string invertido = "";
for (int i = texto.Length - 1; i >= 0; i--)
{
    invertido += texto[i];
}

Console.WriteLine("su numero invertido es :" + invertido);