using Cards;


namespace C__Lab_3
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Задача №1");
            var allCards = Card.GenerateAllCards();
            Console.WriteLine(string.Join(", ", allCards));
            Console.WriteLine();
        }
        static void Task2()
        {
            Console.WriteLine("Задача №2");
            Console.WriteLine("Введите словами ранг и масть карты");
            String line = Console.ReadLine();
            if (Card.TryParse(line, out Card card))
            {
                Console.WriteLine("Принято: " + card.ToString() + "\n");
            }
            else
            {
                Console.WriteLine("Не распознано: " + line + "\n");
            }
            Console.WriteLine();
        }      
        static void Task3()
        {
            var randomDeck = Card.GenerateRandomDeck();

            var diamonds = randomDeck
                .Where(card => card.Suit == "♦")
                .OrderBy(card =>
                    card.Rank == "A" ? 1 : Array.IndexOf(Card.RankSymbols, card.Rank) + 2);

            var spades = randomDeck
                .Where(card => card.Suit == "♠")
                .OrderBy(card =>
                    card.Rank == "A" ? 14 : Array.IndexOf(Card.RankSymbols, card.Rank) + 2);

            var sortedDeck = diamonds.Concat(spades).ToList();

            Console.WriteLine("Изначальная случайная колода: \n" + string.Join(", ", randomDeck) + "\n" +
                "Отсортированная колода: \n" + string.Join(", ", sortedDeck));
        }  
        static void Print(List<Card> deck1, List<Card> deck2)
        {
            var merged = Card.MergeSeries(deck1, deck2);

            Console.WriteLine("Первая последовательность: " + string.Join(", ", deck1));
            Console.WriteLine("Вторая последовательность: " + string.Join(", ", deck2));
            Console.WriteLine("Результирующая серия: " + string.Join(", ", merged));
        }
        static void Task4()
        {
            Console.WriteLine("Задача №4");
            var deck1 = new List<Card> { new Card("A", "♥"), new Card("2", "♠"), new Card("3", "♦"), new Card("4", "♠"), new Card("5", "♥") };
            var deck2 = new List<Card> { new Card("6", "♠"), new Card("7", "♦"), new Card("8", "♠"), new Card("9", "♥") };

            Print(deck1, deck2);

            deck1 = new List<Card> { new Card("A", "♥"), new Card("2", "♠"), new Card("3", "♦"), new Card("4", "♠"), new Card("5", "♥") };
            deck2 = new List<Card> { new Card("7", "♠"), new Card("8", "♦"), new Card("9", "♠"), new Card("10", "♥") };

            Print(deck1, deck2);

            deck1 = new List<Card> { new Card("A", "♥"), new Card("2", "♠"), new Card("3", "♦"), new Card("4", "♠"), new Card("5", "♥") };
            deck1 = new List<Card> { new Card("6", "♥"), new Card("7", "♣"), new Card("8", "♦"), new Card("9", "♠") };

            Print(deck1, deck2);
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
    }
}
