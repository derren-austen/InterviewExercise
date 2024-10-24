namespace InterviewExercise.ClassLibrary;

public class DateList
{
    public static bool AnyOverlappingDates(IEnumerable<DateRange> dateRanges)
    {
        // Check to see if any of the date ranges overlap
        return dateRanges
            .Any(dateRange => dateRanges
                .Any(otherDateRange => dateRange != otherDateRange && DateRangesOverlap(dateRange, otherDateRange)));
    }

    private static bool DateRangesOverlap(DateRange range1, DateRange range2) =>
        // Check if two date ranges overlap
        range1.StartDate < range2.EndDate && range1.EndDate > range2.StartDate;
}

public record DateRange(DateTime StartDate, DateTime EndDate);
