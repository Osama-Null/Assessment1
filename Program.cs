using System;

#region OneDecremented
string OneDecremented(string str)
{
    // code goes here 
    int count = 0;

    for (int i = 1; i < str.Length; i++)
    {
        if (str[i - 1] - 1 == str[i])
        {
            count++;
        }
    }
    return count.ToString();
}

Console.WriteLine(OneDecremented(Console.ReadLine()));
#endregion

#region FirstFactorial
int FirstFactorial(string num)
{
    // code goes here
    int temp = Convert.ToInt32(num);
    int result = 1;

    for (int i = 1; i <= temp; i++)
    {
        result *= i;
    }
    return result;
}

Console.WriteLine(FirstFactorial(Console.ReadLine()));
#endregion