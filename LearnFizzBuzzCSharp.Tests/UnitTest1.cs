using LearnFizzBuzzCSharp;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void _1���擾�ł���()
        {
            var i = FizzBuzz.ReturnNum();
            Assert.That(i, Is.EqualTo("1"));
        }
    }
}
