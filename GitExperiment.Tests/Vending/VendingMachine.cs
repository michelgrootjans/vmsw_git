namespace GitExperiment.Tests.Vending
{
    public class VendingMachine
    {
        public int Credit { get; private set; }

        public void Insert(int coin)
        {
            Credit += coin;
        }
    }
}