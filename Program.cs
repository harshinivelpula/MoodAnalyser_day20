namespace Moodanalyser
{
    class Program
    {
        public static void Main(string[] args)
        {
            Mood check = new Mood("msg");
            Console.WriteLine(check.AnalyseMood("I am sad"));
            Console.WriteLine(check.AnalyseMood("I am happy"));


            Mood check1 = new Mood("msg");
            check1.AnalyseAnyMood("I am in any mood");
        }
    }
}



