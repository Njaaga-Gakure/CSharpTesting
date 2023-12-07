

using Assessment;

namespace AssessmentTest
{
    [TestFixture]
    public class TraineeTest
    {
        private Trainee _trainee;
         
        [SetUp]
        public void SetUp() {
            _trainee = new Trainee();
        }

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("      ")]
        [TestCase(null)]
        public void addStudent_WhenCalledWithNullOrEmptyValue_ItShouldThrowAnError(string text) {
            Assert.That(() => _trainee.addStudent(text), Throws.TypeOf<ArgumentNullException>());           
        }

        [Test]
        [TestCase("student1")]
        public void addStudent_WhenCalledWithSameArgumentMoreThanOne_ItShouldThrowAnError(string text)
        {
            _trainee.addStudent(text);
            Assert.That(() => _trainee.addStudent(text), Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("      ")]
        [TestCase(null)]
        public void removeStudent_WhenCalledWithNullOrEmptyValue_ItShouldThrowAnError(string text)
        {
            Assert.That(() => _trainee.removeStudent(text), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        [TestCase("student1")]
        public void removeStudent_WhenCalledWithSameArgumentMoreThanOne_ItShouldThrowAnError(string text)
        {
            Assert.That(() => _trainee.removeStudent(text), Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        [TestCase("Brian", "")]
        [TestCase("Kush", "Kush")]
        public void SearchStudent_WhenCalled_ItShouldReturnNameOrEmptyString(string name, string output) {
            _trainee.addStudent("Kush");
            var result = _trainee.SearchStudent(name);
            Assert.That(result, Is.EqualTo(output));
        }

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("      ")]
        [TestCase(null)]
        public void SearchStudent_WhenCalledWithNullOrEmptyValue_ItShouldThrowAnError(string text)
        {
            Assert.That(() => _trainee.SearchStudent(text), Throws.TypeOf<ArgumentNullException>());
        }

       

    }
}
