Random random = new Random();
int randomnumber = random.Next(1,101);
int y = 0;
for(int i= 1; y!=randomnumber; i ++)
{
Console.Write("programmet har valt ett slumpmässigt tal mellan 1 och 100. gissa vilket tal det är: ");
y = Convert.ToInt32(Console.ReadLine());
if(y<randomnumber)
{ 
Console.WriteLine("det angivna talet är mindre än det slumpmässiga talet");
}
else if(randomnumber<y)
{
Console.WriteLine("det angivna talet är större än det slumpmässiga talet");
}
else
{
Console.WriteLine("bra jobbat. du gjorde något som statistiskt sätt inte borde ske");
}
Console.WriteLine("Du har gjort " + i + " gisningar");
}
