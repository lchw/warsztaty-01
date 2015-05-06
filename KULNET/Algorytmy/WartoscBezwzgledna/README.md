# Forkujemy projekt
https://github.com/kulnet/warsztaty-01.git

# Klonujemy repozytorium
git clone https://github.com/kulnet/warsztaty-01.git

# Dodajemy odpowieni alias potrzeby przy wys³aniu danych
git remote add my https://github.com/kulnet/warsztaty-01.git

# Tworzymy ga³¹Ÿ
git checkout -b wartosc-bezwzgledna-gr-x

# Otwieramy solucje

# Tworzymy projekt testowy
Wa¿ne! Nale¿y ustawiæ poprawn¹ scie¿kê warsztaty-01/grupa-x/Algorytmy
Tworzymy Test jednostkowy o nazwie WartoscBezwzglednaTest

Przyk³ad
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
Nale¿y w po¿niejszym etapie pamiêtaæ o dodaniu odpowiedniej refenrecji do testu.

# Tworzymy projekt konsolowy o nazwie WartoscBezwzgledna
Pamiêtaæ o uwzglêdnieniu popranej scie¿ki

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
Powinny byæ na zielono :)

# Wykonaæ w programie
Wyœwietlenie w konsoli wartoœci bezwzglêdnych liczb 5, -1, 23.312, -455123.123, -0.001, 1, 0

# Pushujemy i robimy pull request
git status -sb
git add -A
git commit "grupa x - WartoscBezwzgledna"
git push -u my HEAD

# Po scaleniu projektu do repozytorium
git checkout master
git fetch origin
git rebase