using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer;

namespace TestProject1
{
    ////[TestClass]
    //public class UnitTest1
    //{
    //    [TestMethod]
    //    public void GivenSadMoodShouldReturnSAD()
    //    {
    //        string expected = "SAD";
    //        string message = " i an in sad mood";
    //        MoodAnalizer moodAnalizer = new MoodAnalizer(message);
    //        string mood = moodAnalizer.AnalyseMood();
    //        Assert.AreEqual(expected, mood);
    //    }
    //}
    [TestClass]
    public class TestMood
    {
        [TestMethod]
        public void NullMood()
        {
            string msg = " ";
            string expected = "HAPPY";

            MoodAnalizer mood = new MoodAnalizer(msg);

            string actual = mood.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getCustomNullException()
        {
            string expected = "message should not be null";
            MoodAnalizer modeAnalyzer = new MoodAnalizer(" ");

            try
            {
                string actual = modeAnalyzer.AnalyseMood();

            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void getCustomEmptyException()
        {
            string expected = "message should not be empty";
            MoodAnalizer modeAnalyzer = new MoodAnalizer(string.Empty);

            try
            {
                string actual = modeAnalyzer.AnalyseMood();

            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
        [TestMethod]

        public void MoodAnalyseClassName()
        {
            try
            {
                string msg = null;

                object expected = new MoodAnalizer(msg);
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser");
                expected.Equals(obj);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        [TestMethod]

        public void MoodAnalyseWrongClassName()
        {
            try
            {
                string msg = null;
                object expected = new MoodAnalizer(msg);
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyserWrong", "MoodAnalyserWrong");
                expected.Equals(obj);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        [TestMethod]

        public void MoodAnalyseWrongConstructor()
        {
            try
            {
                string msg = null;
                object expected = new MoodAnalizer(msg);
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyserWrong");
                expected.Equals(obj);
            }

            catch (CustomException ex)
            {
                Assert.AreEqual("Constructor not found", ex.Message);
            }
        }
    }
}