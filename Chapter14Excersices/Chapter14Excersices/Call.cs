using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter14Excersices
{
    class Call
    {
        private DateTime date;
        private DateTime startTime;
        private int timeCall;
        private string callerName;

        public DateTime Date
        {
            get
            {
                return this.date;
            }
        }
        public DateTime StartTime
        { 
            get
            {
                return this.startTime;
            }
        }
        public int TimeCall
        {
            get
            {
                return this.timeCall;
            }
        }

        public string CallerName
        {
            get
            {
                return this.callerName;
            }
        }
        public Call(string callerName, DateTime date, DateTime startTime, int timeCall)
        {
            this.callerName = callerName;
            this.date = date;
            this.startTime = startTime;
            this.timeCall = timeCall;
        }
    }
}
