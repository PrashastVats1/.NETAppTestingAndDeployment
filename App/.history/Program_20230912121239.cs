// See https://aka.ms/new-console-template for more information
Console.WriteLine("Let us display a list of the months");
List<string> listMonth = new List<string>
{
    "Januar","February","March","April","May","June","July","August","September","October","November","December"
};
foreach(var month in listMonth)
{
    Console.WriteLine(month);
    Thread.Sleep(2000)
}