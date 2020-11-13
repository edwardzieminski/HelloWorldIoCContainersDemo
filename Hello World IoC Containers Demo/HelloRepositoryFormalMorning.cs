namespace HelloWorldIocContainersDemo
{
    public class HelloRepositoryFormalMorning : IHelloRepository
    {
        public string GetHelloWord(string language)
        {
            return language switch
            {
                "PL" => "Dzień dobry",
                "EN" => "Good morning",
                "ES" => "Buenos dias",
                _ => "Good day"
            };
        }
    }
}
