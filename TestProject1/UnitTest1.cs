using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            string expected = "SAD";
            string message = " i an in sad mood";
            MoodAnalizer moodAnalizer = new MoodAnalizer(message);
            string mood = moodAnalizer.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
    }
}
