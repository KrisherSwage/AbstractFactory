using System;

namespace AbstractFactoryPattern
{
    public interface IAbstractFactory //общая абстрактная фабрика
    {
        IEngine CreateEngine(); //метод без реализации в интерфейсе. функционал в классе

        IFrame CreateFrame();
        //если бы деталей машины было больше, то и соответствующих интерфейсов было больше
    }

    class Mercedes : IAbstractFactory //производный класс Мерседес. Имеет два конкретных продукта (двигатель и корпус)
    {
        public IEngine CreateEngine()
        {
            return new EngineMercedes();
        }

        public IFrame CreateFrame()
        {
            return new FrameMercedes();
        }
    }

    class Ferrari : IAbstractFactory //производный класс Феррари
    {
        public IEngine CreateEngine()
        {
            return new EngineFerrari();
        }

        public IFrame CreateFrame()
        {
            return new FrameFerrari();
        }
    }

    public interface IEngine //интерфейс для двигателей
    {
        string MakingEngine();
    }

    class EngineMercedes : IEngine //конкретное создание двигателя мерседеса
    {
        public string MakingEngine()
        {
            return "Результат создания двигателя мерседеса";
        }
    }

    class EngineFerrari : IEngine //конкретное создание двигателя феррари
    {
        public string MakingEngine()
        {
            return "Результат создания двигателя феррари";
        }
    }

    public interface IFrame //интерфейс для корпуса
    {
        string MakingFrame();

        string AnotherMakingFrame(IEngine merger); //метод для слияния корпуса и двигателя
    }

    class FrameMercedes : IFrame //конкретное создание корпуса мерседеса
    {
        public string MakingFrame()
        {
            return "Результат создания корпуса мерседеса";
        }

        public string AnotherMakingFrame(IEngine merger)
        {
            var result = merger.MakingEngine();

            return $"Результат слияния двигателя и корпуса ({result}) для мерседеса";
        }
    }

    class FrameFerrari : IFrame //конкретное создание корпуса феррари
    {
        public string MakingFrame()
        {
            return "Результат создания корпуса феррари";
        }

        public string AnotherMakingFrame(IEngine merger)
        {
            var result = merger.MakingEngine();

            return $"Результат слияния двигателя и корпуса ({result}) для феррари";
        }
    }

    class Request
    {
        public void Realize()
        {
            //запрошенный код может работать с любым конкретным классом фабрики. то есть работа выполнена корректно
            Console.WriteLine("Тестирование запрошенного кода с первым типом фабрики");
            ClientMethod(new Mercedes());
            Console.WriteLine();

            Console.WriteLine("Тестирование того же запрошенного кода со вторым типом фабрики");
            ClientMethod(new Ferrari());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var engine = factory.CreateEngine();
            var frame = factory.CreateFrame();

            Console.WriteLine(frame.MakingFrame());
            Console.WriteLine(frame.AnotherMakingFrame(engine));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Request().Realize();
        }
    }
}

