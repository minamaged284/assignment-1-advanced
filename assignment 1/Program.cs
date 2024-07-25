namespace assignment_1
{

    internal class Program
    {

        static void Main(string[] args)
        {
            string input = "";
            int[] numbers;

            do
            {
                Console.WriteLine("enter the numbers of the array seperated");

                input = Console.ReadLine();


                numbers = Array.ConvertAll(input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.TryParse(s, out int t) ? t : 0);

            } while (input =="" || input==null || numbers==null);






            for (int i = 0; i < numbers.Length;i++)
            {
                //to optimize the bubble sort algorithm we should subtract i from the second loop condition in this case we save an extra pass that has no meaning as it is already the last number is the biggest
                for (int j = 0; j < numbers.Length-i-1; j++)
                {
                    if (numbers[j] > numbers[j+1]) 
                    {
                       BubbleSort.swap(ref numbers[j], ref numbers[j+1]); 
                    }

                }
               

            }



            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


            Range<int> range = new Range<int>(10,20);
            Console.WriteLine(range.IsInRange(50));
            Console.WriteLine(range.Length());



        }
    }
}
