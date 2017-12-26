namespace SimpleFactoryPattern
{
    class OperationDiv : Operation
    {
        public override double getResult(double numA, double numB)
        {
            if (numB != 0)
            {
                return numA / numB;
            }
            else
            {
                return 0;
            }
        }
    }
}
