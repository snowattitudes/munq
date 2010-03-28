﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Munq.FluentTest;

namespace Munq.FluentTest.UnitTests
{  
    /// <summary>
    ///This is a test class for IFluentTestTest and is intended
    ///to contain all IFluentTestTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IFluentTestStringIsEqualToTest
    {
        private const string testString = "May the Force be with you.";
            
        #region IsEqualTo
        [TestMethod]
        public void StringIsEqualToFailsIfStringToCompareIsNull()
        {
            Verify.TheExpectedException(Verify.FailExceptionType).IsThrownWhen(
                () => Verify.That(testString).IsAString().IsEqualTo(null)
            );
        }

        [TestMethod]
        public void StringIsEqualToFailsIfDoesIsEqualTotring()
        {
            Verify.TheExpectedException(Verify.FailExceptionType).IsThrownWhen(
                () => Verify.That(testString).IsAString().IsEqualTo("monkey")
            );
        }
        
        [TestMethod]
        public void StringIsEqualToPassesIfStringIsEqualToStringToCompare()
        {
            Verify.That(testString).IsAString().IsEqualTo(testString);
        }

        [TestMethod]
        public void StringIsEqualToFailsIfStringToCompareIsEmpty()
        {
            Verify.TheExpectedException(Verify.FailExceptionType).IsThrownWhen(
                () => Verify.That(testString).IsAString().IsEqualTo(String.Empty)
            );
        }
        #endregion

        #region IsNotEqualTo            
        [TestMethod]
        public void StringIsNotEqualToFailsIfStringToCompareIsNull()
        {
            Verify.TheExpectedException(Verify.FailExceptionType).IsThrownWhen(
                () => Verify.That(testString).IsAString().IsNotEqualTo(null)
            );
        }

        [TestMethod]
        public void StringIsNotEqualToFailsIfDoesIsEqualTotring()
        {
            Verify.TheExpectedException(Verify.FailExceptionType).IsThrownWhen(
                () => Verify.That(testString).IsAString().IsNotEqualTo(testString)
            );
        }
        
        [TestMethod]
        public void StringIsNotEqualToPassesIfStringIsNotEqualToStringToCompare()
        {
            Verify.That(testString).IsAString().IsNotEqualTo("monkey");
        }

        [TestMethod]
        public void StringIsNotEqualToFailsIfStringToCompareIsEmpty()
        {
            Verify.TheExpectedException(Verify.FailExceptionType).IsThrownWhen(
                () => Verify.That(testString).IsAString().IsNotEqualTo(String.Empty)
            );
        }
       #endregion
    }
}
