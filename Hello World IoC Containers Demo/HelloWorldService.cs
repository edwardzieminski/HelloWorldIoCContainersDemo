using System;

namespace HelloWorldIocContainersDemo
{
    public class HelloWorldService
    {
        private readonly IHelloRepository _repository;

        public HelloWorldService(IHelloRepository repository)
        {
            _repository = repository;
        }

        public string ProvideHelloMessage(string language, string personName)
        {
            string output;

            var helloWord = _repository.GetHelloWord(language);
            output = $"{helloWord} {personName}!";

            return output;
        }
    }
}
