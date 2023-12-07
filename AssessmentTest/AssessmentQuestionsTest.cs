using Assessment;
using System.Numerics;

namespace AssessmentTest
{
    [TestFixture]
    public class AssessmentQuestionsTest
    {
        private AssessmentQuestions _assessment;
        [SetUp]
        public void Setup()
        {
            _assessment = new AssessmentQuestions();
        }

        [Test]
        [TestCase("500", 5)]
        [TestCase("-65", -56)]
        [TestCase("005005000", 500500)]
        [TestCase("4", 4)]
        public void ReverseInteger_WhenCalled_ItShouldReturnAReversedInterger(string number, int reversedNumber)
        {
            var result = _assessment.ReverseInteger(number);
            Assert.That(result, Is.EqualTo(reversedNumber));
        }

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("     ")]
        [TestCase(null)]
        public void ReverseInteger_WhenCalledWithNullOrEmptyValues_ItShouldThrowAnException(string number) {
            Assert.That(() => _assessment.ReverseInteger(number), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        [TestCase("one")]
        public void ReverseInteger_WhenCalledWithValueThatCannotBeConvertToInt_ItShouldThrowAnException(string number)
        {
            Assert.That(() => _assessment.ReverseInteger(number), Throws.TypeOf<FormatException>());
        }

            [Test]
        [TestCase("hello", "Hello")]
        [TestCase("hello world", "Hello World")]
        [TestCase("Hello World", "Hello World")]
        [TestCase("h", "H")]
        public void CapitalizeString_WhenCalled_ItShouldReturnACapitalizedString(string text, string capitalizedText) {

            var result = _assessment.CapitalizeString(text);

            Assert.That(result, Is.EqualTo(capitalizedText));
        }

        [Test]
        [TestCase("level", true)]
        [TestCase("", true)]
        [TestCase("a", true)]
        [TestCase("arsenal", false)]
        [TestCase("abccba", true)]
        public void CheckIfPalindrome_WhenCalled_ItShouldReturnTrueOrFalse(string text, bool isPalindrome) {
            var result = _assessment.CheckIfPalindrome(text);

            Assert.That(result, Is.EqualTo(isPalindrome));
        }

        [Test]
        [TestCase("level", 2)]
        [TestCase("AeIOu", 5)]
        [TestCase("ywh", 0)]
        public void CountVowels_WhenCalled_ItShouldReturnTheVowelCount(string text, int vowelCount) {
            var result = _assessment.CountVowels(text);

            Assert.That(result, Is.EqualTo(vowelCount));
        }

        [Test]
        [TestCase("jonathan", 'n')]
        [TestCase("11123", '1')]
        [TestCase("kelvin", 'k')]
        public void MostApperingCharacter_WhenCalled_ItShouldReturnTheMostAppearingCharacter(string text, char mostAppearingCharacter) {
            var result = _assessment.MostApperingCharacter(text);
            Assert.That(result, Is.EqualTo(mostAppearingCharacter));
        }

        [Test]
        public void CreateChunkedArray_WhenCalledWithArrayLengthDivisibleByChun_ItShouldReturnAnArrayOfArrays()
        {
            var matrix = new int[][] {
                new int[] {1, 2}
            };

            var result = _assessment.CreateChunkedArray(new int[2] { 1, 2 }, 3);
            Assert.That(result, Is.EquivalentTo(matrix));
        }

        [Test]

        public void CreateChunkedArray_WhenCalledWithAChunkSizeDivisibleWithArrayLength_ItShouldReturnAnArrayOfArrays()
        {
            var matrix = new int[][]
           {
                new int[] {1, 2, 3 },
                new int[] {4, 5, 6},
                new int[] {7, 8, 9},
           };
            var result = _assessment.CreateChunkedArray(new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3);
            Assert.That(result, Is.EquivalentTo(matrix));
        }

        [Test]
        public void CreateChunkedArray_WhenCalledWithAChunkSizeNotDivisibleWithArrayLength_ItShouldReturnAnArrayOfArrays()
        {
            var matrix = new int[][]
            {
                new int[] {1, 2, 3 },
                new int[] {4, 5, 6},
                new int[] {7},
            };
            var result = _assessment.CreateChunkedArray(new int[7] { 1, 2, 3, 4, 5, 6, 7}, 3);
            Assert.That(result, Is.EquivalentTo(matrix));
        }

        [Test]
        public void CreateChunkedArray_WhenCalledWithArraySmallerThanChunkSize_ItShouldReturnAnArrayOfArrays()
        {
            var matrix = new int[][]
            {
                new int[] {1, 2}
            };

            var result = _assessment.CreateChunkedArray(new int[2] { 1, 2 }, 3);
            Assert.That(result, Is.EquivalentTo(matrix));
        }
    }
}