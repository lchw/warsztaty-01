# warsztaty-01
Pierwsze warsztaty z nowego cyklu. 

Algorytm
--------
# Forkujemy projekt
https://github.com/kulnet/warsztaty-01.git

# Klonujemy repozytorium
git clone https://github.com/kulnet/warsztaty-01.git

# Dodajemy odpowieni alias potrzeby przy wysłaniu danych
git remote add my https://github.com/kulnet/warsztaty-01.git

# Tworzymy gałąź
git checkout -b wartosc-bezwzgledna-gr-x

# Otwieramy solucje

# Tworzymy projekt testowy
Ważne! Należy ustawić poprawną scieżkę warsztaty-01/grupa-x/Algorytmy
Tworzymy Test jednostkowy o nazwie WartoscBezwzglednaTest

Przykład
```csharp
    [TestClass]
    public class SomeTest
    {
        [TestMethod]
        public void SomeMethod()
        {
            // Inicjalizujemy
            var a = 3;
            var b = 3;

            // Wykonujemy metode
            var value = AddNumber(a, b);

            // Sprawdzamy za pomoca asercji
            Assert.AreEqual(5, value);
        }
}
```
Należy w pożniejszym etapie pamiętać o dodaniu odpowiedniej refenrecji do testu.

# Tworzymy projekt konsolowy o nazwie WartoscBezwzgledna
Pamiętać o uwzględnieniu popranej scieżki

# Tworzymy klase statyczna WartoscBezwzgledna
```csharp
public static class WartoscBezwzgledna
{
	public static int Abs(int value)
        {
            // implementacja
        }

        public static double Abs(double value)
        {
            // implementacja
        }
}
```

# Sprawdzamy testy
Powinny być na zielono :)

# Wykonać w programie
Wyświetlenie w konsoli wartości bezwzględnych liczb 5, -1, 23.312, -455123.123, -0.001, 1, 0

# Pushujemy i robimy pull request
git status -sb
git add -A
git commit "grupa x - WartoscBezwzgledna"
git push -u my HEAD

# Po scaleniu projektu do repozytorium
git checkout master
git fetch origin
git rebase

Alogrytmika
-----------
# Forkujemy projekt
https://github.com/kulnet/warsztaty-01.git

# Klonujemy repozytorium
git clone https://github.com/kulnet/warsztaty-01.git

# Dodajemy odpowieni alias potrzeby przy wysłaniu danych
git remote add my https://github.com/kulnet/warsztaty-01.git

# Tworzymy gałąź
git checkout master
git checkout -b silnia-gr-x

# Otwieramy solucje

# Tworzymy test
Tworzymy Test jednostkowy o nazwie SilniaTest

Przykład
```csharp
    [TestClass]
    public class SomeTest
    {
        [TestMethod]
        public void SomeMethod()
        {
            // Inicjalizujemy
            var a = 3;
            var b = 3;

            // Wykonujemy metode
            var value = AddNumber(a, b);

            // Sprawdzamy za pomoca asercji
            Assert.AreEqual(5, value);
        }
}
```
Dodatkowa podpowiedz do testów w przypadku wyjątków
```csharp
	    try
            {
                Assert.AreEqual(-1, silnia.SilniaRekurencja(-1));
            }
            catch(ArgumentException e)
            {
                Assert.IsTrue(true);
            }
```
Należy w pożniejszym etapie pamiętać o dodaniu odpowiedniej refenrecji do testu.

# Tworzymy projekt konsolowy o nazwie Silnia
Pamiętać o uwzględnieniu popranej scieżki

# Tworzymy klase SilniaRekurencja
```csharp
public class SilniaRekurencja
{
	public int Oblicz(int n)
        {
            // implementacja
        }
}
```

# Tworzymy klase SilniaIteracyjna
```csharp
public class SilniaIteracyjna
{
	public int Oblicz(int n)
        {
            // implementacja
        }
}
```
Pamiętajmy o warunku brzegowym w postaci liczb ujemnych!
```csharp
if(warunek == false)
	throw new ArgumentException("Tresc wyjatku");
// implementacja
```
Łapanie wyjątku
```csharp
try
{
 // kod
}
catch(Exception e)
{
 // reagujemy na wyjątek
}
```

# Sprawdzamy testy
Powinny być na zielono :)

# Wykonać w programie
Wyświetlenie w konsoli wartości silni dla liczb 17 rekurencyjnie i iteracyjnie
Dodatkowo wyświetlenie wyniku wykonywania obu operacji w milisekundach.

Klasa stoper
```csharp
var stoper = new Stoper();
stoper.Start();
stoper.Stop();
stoper.Restart();
stoper.Elapsed; // Zwraca czas
```

# Pushujemy i robimy pull request
git status -sb
git add -A
git commit "grupa x - Silnia"
git push -u my HEAD

# Po scaleniu projektu do repozytorium
git checkout master
git fetch origin
git rebase
