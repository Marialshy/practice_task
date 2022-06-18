// to create new array (string), each item's length <=3
Console.WriteLine("Please enter symbols splited by comma");
string someInput = new string(Convert.ToString(Console.ReadLine()));
int number = 3;
string[] arrayA = someInput.Split(',');
string [] newArray = FillArrayIfChar3(arrayA);
PrintArray(newArray);

void PrintArray(string[] array)
{
    Console.Write("new Array {");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i<array.Length-1) Console.Write(" ");
    }
    Console.Write("}");
}

string [] FillArrayIfChar3(string [] array)
{
    int j = 0;
    string[] arrayNew = new string [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= number)
        {
            arrayNew[j] = array[i];
            j++;
        }
    }
    return arrayNew;
}