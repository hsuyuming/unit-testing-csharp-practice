﻿
using System;

namespace TestNinja.Fundamentals
{
    public class ErrorLogger
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

            //original
            ErrorLogged?.Invoke(this, Guid.NewGuid());

            _errorId = Guid.NewGuid();

        }

    }
}