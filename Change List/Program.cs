List <int> numbers =Console.ReadLine().Split(' ').Select(int.Parse).ToList() ;
string commands=Console.ReadLine();


while(commands!="end")
{
    string[] partsCommand = commands.Split(' ');

    if (partsCommand[0] =="Delete")
    {
       int element = int.Parse(partsCommand[1]);
       numbers.RemoveAll(number => number == element);

    } 
    else if (partsCommand[0] == "Insert")
    {
        int element = int.Parse(partsCommand[1]);
        int position = int.Parse(partsCommand[2]);
        
        numbers.Insert(position, element);
         
    }
    
    commands = Console.ReadLine();
}
if(commands=="end")
{
    Console.WriteLine(string.Join(" ", numbers));
}