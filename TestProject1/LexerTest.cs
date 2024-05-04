using myapp.Model.Lexer;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

            
        }

        [TestCase("int", "int")]
        [TestCase("int a", "int a")]
        [TestCase("int a,i,k", "int a , i , k")]
        [TestCase("int main()", "int main ( )")]
        public void TestTokens(string input, string expected)
        {

            Lexer lexer = new Lexer(input);
            Assert.That(lexer.GetTokenList(), Is.EqualTo(expected));
        }
    }
}