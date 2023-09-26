namespace Payments.Tests
{
    public class Payment
    {
        private IPackingSlip _packingSlip;

        public Payment(IPackingSlip packingSlip)
        {
            _packingSlip = packingSlip;
        }

        public void Pay(PhysicalProducts phisicalProducts)
        {
            _packingSlip.GeneratePackingSlip();
        }
    }
}