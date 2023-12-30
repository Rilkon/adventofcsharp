namespace AdventOfCode;

public class Day01 : MyBaseDay
{
    private readonly string _input;

    public Day01()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    private int InverseCaptcha(bool p2 = false)
    {    
        int[] digits = this._input.Select(c => int.Parse(c.ToString())).ToArray();
        return digits.Select((int curr, int i) =>
        {
            int index = p2 ? (i + (digits.Length / 2)) % digits.Length : (i + 1) % digits.Length;
            return curr == digits[index] ? curr : 0;
        }).Sum();
    }

    public override ValueTask<string> Solve_1()
    {
        return new (""+InverseCaptcha());
    }


    public override ValueTask<string> Solve_2()
    {
        return new (""+InverseCaptcha(true));
    }
}
