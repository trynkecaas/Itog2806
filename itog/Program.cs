// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine);
string [] stringArray = new string [m];
void array (string[] stringArray)
{
  for (int i = 0; i<stringArrayLength;i++)
  {
    Console.WriteLine($"Введите {i+1} элемент массива");
    stringArray[i] =Console.ReadLine();  
  }
}
string [] symbol(string [] stringArray)
{
  int n = 0;
  for (int i = 0; i<stringArray.Length;i++)
  {
    if(stringArray[i].Length<=3)
    n++;
      }
} 
