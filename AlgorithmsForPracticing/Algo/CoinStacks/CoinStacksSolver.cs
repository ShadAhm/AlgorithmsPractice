namespace AlgorithmsForPracticing.Algo.CoinStacks;

public class CoinStacksSolver
{
    /*
     
     THIS SOLUTION DOESN'T WORK!!! :'(
     
     */


    public int Solve(int[] array)
    {
        if (array.Length == 1)
            return array[0];

        Seek(array);

        return 0;
    }

    private void Seek(int[] array)
    {
        int index = 0;
        int seekDirection = 1;

        while (true)
        {
            var left = array[index];
            var right = array[index + 1];

            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine($"Looking at {left} and {right}");

            switch (WhoShouldReceive(left, right))
            {
                case 1:
                    {
                        Console.WriteLine("Moving left to right");
                        array[index] -= 2;
                        array[index + 1] += 1;

                        if (array[index] == 0)
                        {
                            array = RemoveAt(array, index);
                            index--;
                        }

                        break;
                    }
                case -1:
                    {
                        Console.WriteLine("Moving right to left");
                        array[index] += 1;
                        array[index + 1] -= 2;

                        if (array[index + 1] == 0)
                        {
                            array = RemoveAt(array, index + 1);
                            index--;
                        }

                        break;
                    }
                default:
                    break;
            }

            Console.WriteLine(string.Join(", ", array));
            Console.ReadLine();

            if (index == array.Length - 2)
                seekDirection = -1;
            else if (index == 0)
                seekDirection = 1;

            index += seekDirection;
        }
    }

    /// <returns>1 if left should give right, -1 if right should give left, and 0 if they should both retain their values</returns>
    public int WhoShouldReceive(int left, int right)
    {
        bool leftCanGive = left >= 2;
        bool rightCanGive = right >= 2;

        if (leftCanGive && !rightCanGive)
        {
            if(right + 1 > left - 2 && right + 1 > left)
            {
                return 1;
            }
        }
        else if (!leftCanGive && rightCanGive)
        {
            if (left + 1 > left - 2 && left + 1 > right)
            {
                return -1;
            }
        }
        else if(leftCanGive && rightCanGive)
        {
            return left + 1 > right + 1 ? -1 : 1;
        }

        return 0;
    }

    public int[] RemoveAt(int[] source, int index)
    {
        int[] dest = new int[source.Length - 1];
        if (index > 0)
            Array.Copy(source, 0, dest, 0, index);

        if (index < source.Length - 1)
            Array.Copy(source, index + 1, dest, index, source.Length - index - 1);

        return dest;
    }
}
