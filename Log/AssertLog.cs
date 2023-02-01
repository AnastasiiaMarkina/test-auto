
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using NUnit.Framework;

namespace Automation_project.Helpers
{
    public static class AssertLog
    {
        public static void AreEqual(object expected, object actual)
        {
            Assert.AreEqual(expected, actual);
        }
        public static void AreEqual(object expected, object actual, string message)
        {
            Assert.AreEqual(expected, actual, message);
        }
        public static void AreEqual(float expected, float actual, float delta)
        {
            Assert.AreEqual(expected, actual, delta);
        }
        public static void AreEqual(double expected, double actual, double delta)
        {
            Assert.AreEqual(expected, actual, delta);
        }
        public static void AreEqual(object expected, object actual, string message, params object[] parameters)
        {
            Assert.AreEqual(expected, actual, message, parameters);
        }
        public static void AreEqual(double expected, double actual, double delta, string message)
        {
            Assert.AreEqual(expected, actual, delta, message);
        }
        
        public static void AreEqual(float expected, float actual, float delta, string message)
        {
            Assert.AreEqual(expected, actual, delta, message);
        }
        
        public static void AreEqual(double expected, double actual, double delta, string message, params object[] parameters)
        {
            Assert.AreEqual(expected, actual, delta, message, parameters);
        }
        public static void AreEqual(float expected, float actual, float delta, string message, params object[] parameters)
        {
            Assert.AreEqual(expected, actual, delta, message, parameters);
        }
        
        public static void AreEqual<T>(T expected, T actual)
        {
            Assert.AreEqual(expected, actual);
        }
        public static void AreEqual<T>(T expected, T actual, string message)
        {
            Assert.AreEqual(expected, actual, message);
        }
        public static void AreEqual<T>(T expected, T actual, string message, params object[] parameters)
        {
            Assert.AreEqual(expected, actual, message, parameters);
        }
        public static void AreNotEqual(object notExpected, object actual)
        {
            Assert.AreNotEqual(notExpected, actual);
        }
        
        public static void AreNotEqual(object notExpected, object actual, string message)
        {
            Assert.AreNotEqual(notExpected, actual, message);
        }
        
        public static void AreNotEqual(object notExpected, object actual, string message, params object[] parameters)
        {
            Assert.AreNotEqual(notExpected, actual, message, parameters);
        }
        
        public static void AreNotEqual<T>(T notExpected, T actual)
        {
            Assert.AreNotEqual(notExpected, actual);
        }
        public static void AreNotEqual<T>(T notExpected, T actual, string message)
        {
            Assert.AreNotEqual(notExpected, actual, message);
        }
        public static void AreNotEqual<T>(T notExpected, T actual, string message, params object[] parameters)
        {
            Assert.AreNotEqual(notExpected, actual, message, parameters);
        }
        public static void AreNotSame(object notExpected, object actual)
        {
            Assert.AreNotSame(notExpected, actual);
        }
        public static void AreNotSame(object notExpected, object actual, string message)
        {
            Assert.AreNotSame(notExpected, actual, message);
        }
        public static void AreNotSame(object notExpected, object actual, string message, params object[] parameters)
        {
            Assert.AreNotSame(notExpected, actual, message, parameters);
        }
        public static void AreSame(object expected, object actual)
        {
            Assert.AreSame(expected, actual);
        }
        public static void AreSame(object expected, object actual, string message)
        {
            Assert.AreSame(expected, actual, message);
        }
        public static void AreSame(object expected, object actual, string message, params object[] parameters)
        {
            Assert.AreSame(expected, actual, message, parameters);
        }
        public static void Fail()
        {
            Assert.Fail();
        }
        public static void Fail(string message)
        {
            Assert.Fail(message);
        }
        public static void Fail(string message, params object[] parameters)
        {
            Assert.Fail(message, parameters);
        }
        public static void Inconclusive()
        {
            Assert.Inconclusive();
        }
        public static void Inconclusive(string message)
        {
            Assert.Inconclusive(message);
        }
        public static void Inconclusive(string message, params object[] parameters)
        {
            Assert.Inconclusive(message, parameters);
        }
        public static void IsFalse(bool condition)
        {
            Assert.IsFalse(condition);
        }
        public static void IsFalse(bool condition, string message)
        {
            Assert.IsFalse(condition, message);
        }
        public static void IsFalse(bool condition, string message, params object[] parameters)
        {
            Assert.IsFalse(condition, message, parameters);
        }
        public static void IsNotNull(object value)
        {
            Assert.IsNotNull(value);
        }
        public static void IsNotNull(object value, string message)
        {
            Assert.IsNotNull(value, message);
        }
        public static void IsNotNull(object value, string message, params object[] parameters)
        {
            Assert.IsNotNull(value, message, parameters);
        }
        public static void IsNull(object value)
        {
            Assert.IsNull(value);
        }
        public static void IsNull(object value, string message)
        {
            Assert.IsNull(value, message);
        }
        public static void IsNull(object value, string message, params object[] parameters)
        {
            Assert.IsNull(value, message, parameters);
        }
        public static void IsTrue(bool condition)
        {
            Assert.IsTrue(condition);
        }
        public static void IsTrue(bool condition, string message)
        {
            Assert.IsTrue(condition, message);
        }
        public static void IsTrue(bool condition, string message, params object[] parameters)
        {
            Assert.IsTrue(condition, message, parameters);
        }
    }
}
