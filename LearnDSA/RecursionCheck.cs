namespace LearnDSA
{
    public class RecursionCheck
    {
        public void FindSquareIteratively(int n)
        {
            List<int> result = new();
            while(n > 0)
            {
                Console.WriteLine(n * n);
                n--;
            }
        }

        public void FindSquareRecursively(int n)
        {
            List<int> result = new();
            if (n > 0)
            {
                Console.WriteLine(n * n);
                FindSquareRecursively(n - 1);
            }
        }

    }
}
