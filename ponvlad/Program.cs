Console.WriteLine("Hello, Pidar!");
// tablica 6 wartosci losowych 
//funkcja zwrata tablice a przekazujemy do niej liczbe elementow

int[] wylosujtablice(int liczbaElementow)
{
    int[] tablicawylosowana = new int[liczbaElementow];
    Random random = new Random();
    for (int i = 0;i < tablicawylosowana.Length; i++)
    {
        tablicawylosowana[i] = random.Next(1, 100);
    }
    return tablicawylosowana;
}
void wypiszTablice(int[] tablicaDoWypisanie)
{
    Console.WriteLine("Wylosowana tablica: ");
    for (int i = 0; i < tablicaDoWypisanie.Length; i++)
    {
        Console.Write(tablicaDoWypisanie[i] + ", ");
    }
}
int[] tablicatestowa = wylosujtablice(10);
wypiszTablice(tablicatestowa);

int[] wczytajliczbydotabliczy(int ileliczb)
{
    int[] tablicaZklawiatury = new int[ileliczb];
    for (int i = 0; i < ileliczb; i++)
    {
        Console.WriteLine("Podaj liczbe: " + i);
        tablicaZklawiatury[i] = int.Parse(Console.ReadLine());
    }
    return tablicaZklawiatury;
}
int[] tablicaWczytana = wczytajliczbydotabliczy(6);
wypiszTablice(tablicaWczytana);