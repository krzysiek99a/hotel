// See https://aka.ms/new-console-template for more information
using hotel;

bool dziala = true;
string wybor;
Klient[] klienci = new Klient[50];
Rezerwacje[] rezerwacje = new Rezerwacje[50];
Pokoj[] pokoje =
{
    new Pokoj(4, 500),
    new Pokoj(2, 200),
    new Pokoj(4, 600),
    new Pokoj(1, 150),
    new Pokoj(2, 300),
    new Pokoj(4, 400)
};



do
{
    Console.WriteLine("Wybierz opcję:");
    Console.WriteLine("1. Dodaj klienta.");
    Console.WriteLine("2. Wyświetl klientów.");
    Console.WriteLine("3. Wyświetl pokoje.");
    Console.WriteLine("4. Zarezerwuj pokój.");
    Console.WriteLine("5. Wyswietl rezerwacje");
    Console.WriteLine("0. Zakończ");
    wybor = Console.ReadLine();

    switch (wybor)
    {
        case "1":
            DodajKlienta();
            break;
        case "2":
            WyswietlKlientow();
            break;
        case "3":
            WyswietlPokoje();
            break;
        case "4":
            Rezerwacja();
            break;
        case "5":
            WyswietlRezerwacja();
            break;

        default: break;
    }



} while (dziala);


void DodajKlienta()
{
    Console.WriteLine("Podaj imie:");
    var imie = Console.ReadLine();
    Console.WriteLine("Podaj Nazwisko");
    var nazwisko = Console.ReadLine();

    var tempKlient = new Klient(imie, nazwisko);

    var indeks = Array.IndexOf(klienci, null);
    klienci[indeks] = tempKlient;
}

void WyswietlKlientow()
{
    foreach (var item in klienci)
    {
        if (item == null) break;
        Console.WriteLine($"{item.IDK} {item.Imie} {item.Nazwisko} ");
        
    }
}

void WyswietlPokoje()
{
    foreach (var item in pokoje)
    {
        Console.WriteLine($"{item.ID} {item.IleOsob} {item.Cena} {item.CzyWolne}");
    }
}

void Rezerwacja()
{
    Console.WriteLine("Dla ilu osób");
    int ile = int.Parse(Console.ReadLine());

    foreach (var item in pokoje)
    {
        if(item.IleOsob >= ile) Console.WriteLine($"{item.ID} {item.IleOsob} {item.Cena} {item.CzyWolne}");
    }

    Console.WriteLine("Ktory pokój wybierasz:");
    int ktory = int.Parse(Console.ReadLine());

    pokoje[ktory - 1].CzyWolne = false;

    
    WyswietlKlientow();
    Console.WriteLine("Kto rezerwuje:");
    int kto = int.Parse(Console.ReadLine());

    DateTime start = DateTime.Now;
    Console.WriteLine("Na ile nocy:");
    int noce = int.Parse(Console.ReadLine());
    DateTime end = start.AddDays(noce);


    Rezerwacje nowa = new Rezerwacje(start, end, ktory, kto);

    var indeks = Array.IndexOf(rezerwacje, null);
    rezerwacje[indeks] = nowa;



}

void WyswietlRezerwacja(){

    foreach (var item in rezerwacje)
    {
        if (item == null) break;
        Console.WriteLine($"{item.DataStart.ToString("d")} {item.DataEnd.ToString("d")} {klienci[item.Klient - 1].Nazwisko}");
    }   
    

}
