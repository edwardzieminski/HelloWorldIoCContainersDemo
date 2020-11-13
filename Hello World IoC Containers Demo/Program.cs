using System;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorldIocContainersDemo
{
    class Program
    {
        static string language;
        static string personName;

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Two arguments expected. Please try again.");
            }
            else
            {
                RunProgram(args);
            }
        }

        static void RunProgram(string[] args)
        {
            language = args.GetValue(0).ToString();
            personName = args.GetValue(1).ToString();

            var collection = new ServiceCollection();

            // W poniższej linii można w każdym momencie podmienić HelloRepositoryInformal
            // na inne repozytorium (dałem 3 możliwe opcje).
            // Można to zrobić, bo stworzyłem interfejs IHelloRepository.
            // Wszystkie 3 klasy ten interejs implementują.

            // Jakby się uprzeć można też zrobić jakiegoś ifa albo switcha żeby sprawdzić
            // godzinę i wyświetlić wersję poranną lub popołudniową zależnie od godziny.
            // Można też dodać obsługę trzeciego argsa w którym będzie trzeba wpisać formal/informal.
            collection.AddTransient<IHelloRepository, HelloRepositoryInformal>();

            // Tu nie zrobiłem interfejsu - tak też można,
            // chociaż raczej zaleca się zrobić interfejs.
            collection.AddTransient<HelloWorldService>();

            var provider = collection.BuildServiceProvider();

            // Gdybym zrobił interfejs do HelloWorldService to w tym miejscu dostałbym to,
            // co byłoby podpięte do do tego interfejsu w kolekcji
            var service = provider.GetService<HelloWorldService>();

            Console.WriteLine(service.ProvideHelloMessage(language, personName));
        }
    }
}
