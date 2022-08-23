using System;
class Hero
{
    public string Name;
    public string Sex;
    public string Race;
    public string Class;
    Dictionary<string, int> Skils = new Dictionary<string, int>()
    {
        {"Сила",0},
        {"Удача",0},
        {"Ловкость",0},
        {"Харизма",0},
        {"Эмпатия",0},
        {"Красноречие",0},
    };
}
class InRace
{
    public string Name;
    public string Ability; 
    public string Bonus; 
    public string Side;
    Dictionary<string, int> Skils = new Dictionary<string, int>()
    {
        {"Сила",0},
        {"Удача",0},
        {"Ловкость",0},
        {"Харизма",0},
        {"Эмпатия",0},
        {"Красноречие",0},
    };
}
class Program
{
    static void SelectRace(Hero myHero)
    {
        string [] namesRace = {"Маглы","Маги","Великаны","Гоблины","Русалки"};
        Console.WriteLine("Укажите вашу расу");
        Select(namesRace);
        string RaceHero = namesRace[Convert.ToInt32(Console.ReadLine())];
        Console.WriteLine("Ваша раса " + RaceHero);
        myHero.Race = RaceHero;    
    }
    static void SelectClass(Hero myHero)
    {
        string [] namesClass = {"Воин","Монах","Плут"};
        Console.WriteLine("Укажите ваш класс");
        Select(namesClass);
        string ClassHero = namesClass[Convert.ToInt32(Console.ReadLine())];
        Console.WriteLine("Ваш класс " + ClassHero);
        myHero.Class = ClassHero;    
    }
    static void SelectSex(Hero myHero)
    {
        string [] namesSex = {"Мужскй","Женский","Андрогин"};
        Select(namesSex);
        Console.WriteLine("Укажите ваш пол");
        string SexHero = namesSex[Convert.ToInt32(Console.ReadLine())];
        Console.WriteLine("Ваш пол " + SexHero);
        myHero.Sex = SexHero;    
    }
    static void Select(string[] words)
    {
        for (int i = 0; i < words.Length - 1; i++)
        {
            Console.Write(i + 1 + " - " + words[i] + ", ");
        }
        Console.WriteLine(words.Length + " - " + words[words.Length]);
        Console.WriteLine("");
    }
    static void Main(string[] args)
    {
        Hero myHero = new Hero();
        Console.WriteLine("Как вас зовут?");
        myHero.Name = Console.ReadLine();
        SelectRace(myHero);
        SelectSex(myHero);
        SelectClass(myHero);

        Console.WriteLine("Все наши характеристики");
        Console.WriteLine("Ваше имя " + myHero.Name);
        Console.WriteLine("Ваш пол " + myHero.Sex);
        Console.WriteLine("Ваша раса " + myHero.Race);
        Console.WriteLine("Ваш класс " + myHero.Class);
    }
}