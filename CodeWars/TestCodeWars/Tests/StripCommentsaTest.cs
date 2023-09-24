using System;
using System.Collections;
using NUnit.Framework;
namespace TestCodeWars.Tests;
[TestFixture]

public class StripCommentsTest
{
    [Test]
    public void StripCommentsT()
    {
        Assert.AreEqual(
                "apples, pears\ngrapes\nbananas",
               StripComments.StripComment("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));

        Assert.AreEqual("a\nc\nd", StripComments.StripComment("a #b\nc\nd $e f g", new string[] { "#", "$" }));

    }
}