namespace Generators
{
    public class Program
    {
        /*
         * a generator is a routine that can be used to control the iteration behaviour of a loop. 
         * All generators are also iterators.[1] A generator is very similar to a function that returns an array, 
         * in that a generator has parameters, can be called, and generates a sequence of values. However, instead 
         * of building an array containing all the values and returning them all at once, a generator yields the 
         * values one at a time, which requires less memory and allows the caller to get started processing the first 
         * few values immediately. In short, a generator looks like a function but behaves like an iterator.
         * 
         * Definition source: 'https://en.wikipedia.org/wiki/Generator_(computer_programming)'
         */

        public static void Main(string[] args)
        {
            Console.WriteLine("C# Generators");

            IEnumerator<int> numbers = GetEnumerator(new int[] { 9, 2, 1, });


            Console.WriteLine(GetNumber(numbers)); // returns 9

            Console.WriteLine(GetNumber(numbers)); // returns 2

            Console.WriteLine(GetNumber(numbers)); // returns 1

            Console.WriteLine(GetNumber(numbers)); // returns -1
        }


        /*
         * Generator function will yield the contents inside the array
         * returns the IEnumerable of integer values
         */
        private static IEnumerable<int> GeneratorFunction(int[] numbers)
        {
            for(int i = 0; i< numbers.Length; i++)
                yield return numbers[i];
            yield return - 1;
        }

        /*
         * Returns the IEnumerator from the IEnumerable generator function,
         * I made it this way so that you don't need to call the GetEnumerator method from IEnumerable
         */
        private static IEnumerator<int> GetEnumerator(int[] numbers)
        {
            return GeneratorFunction(numbers).GetEnumerator();
        }

        /*
         * What this does is that it accessess the generator function and calls
         * the items inside the enumerator one at a time, it will also move to
         * the next value to yield
         * 
         * This will return -1 if the Generator function has no more items to yield
         */
        private static int GetNumber(IEnumerator<int> enumerator)
        {
            enumerator.MoveNext();
            return enumerator.Current;
        }
    }
}