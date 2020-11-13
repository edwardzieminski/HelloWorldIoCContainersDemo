namespace HelloWorldIocContainersDemo
{
    public class HelloRepositoryInformal : IHelloRepository
    {
        public string GetHelloWord(string language)
        {
            return language switch
            {
                "PL" => "Cześć",
                "EN" => "Hello",
                "ES" => "Hola",
                _ => "Hey"
            };
        }
    }
}