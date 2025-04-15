using fs_console_2025_04_15;

//Person p1 = new Person();

//p1.Name = "John Doe";
//p1.FirstName = "John";
//p1.LastName = "Doe";
//p1.Age = 30;
////output all the properties to the screen

//Console.WriteLine($"{p1.FirstName} {p1.LastName} {p1.Age}");


List<string> rainbow = new List<string> { "red", "orange", "yellow", 
    "green", "blue", "indigo", "violet" };

Console.WriteLine("<ol>");
foreach (var colour in rainbow)
{
    Console.WriteLine($"<li>{colour}</li>");
}
Console.WriteLine("</ol>");


Console.WriteLine("<table>");
foreach (var colour in rainbow)
{
    Console.WriteLine($"<tr><td>{colour}</td></tr>");
}
Console.WriteLine("</table>");


List<string> superHeroes = new List<string> { "Iron Man", "Captain America", "Spider-Man", "Ant-Man" };


Console.WriteLine("<ul>");
foreach (var hero in superHeroes)
{
    Console.WriteLine($"<li>{hero}</li>");
}
Console.WriteLine("</ul>");

