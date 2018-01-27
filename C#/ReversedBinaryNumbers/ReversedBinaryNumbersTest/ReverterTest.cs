using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System.Linq;
using System.Collections.Generic;
using ReversedBinaryNumbers;

namespace ReversedBinaryNumbersTest
{
    [TestClass]
    public class ReverterTest
    {
        [TestMethod]
        public void GivenZero_WhenRevert_ThenArgumentOutOfRangeExceptionShouldBeThrown()
        {
            var reverter = new Reverter();

            Should.Throw<ArgumentOutOfRangeException>(() => reverter.Revert(0));
        }

        [TestMethod]
        public void GivenOneBilionAndOne_WhenRevert_ThenArgumentOutOfRangeExceptionShouldBeThrown()
        {
            var reverter = new Reverter();

            Should.Throw<ArgumentOutOfRangeException>(() => reverter.Revert(1000000001));
        }

        [TestMethod]
        public void GivenOneBilion_WhenRevert_ThenItShouldBe1365623()
        {
            var reverter = new Reverter();

            reverter.Revert(1000000000).ShouldBe(1365623);
        }

        [TestMethod]
        public void Given1_WhenRevert_ThenItShouldBe1()
        {
            var reverter = new Reverter();

            reverter.Revert(1).ShouldBe(1);
        }

        [TestMethod]
        public void Given13_WhenRevert_ThenItShouldBe11()
        {
            var reverter = new Reverter();

            reverter.Revert(13).ShouldBe(11);
        }

        [TestMethod]
        public void Given47_WhenRevert_ThenItShouldBe61()
        {
            var reverter = new Reverter();

            reverter.Revert(47).ShouldBe(61);
        }
    }
}
