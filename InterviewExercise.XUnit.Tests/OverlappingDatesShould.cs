using FluentAssertions;

using InterviewExercise.ClassLibrary;

namespace InterviewExercise.XUnit.Tests;

public class OverlappingDatesShould
{
    [Fact]
    public void Non_overlapping_dates_should_return_false()
    {
        // Arrange
        var dateList = new DateList();

        // Act
        var result = DateList.AnyOverlappingDates(
        [
            new DateRange(new DateTime(2021, 1, 1), new DateTime(2021, 1, 10)),
            new DateRange(new DateTime(2021, 1, 11), new DateTime(2021, 1, 20))
        ]);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void Overlapping_dates_should_return_true()
    {
        // Arrange
        var dateList = new DateList();

        // Act
        var result = DateList.AnyOverlappingDates(
        [
            new DateRange(new DateTime(2021, 1, 1), new DateTime(2021, 1, 10)),
            new DateRange(new DateTime(2021, 1, 5), new DateTime(2021, 1, 20))
        ]);

        // Assert
        result.Should().BeTrue();
    }
}