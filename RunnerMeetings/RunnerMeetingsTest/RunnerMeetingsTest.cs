using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RunnerMeetings
{
    [TestClass]
    public class UnitTest1
    {
        RunnerMeetingsHelper runnerMeetingsHelper = new RunnerMeetingsHelper();
        [TestMethod]
        public void TestBasic()
        {
            Assert.AreEqual(2, runnerMeetingsHelper.RunnersMeetings(new int[] { 1, 2 }, new int[] { 5, 4 }));

            Assert.AreEqual(2,  runnerMeetingsHelper.RunnersMeetings(new int[]{1, 4, 2},new int[]{5, 6, 2}));
            
            Assert.AreEqual(-1,  runnerMeetingsHelper.RunnersMeetings(new int[]{1, 2, 3},new int[]{1, 1, 1}));
            
            Assert.AreEqual(2,  runnerMeetingsHelper.RunnersMeetings(new int[]{1, 1000},new int[]{23, 22}));

            Assert.AreEqual(3, runnerMeetingsHelper.RunnersMeetings(new int[] { 1, 4, 2 }, new int[] { 27, 18, 24 }));


        }
        [TestMethod]
        public void TestAdvanced(){
            Assert.AreEqual(2, runnerMeetingsHelper.RunnersMeetings(new int[] { 45, -32, 46, 11, -1, 39, 49, 17, 43 }, new int[] { 4, 25, 21, 26, 4, 13, 14, 2, 11 }));

        }



        [TestMethod]
        public void TestGetMeetingTime()
        {
            var actual = runnerMeetingsHelper.MeetingTime( 1,2, 5,4);
            var expected = new TimeOfMeet
            {
                Distance = 1,
                Speed = 1,
                IsMeet = true
            };
            Assert.AreEqual(expected.Distance, actual.Distance);
            Assert.AreEqual(expected.Speed, actual.Speed);
            Assert.AreEqual(expected.IsMeet, actual.IsMeet);

        }
        [TestMethod]
        public void TestGetMeetingTime2()
        {
            var actual = runnerMeetingsHelper.MeetingTime(1, 4, 27, 18);
            var expected = new TimeOfMeet
            {
                Distance = 1,
                Speed = 3,
                IsMeet = true
            };
            Assert.AreEqual(expected.Distance, actual.Distance);
            Assert.AreEqual(expected.Speed, actual.Speed);
            Assert.AreEqual(expected.IsMeet, actual.IsMeet);

        }

        [TestMethod]
        public void TestGCD() {
            Assert.AreEqual(9, runnerMeetingsHelper.GCD(18, 27));
         
        }
    }
}
