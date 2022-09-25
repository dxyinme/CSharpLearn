namespace CSharpLearn.Async
{
    public class NormalTask
    {
        public string Input;
        public string? Output { get; set; }

        public NormalTask(string input)
        { 
            Input = input;
        }

        public void Run()
        {
            Output = $"hello world {Input}";
            Console.WriteLine(Output);
        }
    }
    class HelloWorld
    {

        static Task RunTask(NormalTask task)
        {
            return Task.Run(() => 
            { 
                task.Run();
            });
        }

        static public void Main(string[] args)
        {
            List<Task> resList = new();
            List<NormalTask> nList = new();
            for (int i = 0; i < 10; i++) 
            {
                NormalTask t = new(i.ToString());
                nList.Add(t);
                resList.Add(RunTask(t));
            }
            Task.WhenAll(resList).Wait();
            foreach (var aTask in nList)
            {
                Console.WriteLine($"real result {aTask.Output}");
            }
        }
    }

}