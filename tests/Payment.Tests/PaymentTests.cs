using Moq;
using Payments.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Tests
{
    public class PaymentTests
    {
        //* If the payment is for a physical product, generate a packing slip for shipping.

        [Fact]
        public void ShoudGenerateAPackingSlipWhenIsAPhysicalProduct()
        {
            Mock<IPackingSlip> packingSlip = new(); //Arrange - Organização - Prep p/ test
            packingSlip.Setup(x=>x.GeneratePackingSlip()).Returns(true);
            PhysicalProducts phisicalProducts = new();//Arrange
            Payment payments = new(packingSlip.Object);//Arrange
            
            payments.Pay(phisicalProducts);//Act - Teste

            //Assert - verificando condição do teste
            packingSlip.Verify(x => x.GeneratePackingSlip(),Times.Once);

        }
       
        //* If the payment is for a book, create a duplicate packing slip for the royalty department.
        public void ShoudDuplicateAPackingSlipWhenItsABook()
        {

        }

    }
}
