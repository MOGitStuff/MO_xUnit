using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleXUnit
{
   public class Class1
   {
      [Fact]
      public void TestMe()
      {
         Assert.True(true);
      }
   }
}
