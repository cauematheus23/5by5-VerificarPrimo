int numero = 0,v;
v = 0;
do
{
    Console.WriteLine("Digite o valor para verificar se ele é primo ou não");
    numero = int.Parse(Console.ReadLine());

} while (numero <= 0);

for (int i = 1; i <= numero; i++)
{
    if ((numero % i) == 0)
    {
        v++;
    }
} if (v == 2)
{
    Console.WriteLine($"{numero} é primo");
}
else
{
    Console.WriteLine($"{numero} não é primo");
}