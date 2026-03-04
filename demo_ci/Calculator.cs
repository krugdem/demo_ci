namespace demo_ci
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            if (x < 1 || y < 1)
            {
                throw new ArgumentException("Параметры не могут быть меньше нуля"); 
            }
            return checked(x + y);
        }
    }
}
