using FluentAssertions;

using InterviewExercise.ClassLibrary;

namespace InterviewExercise.XUnit.Tests;

public class SingleOccurrenceNumberListShould
{
    [Fact]
    public void ThrowArgumentExceptionWhenInputArrayIsNull()
    {
        // Arrange
        var extractSingleOccurrenceOfNumberFromList = new ExtractSingleOccurrenceOfNumberFromList();

        // Act
        Action act = () => extractSingleOccurrenceOfNumberFromList.Extract(null);

        // Assert
        act.Should().Throw<ArgumentException>().WithMessage("The input array is null or empty.");
    }

    [Fact]
    public void ThrowArgumentExceptionWhenInputArrayIsEmpty()
    {
        // Arrange
        var extractSingleOccurrenceOfNumberFromList = new ExtractSingleOccurrenceOfNumberFromList();

        // Act
        Action act = () => extractSingleOccurrenceOfNumberFromList.Extract(Array.Empty<int>());

        // Assert
        act.Should().Throw<ArgumentException>().WithMessage("The input array is null or empty.");
    }

    [Fact]
    public void ReturnSingleOccurrenceNumber()
    {
        // Arrange
        var extractSingleOccurrenceOfNumberFromList = new ExtractSingleOccurrenceOfNumberFromList();

        // Act
        var result = extractSingleOccurrenceOfNumberFromList.Extract(new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4 });

        // Assert
        result.Should().BeEquivalentTo(new int[] { 5 });
    }

    [Fact]
    public void ReturnSingleOccurrenceNumbers()
    {
        // Arrange
        var extractSingleOccurrenceOfNumberFromList = new ExtractSingleOccurrenceOfNumberFromList();

        // Act
        var result = extractSingleOccurrenceOfNumberFromList.Extract(new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 });

        // Assert
        result.Should().BeEquivalentTo(new int[] { });
    }

    [Fact]
    public void ReturnSingleOccurrenceNumbersWhenInputArrayContainsNegativeNumbers()
    {
        // Arrange
        var extractSingleOccurrenceOfNumberFromList = new ExtractSingleOccurrenceOfNumberFromList();

        // Act
        var result = extractSingleOccurrenceOfNumberFromList.Extract(new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, -5 });

        // Assert
        result.Should().BeEquivalentTo(new int[] { 5, -5 });
    }

    [Fact]
    public void ReturnSingleOccurrenceNumbersWhenInputArrayContainsZero()
    {
        // Arrange
        var extractSingleOccurrenceOfNumberFromList = new ExtractSingleOccurrenceOfNumberFromList();

        // Act
        var result = extractSingleOccurrenceOfNumberFromList.Extract(new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 0 });

        // Assert
        result.Should().BeEquivalentTo(new int[] { 5, 0 });
    }

    [Fact]
    public void ReturnSingleOccurrenceNumbersWhenInputArrayContainsDuplicateNumbers()
    {
        // Arrange
        var extractSingleOccurrenceOfNumberFromList = new ExtractSingleOccurrenceOfNumberFromList();

        // Act
        var result = extractSingleOccurrenceOfNumberFromList.Extract(new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6, 6 });

        // Assert
        result.Should().BeEquivalentTo(new int[] { });
    }
}
