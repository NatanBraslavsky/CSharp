
class Program
{ 
    static List<int> numbers = new List<int> { 1,5,5,3,2};
    public static void ordenar()
    {
        for(int i = 0; i < numbers.Count - 1; i++)
        {
            for(int j = i + 1; j < numbers.Count; j++)
            {
                if(numbers[i] > numbers[j])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
    }

    static void Main()
    {
        ordenar();
        foreach(var num in numbers)
        {
            Console.WriteLine(num);
        }
    }

}


