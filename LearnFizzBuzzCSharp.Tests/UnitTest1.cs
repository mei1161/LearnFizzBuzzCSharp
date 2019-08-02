using LearnFizzBuzzCSharp;
using NUnit.Framework;
using System.Linq;
namespace Tests
{
    public class Tests
    {

        [Test]
        public void _1‚ªŽæ“¾‚Å‚«‚é()
        {
            var i = FizzBuzz.GetNum();
            Assert.That(i.ElementAt(0), Is.EqualTo("1"));
        }

        [Test]
        public void _Fizz‚ªŽæ“¾‚Å‚«‚é()
        {
            var i = FizzBuzz.GetNum();
            Assert.That(i.ElementAt(2), Is.EqualTo("Fizz"));
        }

        [Test]
        public void _Buzz‚ªŽæ“¾‚Å‚«‚é()
        {
            var i = FizzBuzz.GetNum();
            Assert.That(i.ElementAt(4), Is.EqualTo("Buzz"));
        }
        [Test]
        public void _FizzBuzz‚ªŽæ“¾‚Å‚«‚é()
        {
            var i = FizzBuzz.GetNum();
            Assert.That(i.ElementAt(14), Is.EqualTo("FizzBuzz"));
        }
    }
}
