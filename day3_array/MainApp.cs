namespace day3_array
{
    internal class MainApp
    {
        static int CalculateSum(int[] scoresArray) // 배열을 인자로 넘겨주기
        {
            int sum = 0;

            foreach (int score in scoresArray)
            {
                sum += score;
            }

            Console.WriteLine("Total Score: {0}", sum);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //1,2,3차원 배열 -> 각 배열이 고정길이를 가진다.
            string[] players = { "Ronaldo", "Messi", "Neymar", "Mbappe", "Salah" };
            string[,,] player2 = {
                {
                    {"Ronaldo", "Messi", "Neymar"},
                    {"Mbappe", "Salah", "Kane"},
                    {"Lewandowski", "Benzema", "Haaland"},
                },
                {
                    {"Ronaldo", "Messi", "Neymar"},
                    {"Mbappe", "Salah", "Kane"},
                    {"Lewandowski", "Benzema", "Haaland"}
                },
            };
            string[,,,] player3;

            //가변배열 (Jagged Array) -> 각 배열이 고정길이를 가지지 않는다.
            string[][] strings = new string[3][];
            strings[0] = new string[] { "Ronaldo", "Messi", "Neymar" };
            strings[1] = new string[] { "Mbappe", "Salah" };
            strings[2] = new string[] { "Lewandowski", "Benzema", "Haaland", "Kane" };


            int[] scores = { 10, 20, 30, 40, 50 };
            CalculateSum(scores);

        }
    }

}
