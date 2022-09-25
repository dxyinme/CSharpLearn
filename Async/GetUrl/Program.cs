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
                "https://www.qq.com/",
            };
            foreach (var url in urls)
            {
                var t = GetInfoUrl(url);
                t.Wait();
                Console.WriteLine(t.Result.Length);
            }
        }
    }

}