// See https://aka.ms/new-console-template for more information
using Vazifa10_07;
using Vazifa10_07.Classlar;

Console.WriteLine("Hello, World!");
actor a = new actor()
{
    actor_id = 1,
    first_name = "Penelope",
    last_name = "Guiness",
    last_update = "2013-05-26 14:47:57.62",
};
//DbCore.AddActor(a);
DbCore.Print(DbCore.GetByIdActor(1));


  