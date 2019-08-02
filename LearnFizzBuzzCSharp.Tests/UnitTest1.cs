using LearnFizzBuzzCSharp;
using NUnit.Framework;
using System.Linq;
namespace Tests
{
    public class Tests
    {

        [Test]
        public void _1���擾�ł���()
        {
            var i = FizzBuzz.GetNum();
            Assert.That(i.ElementAt(0), Is.EqualTo("1"));
        }

        [Test]
        public void _Fizz���擾�ł���()
        {
            var i = FizzBuzz.GetNum();
            Assert.That(i.ElementAt(2), Is.EqualTo("Fizz"));
        }

        [Test]
        public void _Buzz���擾�ł���()
        {
            var i = FizzBuzz.GetNum();
            Assert.That(i.ElementAt(4), Is.EqualTo("Buzz"));
        }
        [Test]
        public void _FizzBuzz���擾�ł���()
        {
            var i = FizzBuzz.GetNum();
            Assert.That(i.ElementAt(14), Is.EqualTo("FizzBuzz"));
        }
    }
}
