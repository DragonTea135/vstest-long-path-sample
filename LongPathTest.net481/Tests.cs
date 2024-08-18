using NUnit.Framework;
using System.IO;
using System.Linq;

namespace LongPathTest;

public class Tests {
    [Test]
    public void TestLongPath() {
        Directory.CreateDirectory(
            Path.Combine([
                TestContext.CurrentContext.TestDirectory,
                ..Enumerable.Repeat("SubDir", 100)]));
        Assert.Pass();
    }

    [Test]
    public void TestShortPath() {
        Directory.CreateDirectory(
            Path.Combine([
                TestContext.CurrentContext.TestDirectory,
                ..Enumerable.Repeat("SubDir", 3)]));
        Assert.Pass();
    }
}