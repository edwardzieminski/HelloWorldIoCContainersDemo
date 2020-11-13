namespace HelloWorldIocContainersDemo
{
    public class HelloRepositoryFormalAfternoon : IHelloRepository
    {
        public string GetHelloWord(string language)
        {
            return language switch
            {
                "PL" => "Dzień dobry",
                "EN" => "Good afternoon",
                "ES" => "Buenos tardes",
                _ => "Good day"
            };
        }
    }
}
