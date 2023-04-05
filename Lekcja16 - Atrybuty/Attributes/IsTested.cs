using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja16___Atrybuty.Attributes
{
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Struct |
        AttributeTargets.Enum |
        AttributeTargets.Delegate |
        AttributeTargets.Method |
        AttributeTargets.Field |
        AttributeTargets.Event |
        AttributeTargets.Property)]
    public class IsTested : Attribute
    {
        public string TestMessage { get; set; }

        public IsTested(string testMessage)
        {
            TestMessage = testMessage;
        }

        public override string ToString()
        {
            return TestMessage;
        }
    }
}
