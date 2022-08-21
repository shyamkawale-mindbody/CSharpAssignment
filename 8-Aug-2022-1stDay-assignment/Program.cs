// See https://aka.ms/new-console-template for more information
Console.WriteLine("FIRST PROBLEM");


string str = "The James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny. The character—also known by the code number 007 (pronounced 'double-O-seven')—has also been adapted for television, radio, comic strip, video games and film. The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth-highest-grossing film series to date, which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have been twenty-five films in the Eon Productions series. The most recent Bond film, No Time to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series. There have also been two independent productions of Bond films: Casino Royale (a 1967 spoof starring David Niven) and Never Say Never Again (a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time.";
Char[] charr = str.ToCharArray();
string[] words = str.Split(' ');
int wordslen = words.Length;
int len = str.Length;


int spccnt = 0;

Console.WriteLine();
Console.WriteLine("All special characters: ");
spccnt = CountSpecialchar(charr);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Total length: {len}");
Console.WriteLine($"words count: {wordslen}");
Console.WriteLine($"whitespace count: {CountBlankSpace(charr)}");
Console.WriteLine($"Digits count: {CountDigits(charr)}");
Console.WriteLine($"special char count: {spccnt}");
Console.WriteLine($"the is to as of in count: {CountTheIsTo(words)}");
Console.WriteLine($"adverbs count: {CountAdverbs(words)}");
Console.WriteLine($"statements count: {CountStatements(charr)}");



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("SECOND PROBLEM");

string[] names = new string[] { "Ram", "Shankar", "Ramesh", "Vivek", "Satish", "Mukesh", "Sandeep", "Vinay", "Mahesh", "Tushar", "Tejas", "Suprotim", "Vikram", "Subodh", "Pravin", "Amit", "Ajit", "Anhijit", "Sharad", "Sanjay", "Vijay", "Abhay", "Vilas", "Anil", "Nandu", "Jaywant", "Shyam" };


Console.WriteLine($"all names having length >= 7 : ");
PrintStringsWithLengthGT7(names);

Console.WriteLine();
Console.WriteLine("all names having odd length");
PrintOddLengthString(names);

Console.WriteLine();
Console.WriteLine("Print all string starts with a Character parameter value passed to a method");
Console.WriteLine("Enter any character: ");
Char c1 = Convert.ToChar(Console.ReadLine());
PrintStartStartWith(names, c1);


Console.WriteLine();
Console.WriteLine("Print All string having a character passed to the method in it");
Console.WriteLine("Enter any character: ");
Char c2 = Convert.ToChar(Console.ReadLine());
PrintStringsContainsChar(names, c2);





Console.ReadLine();

static int CountBlankSpace(Char[] charr)
{
    int cnt = 0;
    foreach (Char ch in charr)
    {
        if (ch == ' ')
        {
            cnt++;
        }
    }
    return cnt;
}
static int CountStatements(Char[] charr)
{
    int cnt = 0;
    foreach (Char ch in charr)
    {
        if (ch == '.')
        {
            cnt++;
        }
    }
    return cnt;
}
static int CountDigits(Char[] charr)
{
    int cnt = 0;
    foreach (Char ch in charr)
    {
        //var digregex = new Regex("^[0-9]*$");

        //if (digregex.IsMatch(ch.ToString()))
        if (Char.IsDigit(ch))
        {
            //Console.WriteLine(ch);
            cnt++;
        }
    }
    return cnt;
}
static int CountTheIsTo(string[] words)
{
    int cnt = 0;
    foreach (string s in words)
    {

        if (s == "the" || s == "is" || s == "to" || s == "as" || s == "of" || s == "in")
        {
            cnt++;
        }

    }
    return cnt;
}
static int CountAdverbs(string[] words)
{
    int cnt = 0;
    string[] adverb = new string[] { "Additionally", "also", "continually", "Never", "Again", "earlier" };
    foreach (string s in words)
    {

        if (adverb.Contains(s))
        {
            cnt++;
        }

    }
    return cnt;
}
static int CountSpecialchar(Char[] chr)
{
    int cnt = 0;
    //var specialregex = new Regex("^[a-zA-Z0-9 ]*$");
    int j = 1;
    for (int i = 0; i < chr.Length; i++)
    {
        //if (!specialregex.IsMatch(chr[i].ToString()))
        if (!Char.IsLetterOrDigit(chr[i]) && chr[i] != ' ')
        {
            Console.WriteLine(j + ") special char is : " + chr[i] + "  on index: " + i);
            cnt++;
            j++;
        }
    }
    return cnt;
}

static void PrintStartStartWith(string[] names, Char ch)
{
    Console.WriteLine($"Strings that starts with {ch}: ");
    foreach (string st in names)
    {
        if (st[0] == Char.ToUpper(ch))
        {
            Console.Write($"{st} , ");
        }
    }
    Console.WriteLine();
}

static void PrintOddLengthString(string[] names)
{

    foreach (string st in names)
    {
        if (st.Length % 2 != 0)
        {
            Console.Write($"{st} , ");
        }
    }
    Console.WriteLine();
}
static void PrintStringsContainsChar(string[] names, Char c)
{
    Console.WriteLine($"Print All string having a character passed to the method in it");
    foreach (string st in names)
    {
        if (st.ToUpper().Contains(c.ToString().ToUpper()))
        {
            Console.Write($"{st} , ");
        }
    }
    Console.WriteLine();
}
static void PrintStringsWithLengthGT7(string[] names)
{
    foreach (string st in names)
    {
        if (st.Length >= 7)
        {
            Console.Write($"{st} , ");
        }
    }
    Console.WriteLine();
}
