using System;

namespace Day01.Library
{
    //internal delegate void SendingSms(object sender, string message);

    internal class Worker
    {
        //public event SendingSms WorkerMobilePhone;
        public event Action<object,string> WorkerMobilePhone;

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

            WorkerMobilePhone?.Invoke(this, $"{subject} done at: {DateTime.Now}");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
