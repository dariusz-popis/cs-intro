using System;

namespace Day01.Library
{
    //internal delegate void SendingSms(object sender, string message);
    internal class WorkerEventArgs : EventArgs
    {
        public string Message { get; set; }
        public byte[] Picture { get; set; }
    }
    internal class Worker
    {
        //public event SendingSms WorkerMobilePhone;
        public event Action<object, WorkerEventArgs> WorkerMobilePhone;

        public string Name { get; }

        [Obsolete("Soon this constructor will be removed", true)]
        public Worker()
        {
        }

        public Worker(string name)
        {
            Name = name;
        }

        public void DoWork(string subject)
        {
            subject.Length.SleepSec();

            //if(workerMobilePhone!=null) workerMobilePhone.Invoke(this, $"{subject} done at: {DateTime.Now}");
            //if(workerMobilePhone!=null) workerMobilePhone(this, $"{subject} done at: {DateTime.Now}");

            WorkerMobilePhone?.Invoke(this, new WorkerEventArgs() { Message = $"{subject} done at: {DateTime.Now}" });
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
