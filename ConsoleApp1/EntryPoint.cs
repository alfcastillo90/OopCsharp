using PointAndLines;
using System;
class EntryPoint
{
    static void Main()
    {
        User user = new User("Vachev",Race.Earthling);
        User secondUser = new User();
        User thirdUser = new User();
        Console.WriteLine(user.ID);
        Console.WriteLine(secondUser.ID);
        Console.WriteLine(thirdUser.ID);
    }
}
