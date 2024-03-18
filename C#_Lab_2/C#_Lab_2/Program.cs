//С клавиатуры вводится целое число N, после чего с клавиатуры вводится N целочисленных массивов с двумя элементами.
//Каждый массив соответствует одной кости домино.
//Требуется написать функцию, которая имеет сложность O(n) и которая посчитает и выведет на экран количество одинаковых костяшек домино.
//Учитывать, что костяшка может быть перевёрнута
struct Domino
{
    public int n1, n2;
    public readonly void Print()
    {
        Console.WriteLine('(' + n1.ToString() + ' ' + n2.ToString() + ')');
    }
};

class laba3
{
    public static void Main(String[] args)
    {
        string str;
        string[] str2;
        Console.Write("Введите количество доминошек: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Domino[] domino = new Domino[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Введите значения " + (i + 1) + " фишки домино: ");
            str = Console.ReadLine();
            str2 = str.Split(' ');
            domino[i].n1 = Convert.ToInt32(str2[0]);
            domino[i].n2 = Convert.ToInt32(str2[1]);
            if (domino[i].n1 > domino[i].n2)
                (domino[i].n1, domino[i].n2) = (domino[i].n2, domino[i].n1);
        }

        Console.WriteLine("Количество повторяющихся фишек домино: " + func(domino));
    }
    public static int func(Domino[] domino)
    {
        Dictionary<Domino, int> dict = new Dictionary<Domino, int>();
        foreach (var fishka in domino)
        {
            if (!dict.ContainsKey(fishka))
                dict.Add(fishka, 1);
            else
                dict[fishka]++;
        }
        int res = 0;
        foreach (var fishka in dict)
            if (fishka.Value != 1)
            {
                fishka.Key.Print();
                res += fishka.Value;
            }
        return res;
    }
}