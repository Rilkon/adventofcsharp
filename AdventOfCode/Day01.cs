namespace AdventOfCode;

public class Day01 : BaseDay
{
    private readonly string _input;

    public Day01()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    private int InverseCaptcha(int[] digits, bool p2 = false)
    {
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {

            int index = (i + 1) % digits.Length;
            if (p2) index = (i + (digits.Length / 2)) % digits.Length;
            if (digits[i] == digits[index])
            {
                sum += digits[i];
            }
        }
        return sum;
    }

    public override ValueTask<string> Solve_1()
    {
        int[] digits = this._input.Select(c => int.Parse(c.ToString())).ToArray();
        return new($"Solution to {ClassPrefix} {CalculateIndex()} Part 1: {InverseCaptcha(digits, false)}");
    }



    public override ValueTask<string> Solve_2()
    {
        int[] digits = this._input.Select(c => int.Parse(c.ToString())).ToArray();
        return new($"Solution to {ClassPrefix} {CalculateIndex()} Part 2: {InverseCaptcha(digits, true)}");


    }
}
