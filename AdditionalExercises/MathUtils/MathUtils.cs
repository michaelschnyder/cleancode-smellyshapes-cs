namespace AdditionalExercises.MathUtils
{
    public class MathUtils
    {
        private MathUtils()
        {
        }

        public static bool IsDivisibleBy3(int number)
        {
            return number % 3 == 0;
        }

        public static bool IsDivisibleBy5(int number)
        {
            return number % 5 == 0;
        }
    }
}