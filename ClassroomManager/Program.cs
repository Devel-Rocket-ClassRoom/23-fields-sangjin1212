using System;
ScoreTracker math = new ScoreTracker("수학");
math.ShowScore();
Console.WriteLine();

math.SetScore(85);
math.AddBonus(10);
math.AddBonus(20);
math.SetScore(-10);
Console.WriteLine();
math.ShowScore();

class ScoreTracker
{
    const int MaxScore = 100;
    const int MinScore = 0;
    public readonly string name;
    private int score;
    private int BonusCount;

    public ScoreTracker(string name)
    {
        this.name = name;
    }

    public void SetScore(int score)
    {
        this.score += score;
        if (score < 0 || score > 100)
        {

            Console.WriteLine("점수는 0~100 사이여야 합니다.");
        }
        else
        {
            Console.WriteLine($"점수를 {score}점으로 설정 했습니다.");
        }
    }

    public void AddBonus(int bonus)
    {
        score += bonus;
        BonusCount++;
        if (score > 100)
        {
            score = MaxScore;
        }
        Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수: {score}");
        
    }

    public void ShowScore()
    {
        Console.WriteLine($"=== {name} ===");
        Console.WriteLine($"점수: {score} / {MaxScore}");
        Console.WriteLine($"보너스 적용 횟수: {BonusCount}");
    }
}