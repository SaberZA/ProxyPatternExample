using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternExample
{
    using NUnit.Framework;

    [TestFixture]
    public class TestOrder
    {
        // ReSharper disable InconsistentNaming
        [Test]
        public void PopulateOrderFullyOnCreation()
        {
            //---------------Set up test pack-------------------
            var myOrder = new Order(1);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            DisplayDetails.Display(myOrder);
            //---------------Test Result -----------------------
        }

        [Test]
        public void PopulateOrderProxy()
        {
            //---------------Set up test pack-------------------
            var myOrder = new OrderProxy(1);
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            DisplayDetails.Display(myOrder);
            //---------------Test Result -----------------------
        }
    }
}
