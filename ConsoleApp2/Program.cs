//funkcja zwraca czynniki pierwsze liczby
List<int> FindDivisors(int number)
{
    //tworzymy sitę do przechowywania dzielników (2,3,..)
    List<int> divisorList = new List<int>();
    while (number > 1)
    {
        //dopóki liczba nie jest równa 1 (nie skończyliśmy wymieniac dzielników)
        for (int i = 2; ; i++)
        {
            if (number % i == 0)
            {
                //znaleziono dzielnik - dopisz do listy
                divisorList.Add(i);
                //jeśli znalazłes to podziel liczbę
                number /= i;
                //wyjdź z fora jeśli znalazłeś
                break;
            }
        }
    }
    return divisorList;
    
}

int CompareLists(List<int> list1, List<int> list2)
{
    List<int> result = new List<int>();
    
    foreach (int i in list1)
    {
        //wyszukaj taką samą na drugiej liście
        //zwraca -1 jeśli nie ma
        int index = list2.IndexOf(i);
        if(index >= 0)
        {
           //znalazłem w drugiej tablicy
           //dopisz do wyników
           result.Add(i);
           //usuń z drugiej
           list2.RemoveAt(index);
        }
    }
    
    //przemnóż przez siebie elementy listy
    int finalResult = 1;
    foreach (int i in result) 
    {
        finalResult *= i;
    }
    return finalResult;
}

int result = CompareLists(FindDivisors(320), FindDivisors(450));
Console.WriteLine("Wynik: " + result);