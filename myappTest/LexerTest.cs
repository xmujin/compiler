
using myapp.Model.Lexer;
using Newtonsoft.Json.Linq;

namespace myapp.Test
{
    [TestFixture]
    public class LexerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("I LOVE YOU")]
        [TestCase("I, LOVE YOU")]
        public void FullScanTest(string value)
        {
            Lexer lexer = new Lexer(value);

            Console.WriteLine(lexer.NewScan());
            Assert.AreEqual("1", lexer.NewScan());
            
        }
        [Test]
        public void FullScanOutTest()
        {
            string sourceDirectory = @"H:\MyTests\compile\myapp\myappTest";
            Directory.SetCurrentDirectory(sourceDirectory);


            string a = File.ReadAllText("LexerAnalysis/test1.txt");
           
            Lexer lexer = new Lexer(a);

            File.WriteAllText("LexerAnalysis/res.txt", lexer.NewScan());
            

            Assert.Pass();
        }

        [Test]
        public void SSS()
        {
            char a = '\n';

            Console.WriteLine((int)a);

        }
    }
}