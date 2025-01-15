// See https://aka.ms/new-console-template for more information
string aFriend = "Bill";
Console.WriteLine("Hellow " + aFriend);
aFriend = "Bob";
Console.WriteLine("Hellow " + aFriend);
aFriend = "James";
Console.WriteLine($"Hiii! {aFriend}");

string FriendOne = "Jamess";
string FriendTwo = "Jose";

Console.WriteLine($"My friends are {FriendOne} and {FriendTwo}");

Console.WriteLine($"The name {FriendOne} has {FriendOne.Length} letters.");
Console.WriteLine($"The name {FriendTwo} has {FriendTwo.Length} letters in it.");


string greeting = "         Hellow World!!!         ";
Console.WriteLine($"[{greeting}]");

string trimmedgreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedgreeting}]");

trimmedgreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedgreeting}]");

trimmedgreeting = greeting.Trim();
Console.WriteLine($"[{trimmedgreeting}]");

string sayHello = "Hello World!";
Console.WriteLine(sayHello);

sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());



string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));

