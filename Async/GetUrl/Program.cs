namespace CSharpLearn.Async
{
    class GetUrl
    {
        static async Task<string> GetInfoUrl(string url)
        {
            var client = new HttpClient();
            var content = client.GetStringAsync(url);
            Console.WriteLine($"get info from {url}");
            string res = await content;
            return res;
        }

        public static void Main(string[] args)
        {
            var urls = new List<string>{
                "https://www.baidu.com/",
                "https://www.bilibili.com/",
                "https://www.sina.com/",
            };
            var taskList = new List<Task<string>>();
            foreach (var url in urls)
            {
                taskList.Add(GetInfoUrl(url));
            }
            Task.WhenAll(taskList).Wait();
            for (int i = 0; i < urls.Count; i++)
            {
                Console.WriteLine($"{urls[i]}  length:{taskList[i].Result.Length}");
            }
        }
    }
}