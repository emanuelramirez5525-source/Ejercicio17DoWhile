// Cree un programa que permita ingresar números y cuente cuántos de ellos son pares hasta que el usuario ingrese 0.

int num;
int positivo = 0;

do
{
    Console.WriteLine("Ingrese un número");
    num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        positivo++;
    }


} while (num != 0);

Console.WriteLine("La cantidad de números pares es = "+ positivo);
