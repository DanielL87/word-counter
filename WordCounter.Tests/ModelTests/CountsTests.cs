using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordApp;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
   [TestMethod]
    public void WordInput_TestThatWordisString_string()
    {
      WordCount myWord = new WordCount();
      Assert.AreEqual("string", myWord.wordInput("string"));
    }
   [TestMethod]
    public void Counter_CheckForInstanceOfWordInSentence_int()
    {
      WordCount myWord = new WordCount();
      string Word = "dog";
      string Sentence = "My dog is a dog";
      

      Assert.AreEqual(2, myWord.countWords(Word,Sentence));
    }  
  }
}