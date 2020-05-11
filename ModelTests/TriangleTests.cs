using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.TestTools
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void IsTriangle_ValueIsRealPositiveNumber_True()
    {
      Triangle tri = new Triangle();
      Assert.AreEqual(true, tri.IsTriangle("2", "3", "4"));

    }
    [TestMethod]
    public void IsTriangle_ValueIsRealPositiveNumber_False()
    {
      Triangle tri = new Triangle();
      Assert.AreEqual(false, tri.IsTriangle("2", "4", "yeet"));
    }
    [TestMethod]

    public void IsTriangle_NoSideIsGreaterThanSumOfOtherTwo_False()
    {
      Triangle tri = new Triangle();
      Assert.AreEqual(false, tri.IsTriangle("3", "3", "7"));
    }

    [TestMethod]
    public void IsTriangle_NoSideIsGreaterThanSumOfOtherTwo_True()
    {
      Triangle tri = new Triangle();
      Assert.AreEqual(true, tri.IsTriangle("3", "3", "5"));
    }
    [TestMethod]
    public void IsTriangle_AllSidesAreEqual_True()
    {
      Triangle tri = new Triangle();
      Assert.AreEqual(true, tri.IsTriangle("3", "3", "3"));
    }

    [TestMethod]

    public void IsTriangle_TwoSidesAreEqual_True()
    {
      Triangle tri = new Triangle();
      Assert.AreEqual(true, tri.IsTriangle("2", "2", "3"));
    }
  }
}