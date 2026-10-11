using System;
using System.Collections.Generic;
using System.IO;


public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
     public void Start()
    {
        bool quit = false;
        while(quit == false)
        {

            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice =="1")
            {
                CreateGoal();
            }
            else if (choice =="2")
            {
                ListGoalDetails();
            }
            else if (choice =="3")
            {
                SaveGoals();
            }
            else if (choice =="4")
            {
                LoadGoals();
            }
            else if (choice =="5")
            {
                RecordEvent();
            }
            else if (choice =="6")
            {
                quit = true;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("");
        Console.WriteLine($"Your score is: {_score} points");
        Console.WriteLine("");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int i = 1;

        
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet");
            return;
        }
        
        for(int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i +1}. {_goals[i].GetDetailsString()}");
            
        }
        
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

         if ( type != "1" && type != "2" && type !="3")
        {
            Console.WriteLine("Invalid goal type");
            return;
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        
        if (!int.TryParse(Console.ReadLine(), out int points) || points < 0)
        {
            Console.WriteLine("Please enter a valid, non-negative number of points.");
            return;
        }
        
        if (type =="1")
        {
             
            _goals.Add(new SimpleGoal(name, description, points));
        }

        else if ( type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }

        else if ( type == "3")
        {
            Console.Write("How many times does this goal need to be achieved for a bonus? ");

            if (!int.TryParse(Console.ReadLine(), out int target) || target <= 0)
            {
                Console.WriteLine("Target must be greater than zero.");
                return;
            }

            Console.Write("What is the bonus for accomplishing it that many times? ");

            if (!int.TryParse(Console.ReadLine(), out int bonus) || bonus < 0)
            {
                Console.WriteLine("Bonus cannot be neagtive.");
                return;
            }
            
            _goals.Add(new CheckListGoal(name, description, points, target, bonus));
        }

        Console.WriteLine("Goal created successfully.");
      
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals to record.");
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");

        if (!int.TryParse(Console.ReadLine(), out int number) || number < 1 || number > _goals.Count)
        {
           Console.WriteLine("Please select a valid goal.");
           return; 
        }

        Goal goal = _goals[number -1];
        
        int pointsEarned = goal.RecordEvent();

        _score += pointsEarned;

        Console.WriteLine($" Congratulations you have earned {pointsEarned} points!");
        Console.WriteLine($"You now have{_score} points.  ");
        Console.WriteLine();
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for this goal? ");
        string filename = (Console.ReadLine());

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine("Goals saved succefully");

        }

        catch(IOException)
        {
            Console.WriteLine("Unable to save the file");

        }
        
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permision to save this file");
        }
    
    } 

    public void LoadGoals()
    {
        Console.Write("What is the filename for this goal? ");
        string filename = (Console.ReadLine());

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found");
            return;
        }

        try
        {
            string [] lines = File.ReadAllLines(filename);   
            if (lines.Length == 0 || 
            !int.TryParse(lines[0], out int loadedScore) || 
            loadedScore < 0)

            {
                Console.WriteLine("The saved score is invalid");
                return;
            }

            List<Goal> loadedGoals = new List<Goal>(); 

            for (int i = 1; i<lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) 
                continue;
                
                string [] data = lines[i].Split('|');

                if (data.Length == 0) 
                continue;

                string goalType = data[0];

                if (goalType == "SimpleGoal" && data.Length == 5)
                {
                    if (int.TryParse(data[3], out int points) &&
                        bool.TryParse(data[4], out bool isComplete) && 
                        points >= 0)

                    {
                        loadedGoals.Add(new SimpleGoal(
                            data[1], data[2], points, isComplete));
                    }
                }

                else if (goalType == "EternalGoal" && data.Length == 4)
                {
                    if (int.TryParse(data[3], out int points) &&
                        points >= 0)

                    {
                    loadedGoals.Add(new EternalGoal(
                        data[1], data[2], points));
                    }
                }

                else if (goalType == "CheckListGoal" && data.Length == 7)
                {
                    if (int.TryParse(data[3], out int points) &&
                        int.TryParse(data[4], out int target) &&
                        int.TryParse(data[5], out int bonus) &&
                        int.TryParse(data[6], out int amount) &&
                        points >= 0 && target >0 &&
                        bonus>=0 && amount >=0 && amount<=target)

                    {
                        loadedGoals.Add(new CheckListGoal
                        (data[1], data[2], points,
                        target,bonus,amount));
                    }
                }      

            }  

            _goals = loadedGoals;
            _score = loadedScore;
        
            Console.WriteLine("Goals loaded succefully");

        } 

        catch(IOException)
        {
              Console.WriteLine("Unable to read the file");
        }

        catch(UnauthorizedAccessException)
    
        {
            Console.WriteLine("you do not have permision to add this file");
        }
    
    }               
}