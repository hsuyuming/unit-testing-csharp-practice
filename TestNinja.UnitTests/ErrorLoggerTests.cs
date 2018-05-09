﻿using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InValidError_ThrowArgumenNullException(string error)
        {
            var logger = new ErrorLogger();

            //            looger.Log("error");



            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
            // Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<DivideByZeroException>());

        }


        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();

            //subscribe that event

            var id = Guid.Empty;


            logger.ErrorLogged += (sender, args) => { id = args; };

            logger.Log("a");



            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}