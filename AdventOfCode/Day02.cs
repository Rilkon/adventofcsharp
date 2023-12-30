namespace AdventOfCode;

public class Day02 : MyBaseDay
{
    private readonly string _input;

    public Day02()
    {
        _input = File.ReadAllText(InputFilePath);
    }



    public override ValueTask<string> Solve_1()
    {
        int sum = 0;
        foreach (string line in this._input.Split("\n"))
        {

            int currmax = int.MinValue;
            int currmin = int.MaxValue;

            foreach (string el in line.Split("\t"))
            {
                int curr = int.Parse(el);
                currmax = Math.Max(curr, currmax);
                currmin = Math.Min(curr, currmin);
            }
            sum += currmax - currmin;

        }

        return new("" + sum);
    }


    public override ValueTask<string> Solve_2()
    {
        int sum = 0;
        foreach (string line in this._input.Split("\n"))
        {

            int divident = 0;
            int divisor = 1;
            foreach (string first in line.Split("\t"))
            {
                int curr = int.Parse(first);

                foreach (string second in line.Split("\t"))
                {
                    int nx = int.Parse(second);

                    if (curr == nx) continue;

                    if (curr % nx == 0)
                    {
                        divident = curr;
                        divisor = nx;
                        break;
                    }

                    if (nx % curr == 0)
                    {
                        divident = nx;
                        divisor = curr;
                    }
                }
            }
            sum += divident / divisor;

        }


        return new("" + sum);
    }
}
