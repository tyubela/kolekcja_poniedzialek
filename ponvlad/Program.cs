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

List<int> WylosowanieLiczBezPowtrozenDoListy(int ileliczb)
{
    List<int> listaWylosowanych = new List<int>();
    //w listach mozna zmieniac rozmiar
    //w trakcie dzialania programu
    Random random = new Random();
    for (int i = 0; i < ileliczb; i++)
    {
        int liczba = random.Next(1,10);
        while(listaWylosowanych.Contains(liczba))
        {
            liczba = random.Next(1, 10);
        }
        listaWylosowanych.Add(liczba);
    }
    return listaWylosowanych;
}
void wypiszListe(List<int> listaLiczb)
{
    Console.WriteLine();
    Console.WriteLine("Lista:");
    for(int i = 0;i < listaLiczb.Count; i++)
    {
        Console.Write(listaLiczb[i] + ", ");
    }
}
List<int> wylosowane = WylosowanieLiczBezPowtrozenDoListy(7);
wypiszListe(wylosowane);

HashSet<int> wylosujLiczbyBezPowtorzenDoZbioru(int ileLiczb)
{
    HashSet<int> zbiorlosowych = new Hashset<int>();
    for (int i = 0; i < ileLiczb; i++)
    {
        zbiorlosowych.Add(random.Next(1, 10);
    }
    return zbiorlosowych;
}
void wypiszZbior(HashSet<int> zbiorLiczb)
{
    Console.WriteLine();
    Console.WriteLine("Zbior:");
    foreach (int element in zbiorLiczb)
    {
        Console.Write(element + ", ");
    }
}
HashSet<int> wylosowanyZbior = wylosujLiczbyBezPowtorzenDoZbioru(7);