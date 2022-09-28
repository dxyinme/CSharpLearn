namespace CSharpLearn.Async
{
    class HelloWorld
    {

        static async Task HelloWorldWrites(int duration, int idx)
        {
            Console.WriteLine($"hello world {idx} begin");
            await Task.Delay(duration);
            Console.WriteLine($"hello world {idx} end");

        }
        static public async Task Main(string[] args)
        {
            var t1 = HelloWorldWrites(10, 1);
            var t2 = HelloWorldWrites(10, 2);
            var t3 = HelloWorldWrites(10, 3);

            await t3;
            await t2;
            await t1;
        }
    }

}