# AbstractFactory
Реализация паттерна абстрактная фабрика
____
Есть общая абстракная фабрика от которой унаследованы две или больше
конкретные фабрики (феррарри и мерседес).
И есть два или больше интерфейса, отвечающие за конкретные детали,
но не конкретных производителей.
За конкретные детали конкретных производителей (их количетво равно
произведению количество конкретных фабрик на количество конкретных 
производителей) отвечают производные классы отинтерфесов деталей.
____
Спасибо этому уроку:
https://www.youtube.com/watch?v=1mVONOCxfLg
____

![Скриншот результата](https://user-images.githubusercontent.com/89964564/147443676-4a0bc9bc-6b12-4d7e-9e89-a7faab87a1ff.png)

____
Проект разрабатывался в Microsoft Visual Studio, 
открывать следует файл Program.cs,
запуск программы происходит с помощью кнопки "Пуск" в редакторе кода,
дальше пользователь вводит данные в консоль.
