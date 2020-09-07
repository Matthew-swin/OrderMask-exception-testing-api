using System;
using Xunit;
using MaskApi.models;

namespace MaskTests
{
    public class MaskTest
    {   
        //specify either fact or theory for a test
        [Fact]
        public void ConstructorTest()
        {   
            // will get an error if not assigned a value
            Mask newMask = null;
            try {
            newMask = new Mask("m-9999",1, "White", true, false, "Flowers", true, 10.00);
            }
            catch (Exception ex) {
                System.Environment.Exit(1);
            }
            //to test the constructors value
            Assert.True(newMask.New);
        }
    }
}
