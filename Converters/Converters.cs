using SfListViewGroupingMemoryLeak.ViewModels;

using System.Globalization;

namespace SfListViewGroupingMemoryLeak.Converters;

public class GetGroupColor : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {

        // Does not always work on iOS... 

        if (value is IEnumerable<BookInfo> myTimerDisplayList) //GroupResult.Items
        {
            return myTimerDisplayList.First().CategoryColor;
        }

        return Colors.Gainsboro;

    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return 0;
    }
}

public class GetBookName : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {

        // Does not always work on iOS... 

        if (value is BookInfo bookInfo) //GroupResult.Items
        {
            if (bookInfo.BookName != null) return bookInfo.BookName;
        }

        return "";

    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return 0;
    }
}