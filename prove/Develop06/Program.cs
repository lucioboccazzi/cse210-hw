using System;

class Program
{
    static void Main(string[] args)
    {
        int initialScore = 0;

        GoalManager goalManager = new GoalManager(initialScore);

        goalManager.Start();

    }
}