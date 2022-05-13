namespace lab1_task2
{
    public static class Program
    {
        static void Main()
        {
            Subscriber1 sub1 = new Subscriber1("Ivan");
            Subscriber2 sub2 = new Subscriber2("Vasya");
            Subscriber3 sub3 = new Subscriber3("Ura");

            Countdown countdown = new Countdown();

            countdown.subscribe(sub1);
            countdown.subscribe(sub2);
            countdown.subscribe(sub3);

            Console.WriteLine("Введите время ожидания: ");
            int time = Convert.ToInt32(Console.ReadLine());
            countdown.notifySubscribers(time);
        }
    }
}
