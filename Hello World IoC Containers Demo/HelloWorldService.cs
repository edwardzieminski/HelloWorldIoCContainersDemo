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
            var helloWord = _repository.GetHelloWord(language);
            return $"{helloWord} {personName}!";
        }
    }
}
