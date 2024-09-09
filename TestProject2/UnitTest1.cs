using DataStructuresAndAlgosCSharp;

namespace TestProject2;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void InsertionSort_SortsArrayCorrectly()
    {
        // Arrange
        int[] input = { 5, 2, 9, 1, 5, 6 };
        int[] expected = { 1, 2, 5, 5, 6, 9 };

        // Act
        InsertionSort_PN.InsertionSort(input);

        // Assert
        Assert.That(input, Is.EqualTo(expected));
    }

    [Test]
    public void InsertionSort_SortsEmptyArray()
    {
        // Arrange
        int[] input = { };
        int[] expected = { };

        // Act
        DataStructuresAndAlgosCSharp.InsertionSort_PN.InsertionSort(input);

        // Assert
        Assert.That(input, Is.EqualTo(expected));
    }

    [Test]
    public void InsertionSort_SortsSingleElementArray()
    {
        // Arrange
        int[] input = { 1 };
        int[] expected = { 1 };

        // Act
        DataStructuresAndAlgosCSharp.InsertionSort_PN.InsertionSort(input);

        // Assert
        Assert.That(input, Is.EqualTo(expected));
    }

    [Test]
    public void InsertionSort_SortsAlreadySortedArray()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        int[] expected = { 1, 2, 3, 4, 5 };

        // Act
        DataStructuresAndAlgosCSharp.InsertionSort_PN.InsertionSort(input);

        // Assert
        Assert.That(input, Is.EqualTo(expected));
    }

    [Test]
    public void InsertionSort_SortsReverseSortedArray()
    {
        // Arrange
        int[] input = { 5, 4, 3, 2, 1 };
        int[] expected = { 1, 2, 3, 4, 5 };

        // Act
        DataStructuresAndAlgosCSharp.InsertionSort_PN.InsertionSort(input);

        // Assert
        Assert.That(input, Is.EqualTo(expected));
    }
}