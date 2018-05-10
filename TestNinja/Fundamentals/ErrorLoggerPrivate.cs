using System;

namespace TestNinja.Fundamentals
{
    public class ErrorLoggerPrivate
    {
        private Guid _errorId;
        public string LastError { get; set; }

        //1.Define a delegate 
        //public delegate void LogEventHandler(object source, Guid args)

        //2.Define an event based on that delegate
        //public event LogEventHandler Logged;

        //Simple way EventHandler<TEventArgs>
        public event EventHandler<Guid> ErrorLogged;

        public void Log(string error)
        {
            if (String.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();

            LastError = error;

            // Write the log to a storage
            // ...

            //Method1
            //            _errorId = Guid.NewGuid();
            //            OnErrorLogged();

            //Method2
            //ErrorLogged?.Invoke(this, _errorId);

            //Normal
            //_errorId = Guid.NewGuid();

            //Normal2
            OnErrorLogged(Guid.NewGuid());


        }

        //        public virtual void OnErrorLogged()
        //        {
        //            ErrorLogged?.Invoke(this, _errorId);
        //        }

        public virtual void OnErrorLogged(Guid errorId)
        {
            ErrorLogged?.Invoke(this, errorId);
        }

    }
}
