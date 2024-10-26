using System;
using System.Diagnostics.Contracts;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    //Constructors
    public GoalManager()
    {
        _score = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public int GetScore()
    {
        return _score;
    }
    public void AddPoints(int points)
    {
        _score += points;
    }
    public void AddBonus(int bonusPoints)
    {
        _score += bonusPoints;
    }
    public void SetScore(int score)
    {
        _score = score;
    }
    public List<Goal> GetListGoals()
    {
        return _goals;
    }

    //Methods
    public void Start()
    {
        string menu = "\nMenu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit";
        bool runProgram = true;

        do
        {
            Console.WriteLine($"You have {GetScore} points!");
            Console.WriteLine(menu);
            Console.Write("Select a choice from the menu: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                CreateGoal();
            }
            else if (userInput == 2)
            {
                ListGoals();
            }
            else if (userInput == 3)
            {
                SaveGoal();
            }
            else if (userInput == 4)
            {
                LoadGoals();
            }
            else if (userInput == 5)
            {
                RecordEvent();
            }
            else if (userInput == 6)
            {
                runProgram = false;
                break;
            }
        }
        while (runProgram);
    }

    //list the goals
    public void ListGoals()
    {
        if (_goals.Count != 0)
        {
            Console.WriteLine("Your goals are: ");

            int i = 1;
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(i);
                i = i + 1;
            }
        }
        else
        {
            Console.WriteLine("The list of goals is empty. Either load your saved goals or create new goals.");
        }
    }

    //asks the user for info about a new goal. Then creates the goal and adds to the list
    public void CreateGoal()
    {
        string[] goalTypes = { "Simple Goal", "Eternal Goal", "Checklist Goal" };
        Console.WriteLine($"\nThe types of goals are: \n1. {goalTypes[0]}\n2. {goalTypes[1]}\n3. {goalTypes[2]}");
  
        Console.Write("\nWhat type of goal do you want to create?: ");
        int goalChoice = int.Parse(Console.ReadLine()) - 1;

        //Simple Goal
        if (goalChoice == 0)
        {
            Console.Write("\nWhat is the name of the goal? ");
            string name = Console.ReadLine();
            Console.Write("\nWhat is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("\nWhat is the number of points you want to assign this goal? ");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal simpleGoal = new SimpleGoal(goalTypes[goalChoice], name, description, points);
            AddGoal(simpleGoal);
        }
        else if (goalChoice == 1)
        {
            Console.Write("\nWhat is the name of the goal? ");
            string name = Console.ReadLine();
            Console.Write("\nWhat is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("\nWhat is the number of points you want to assign this goal? ");
            int points = int.Parse(Console.ReadLine());
            EternalGoal eternalGoal = new EternalGoal(goalTypes[goalChoice], name, description, points);
            AddGoal(eternalGoal);
        }
        else if (goalChoice == 2)
        {
            Console.Write("\nWhat is the name of the goal? ");
            string name = Console.ReadLine();
            Console.Write("\nWhat is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("\nWhat is the number of points you want to assign this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("\nWhat is the number of bonus points for accomplishing this goal? ");
            int bonus = int.Parse(Console.ReadLine());
            Console.Write("\nHow many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(goalTypes[goalChoice], name, description, points, bonus, target);
            AddGoal(checklistGoal);
        }
        else
        {
            Console.WriteLine("Invalid: this option does not exist.");
        }
    }
    //asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal
    public void RecordEvent()
    {
        ListGoals();

        Console.WriteLine("\nWhich goal did you accomplish? ");
        int select = int.Parse(Console.ReadLine()) - 1;

        int goalPoint = GetListGoals()[select].GetPoints();
        AddPoints(goalPoint);

        GetListGoals()[select].RecordEvent(_goals);

        Console.Write($"\nYou have {GetScore()} points!!");
    }


    //saves the list of goals to a file
    public void SaveGoal()
    {
        string fileName = "";
        Console.Write("What is the filename for the goal file? ");
        fileName = Console.ReadLine();

        using (StreamWriter savedFile = new StreamWriter(fileName))
        {
            // int totalPoints = GetScore();
            savedFile.WriteLine(GetScore());

            foreach (Goal goal in _goals)
            {
                savedFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    //loads the list of goals from the file
    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string userInput = Console.ReadLine();
        string fileName = userInput;

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            int score = int.Parse(lines[0]);
            SetScore(score);
            lines = lines.Skip(1).ToArray();

            foreach (string line in lines)
            {
                string[] entries = line.Split("|");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(type, name, description, points, status);
                    AddGoal(simpleGoal);
                }
                if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eternalGoal = new EternalGoal(type, name, description, points, status);
                    AddGoal(eternalGoal);
                }
                if (entries[0] == "Checklist Goal:")
                {
                    int bonus = int.Parse(entries[5]);
                    int target = int.Parse(entries[6]);
                    int amountCompleted = int.Parse(entries[7]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(type, name, description, points, status, bonus, target, amountCompleted);
                    AddGoal(checklistGoal);
                }
            }
        }
    }
}

