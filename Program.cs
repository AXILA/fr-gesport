using System;

Console.WriteLine("Fråga 1. vilket spel är bäst Valorant eller CSGO?");

string answer;
int points = 0;



answer = Console.ReadLine();

if(answer == "Valorant" || answer == "valorant")
{
points += 10;
Console.WriteLine("True");
Console.WriteLine(points); 
}
else if(answer == "CSGO" || answer == "csgo")
{ 
points -=10;    
Console.WriteLine("False");    
Console.WriteLine(points);     
}

Console.WriteLine("Fråga 2. Vilket vapen är bäst Vandal eller AK47?");

answer = Console.ReadLine();

if(answer == "Vandal" || answer == "vandal")
{
points +=10;
Console.WriteLine("True");
Console.WriteLine(points);    
}

else if(answer == "AK47" || answer == "ak47")
{ 
points -=10;
Console.WriteLine("False"); 
Console.WriteLine(points);  
}

Console.WriteLine("Fråga 3. Vilket spel har dem bästa skinsen Valorant eller CSGO?");

answer = Console.ReadLine();

if(answer == "Valorant" || answer == "valorant")
{
points -=10;    
Console.WriteLine("False"); 
Console.WriteLine(points);
}
else if(answer == "CSGO" || answer == "csgo")
{
points +=10;
Console.WriteLine("True");
Console.WriteLine(points);    
}

Console.WriteLine("Nu är quizen över du fick så här många poäng av terttio.");
Console.WriteLine(points);
answer = Console.ReadLine();

Console.ReadLine();