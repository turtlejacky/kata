using System;

namespace RunnerMeetings
{
    public class RunnerMeetingsHelper
    {
        public int RunnersMeetings(int[] StartPosition, int[] speed)
        {
            int ans = -1;
            for (int i = 0; i < StartPosition.Length; i++ ) {
                for (int j = i + 1; j < StartPosition.Length; j++)
                {
                    TimeOfMeet meetingTimeA = MeetingTime(StartPosition[i], StartPosition[j], speed[i], speed[j]);
                    if ( !meetingTimeA.IsMeet )
                        continue;
                    int numOfMeet = 2;
                    for (int k = j + 1; k < StartPosition.Length; k++)
                    {
                        TimeOfMeet meetingTimeB = MeetingTime(StartPosition[i], StartPosition[k], speed[i], speed[k]);
                        if ( meetingTimeA.Compare( meetingTimeB ) )
                            numOfMeet++;
                    }
                    ans = Math.Max(ans, numOfMeet);
                }
            }
            return ans;

        }


        public TimeOfMeet MeetingTime(int StartPointA, int StartPointB, int speedA, int speedB)
        {
            if (StartPointA == StartPointB)  // meet on startPoint
                return new TimeOfMeet() { Distance = 0, Speed = 0, IsMeet = true};
            int distance = StartPointA - StartPointB, speed = speedB - speedA;

            if ( distance == 0 )
                return new TimeOfMeet() { Distance = 0, Speed = 0, IsMeet = true };
            else if ( speed == 0 )
                return new TimeOfMeet() { Distance = 0, Speed = 0, IsMeet = false };
            else if ( ( distance < 0 && speed > 0 ) || (distance > 0 && speed < 0) )
                return new TimeOfMeet() { Distance = 0, Speed = 0, IsMeet = false };
            int numOfGCD = GCD( distance, speed);
            return new TimeOfMeet(){ Distance = distance / numOfGCD, Speed = speed / numOfGCD, IsMeet = true };

                    
        }


        public int GCD(int a, int b)
        {
            return (a % b == 0) ? b : GCD(b, a % b);
           
        }
    }


    public class TimeOfMeet {
        public int Distance {
            set;
            get;
        }

        public int Speed{
            set;
            get;
        }
        public bool IsMeet{
            set;
            get;
        }
        public bool Compare( TimeOfMeet x ) 
        {
            if ((x.Distance == this.Distance) &&
                (x.Speed == this.Speed) &&
                (x.IsMeet == this.IsMeet))
                return true;
            else
                return false;

        } 

    }
}
