using NUnit.Framework;

namespace TransformerTask.Tests
{
    [TestFixture]
    public class TransformerTests
    {
        [TestCase(new[] {-255.255, 255.255, 4294967295.0, double.Epsilon, double.NaN, double.MinValue},
            ExpectedResult = new[]
            {
                "1100000001101111111010000010100011110101110000101000111101011100",
                "0100000001101111111010000010100011110101110000101000111101011100",
                "0100000111101111111111111111111111111111111000000000000000000000",
                "0000000000000000000000000000000000000000000000000000000000000001",
                "1111111111111000000000000000000000000000000000000000000000000000",
                "1111111111101111111111111111111111111111111111111111111111111111"
            })]
        [TestCase(new[] {double.PositiveInfinity, 0.0, double.NegativeInfinity, -0.0},
            ExpectedResult = new[]
            {
                "0111111111110000000000000000000000000000000000000000000000000000",
                "0000000000000000000000000000000000000000000000000000000000000000",
                "1111111111110000000000000000000000000000000000000000000000000000",
                "1000000000000000000000000000000000000000000000000000000000000000"
            })]
        public string[] TransformTests(double[] source)
        {
            var transformer = new Transformer();
            return transformer.Transform(source);
        }

        //TODO: Add tests for Exception cases here.
    }
}