/*
 * Copyright © 2017 mik14a <mik14a@gmail.com>
 * This work is free. You can redistribute it and/or modify it under the
 * terms of the Do What The Fuck You Want To Public License, Version 2,
 * as published by Sam Hocevar. See the COPYING file for more details.
 */

using System;
using System.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Axel.TestTools.UnitTesting.TestRunner.Test
{
    [TestClass]
    public class TestRunnerTest
    {
        public bool Initialized { get; set; }

        [TestInitialize]
        public void InitializeTest() {
            Initialized = true;
        }

        [TestMethod]
        public void EmptyTest() {
            var runner = new System.TestTools.UnitTesting.TestRunner();
            Assert.IsNotNull(runner);
        }

        [TestMethod]
        public void InitializedTest() {
            if (!Initialized) {
                throw new InvalidOperationException();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectedExceptionTest() {
            throw new ArgumentException();
        }

        [TestCleanup]
        public void CleanupTest() {
        }
    }
}
