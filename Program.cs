// TASK_1

Console.WriteLine("TASK 1");
object[] collection = { 1, "hello", 3.14, DateTime.Now };
Thread thread = new Thread(() =>
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.WriteLine(collection[i].GetType()+"\t\t"+collection[i].ToString());
    }
});
thread.Start();
thread.Join();

// TASK_2

