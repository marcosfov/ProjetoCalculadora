namespace CalculatorAPI.Models
{
    public class Calculadora
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Result { get; set; }



        public Calculadora(double value1, double value2)
        {
            this.Value1 = value1;
            this.Value2 = value2;
        }

        public void sum()
        {
            Result = Value1 + Value2;
        }

        public void subtract()
        {
            Result = Value1 - Value2;
        }

        public void multiply()
        {
            Result = Value1 * Value2;
        }

        public void divide()
        {
            Result = Value1 / Value2;
        }

    }
}
