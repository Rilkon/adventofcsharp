namespace AdventOfCode;


public class Day03 : MyBaseDay
{
    private readonly string _input;

    public Day03()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    private static int CalculateSteps(int target)
    {
        // (2*layer +1) ^ < target
        // t == (2l+1)^2
        // 4 l^2 + 4 l + 1 = t
        // l = 1/2 (sqrt(t) - 1)

        int layer = (int)(0.5 * Math.Sqrt(target) + 1);
        int axisDistance = (2 * layer + 1) / 2;
        int stepsToAxis = Math.Abs(((target - 1) % (2 * layer) - layer));
        int totalSteps = axisDistance + stepsToAxis;

        return totalSteps;
    }

    private static long SquareSpiralOfSums(int target)
    {
        // https://oeis.org/A141481/b141481.txt
        var path = Path.Combine(Directory.GetCurrentDirectory()+"/aocsharp2017inputs", "A141481.txt");
        string part2 = File.ReadAllText(path);


        foreach (string line in part2.Split("\n")[2..200])
        {   
            long current = long.Parse(line.Split(" ")[1]);
            if(current > target) { return current; }
        }
        return 0;
    }

    public override ValueTask<string> Solve_1()
    {
        int target = int.Parse(this._input);
        return new("" + CalculateSteps(target));
    }

    public override ValueTask<string> Solve_2()
    {
        int target = int.Parse(this._input);
        return new("" + SquareSpiralOfSums(target));
    }
}



