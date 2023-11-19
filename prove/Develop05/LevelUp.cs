class LevelUp
{
    private int _totalPoints;
    List<int> lvls = new List<int>();
    private int lvl = 0;

    public LevelUp(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    public void lvlUp()
    {
        lvls.Add(0);
        for (int i = 0; i < 10; i++)
        {
            lvl += 1000;
            lvls.Add(lvl);
        }
        if (_totalPoints < lvls[1])
        {
            Console.WriteLine($"you are level 0!");
            Console.WriteLine($"You need {lvls[1] - _totalPoints} points to level up!");
        }
        if (_totalPoints > lvls[1] && _totalPoints < lvls[2])
        {
            Console.WriteLine($"you are level 1!");
            Console.WriteLine($"You need {lvls[2] - _totalPoints} points to level up!");
        }
        if (_totalPoints > lvls[2] && _totalPoints < lvls[3])
        {
            Console.WriteLine($"you are level 2!");
            Console.WriteLine($"You need {lvls[3] - _totalPoints} points to level up!");
        }
        if (_totalPoints > lvls[3] && _totalPoints < lvls[4])
        {
            Console.WriteLine($"you are level 3!");
            Console.WriteLine($"You need {lvls[4] - _totalPoints} points to level up!");
        }
        if (_totalPoints > lvls[4] && _totalPoints < lvls[5])
        {
            Console.WriteLine($"you are level 4!");
            Console.WriteLine($"You need {lvls[5] - _totalPoints} points to level up!");
        }
        if (_totalPoints > lvls[5] && _totalPoints < lvls[6])
        {
            Console.WriteLine($"you are level 5!");
            Console.WriteLine($"You need {lvls[6] - _totalPoints} points to level up!");
        }
        if (_totalPoints > lvls[6] && _totalPoints < lvls[7])
        {
            Console.WriteLine($"you are level 6!");
            Console.WriteLine($"You need {lvls[7] - _totalPoints} points to level up!");
        }
        if (_totalPoints > lvls[7] && _totalPoints < lvls[8])
        {
            Console.WriteLine($"you are level 7!");
            Console.WriteLine($"You need {lvls[8] - _totalPoints} points to level up!");
        }
        if (_totalPoints > lvls[8] && _totalPoints < lvls[9])
        {
            Console.WriteLine($"you are level 8!");
            Console.WriteLine($"You need {lvls[9] - _totalPoints} points to level up!");
        }
        if (_totalPoints > lvls[9] && _totalPoints < lvls[10])
        {
            Console.WriteLine($"you are level 9!");
            Console.WriteLine($"You need {lvls[10] - _totalPoints} points to level up!");
        }
        if (_totalPoints > lvls[10])
        {
            Console.WriteLine($"you are level 10!");
            Console.WriteLine($"Congratulations! You are at max level!");
        }
    }
}