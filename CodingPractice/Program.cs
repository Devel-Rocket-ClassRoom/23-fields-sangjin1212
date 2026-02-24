using System;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;

//1
Player player = new Player();
player.ShowStatus();
//2
Character hero = new Character();
hero.name = "용사";
hero.level = 10;
Console.WriteLine(hero.name);
Console.WriteLine(hero.level);
//3
Character1 character1 = new Character1();
character1.SetInfo("용사", 10);
character1.ShowInfo();
//4
Player1 player1 = new Player1();
player1.ShowStatus();
//5
Say say = new Say();
say.Hi();
//6
Schedule schedule = new Schedule();
schedule.PrintWeekDays();
//7
DefaultValues defaultValues = new DefaultValues();
defaultValues.ShowDefaults();
//8
Counter c1 = new Counter();
Console.WriteLine($"현재 카운트 {Counter.count}");
Counter c2 = new Counter();
Console.WriteLine($"현재 카운트 {Counter.count}");
Counter c3 = new Counter();
Console.WriteLine($"현재 카운트 {Counter.count}");
//9
Player2 p1 = new Player2("용사");
Player2 p2 = new Player2("마법사");
Player2 p3 = new Player2("궁수");

Console.WriteLine(p1.name);
Console.WriteLine(p2.name);
Console.WriteLine(p3.name);
Console.WriteLine($"총 플레이어 수: {Player2.totalCount}");

//10
GameConflg gameConflg = new GameConflg(4);
gameConflg.ShowConflg();

//11
Example example = new Example();
example.ShowValues();

//12
Player3 player3 = new Player3();
player3.SetInfo("용사", 10);
player3.SetInfo();

//13
GameCharacter hero1 = new GameCharacter("용사", 15);
GameCharacter mage = new GameCharacter("마법사", 25);
hero1.ShowStatus();
Console.WriteLine();
mage.ShowStatus();
Console.WriteLine();
hero1.TakeDamge(30);
hero1.TakeDamge(50);
hero1.TakeDamge(50);
GameCharacter.ShowTotalCharacter();



//1
class Player
{
    string name;
    int health;

    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"체력: {health}");
    }
}
//2
class Character
{
    public string name;
    public int level;
}

//3
class Character1
{
    private string name;
    private int level;

    public void SetInfo(string n, int l)
    {
        name = n;
        level = l;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"레벨: {level}");
    }
}

//4
class Player1
{
    private string name = "이름없음";
    private int health = 100;
    private int level = 1;

    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"체력: {health}");
        Console.WriteLine($"레벨: {level}");
    }
}

//5
class Say
{
    private string message = "안녕하세요";

    public void Hi()
    {
        message = "반갑습니다";
        Console.WriteLine(message);
    }
}

//6
class Schedule
{
    string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

    public void PrintWeekDays()
    {
        foreach (var day in weekDays)
        {
            Console.Write(day + " ");
        }
        Console.WriteLine();

    }

}

//7
class DefaultValues
{
    private int number;
    private bool flag;
    private string text;

    public void ShowDefaults()
    {
        Console.WriteLine($"number: {number}");
        Console.WriteLine($"flag: {flag}");
        Console.WriteLine($"text: {(text == null ? "null": text) }");
    }
}

//8
class Counter
{
    public static int count;

    public  Counter()
    {
        count++;
    }
}
//9
class Player2
{
    public string name;
    public static int totalCount;

    public Player2(string n)
    {
        name = n;
        totalCount++;
    }
}
//10
class GameConflg
{
    public readonly string version = "1.0.0";
    public readonly int maxPlayers;

    public GameConflg(int max)
    {
        maxPlayers = max;
    }

    public void ShowConflg()
    {
        Console.WriteLine($"버전: {version}");
        Console.WriteLine($"최대 플레이어: {maxPlayers}");
    }
}

//11
class Example
{
    public const double Pi = 3.14159;
    public readonly DateTime createdAt = DateTime.Now;

    public void ShowValues()
    {
        Console.WriteLine($"원주율: {Pi}");
        Console.WriteLine($"생성 시간: {createdAt}");
    }
}

//12
class Player3
{
    private string name;
    private int level;

    public void SetInfo(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    public void SetInfo()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"레벨: {level}");
    }
}

class Person
{
    private string name = "홍길동";
    private const int age = 21;
    private readonly string Nickname = "길동이";
    private string[] sites = { "네이버", "구글" };

    public void ShowProfile()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"나이: {age}");
        Console.WriteLine($"닉네임: {Nickname}");
        Console.WriteLine($"사이트: {sites}");
    }
}

class GameCharacter
{
    private string name;
    private int health;
    private int attack;

    private static int count = 0;
    private readonly int maxhealth = 100;
    private const int minhealth = 0;

    public GameCharacter(string name, int attack)
    {
        this.name = name;
        this.attack = attack;
        this.health = maxhealth;
        count++;
    }

    public void TakeDamge(int damge)
    {
        health = health - damge;
        if (health < minhealth)
        {
            health = minhealth;
        }
        Console.WriteLine($"{name}이(가) {damge} 데미지를 받음! 남은 체력 {health}");
    }

    public void ShowStatus()
    {
        Console.WriteLine($"=== {name} ===");
        Console.WriteLine($"체력: {health}/{maxhealth}");
        Console.WriteLine($"공격력: {attack}");
    }

    public static void ShowTotalCharacter()
    {
        Console.WriteLine($"총 캐릭터 수: {count}");
    }
}