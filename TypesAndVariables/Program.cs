double number5 = 10.4;
decimal number6 = 10;
char character = 'a';
bool condition  = false;
byte number4  = 255;
short number3 = 32767;
int number2 = 2147483647;
long number1 = 9223372036854775807;
var number7 = 'a';

Console.WriteLine("Number1 is {0}",number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Character is {0}", (int)character);
Console.WriteLine("Number7 is {0}", (int)number7);

Console.WriteLine((int)Days.Friday);


enum Days
{
    Monday=10,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
}