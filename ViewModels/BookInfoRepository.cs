using CommunityToolkit.Mvvm.ComponentModel;

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SfListViewGroupingMemoryLeak.ViewModels;

public class BookInfoRepository : INotifyPropertyChanged
{
    private ObservableCollection<BookInfo> _bookInfoCollection;
    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<BookInfo> BookInfoCollection
    {
        get { return _bookInfoCollection; }
        set
        {
            this._bookInfoCollection = value;
            this.OnPropertyChanged("BookInfoCollection");
        }
    }

    public void OnPropertyChanged(string name)
    {
        if (this.PropertyChanged != null)
            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
    }

    public BookInfoRepository()
    {
        GenerateNewBookInfo();
    }

    private async void GenerateNewBookInfo()
    {
        BookInfoCollection = new ObservableCollection<BookInfo>()
           {
            new BookInfo
            {
                Category = "Fiction",
                CategoryColor = Colors.LightCoral,
                BookName = "To Kill a Mockingbird",
                BookDescription = "A Pulitzer Prize-winning novel by Harper Lee.",
                SubBookInfoCollection = new ObservableCollection<SubBookInfo>()
                {
                    new SubBookInfo
                    {
                        Category = "Fiction",
                        CategoryColor = Colors.LightCoral,
                        BookName = "To Kill a Mockingbird",
                        BookDescription = "A Pulitzer Prize-winning novel by Harper Lee."
                    },
                    new SubBookInfo
                    {
                        Category = "Non-Fiction",
                        CategoryColor = Colors.LightSkyBlue,
                        BookName = "Sapiens: A Brief History of Humankind",
                        BookDescription = "An exploration of the history of Homo sapiens by Yuval Noah Harari."
                    },
                    new SubBookInfo
                    {
                        Category = "Science Fiction",
                        CategoryColor = Colors.LightGreen,
                        BookName = "Dune",
                        BookDescription = "A science fiction novel by Frank Herbert, set in the distant future amidst a feudal interstellar society."
                    },
                    new SubBookInfo
                    {
                        Category = "Fantasy",
                        CategoryColor = Colors.LightPink,
                        BookName = "The Hobbit",
                        BookDescription = "A fantasy novel by J.R.R. Tolkien, introducing the world of Middle-earth."
                    }
                }

            },
            new BookInfo
            {
                Category = "Non-Fiction",
                CategoryColor = Colors.LightSkyBlue,
                BookName = "Sapiens: A Brief History of Humankind",
                BookDescription = "An exploration of the history of Homo sapiens by Yuval Noah Harari.",
                SubBookInfoCollection = new ObservableCollection<SubBookInfo>()
                {
                    new SubBookInfo
                    {
                        Category = "Fiction",
                        CategoryColor = Colors.LightCoral,
                        BookName = "To Kill a Mockingbird",
                        BookDescription = "A Pulitzer Prize-winning novel by Harper Lee."
                    },
                    new SubBookInfo
                    {
                        Category = "Non-Fiction",
                        CategoryColor = Colors.LightSkyBlue,
                        BookName = "Sapiens: A Brief History of Humankind",
                        BookDescription = "An exploration of the history of Homo sapiens by Yuval Noah Harari."
                    },
                    new SubBookInfo
                    {
                        Category = "Science Fiction",
                        CategoryColor = Colors.LightGreen,
                        BookName = "Dune",
                        BookDescription = "A science fiction novel by Frank Herbert, set in the distant future amidst a feudal interstellar society."
                    },
                    new SubBookInfo
                    {
                        Category = "Fantasy",
                        CategoryColor = Colors.LightPink,
                        BookName = "The Hobbit",
                        BookDescription = "A fantasy novel by J.R.R. Tolkien, introducing the world of Middle-earth."
                    }
                }

            },
            new BookInfo
            {
                Category = "Science Fiction",
                CategoryColor = Colors.LightGreen,
                BookName = "Dune",
                BookDescription = "A science fiction novel by Frank Herbert, set in the distant future amidst a feudal interstellar society.",
                SubBookInfoCollection = new ObservableCollection<SubBookInfo>()
                {
                    new SubBookInfo
                    {
                        Category = "Fiction",
                        CategoryColor = Colors.LightCoral,
                        BookName = "To Kill a Mockingbird",
                        BookDescription = "A Pulitzer Prize-winning novel by Harper Lee."
                    },
                    new SubBookInfo
                    {
                        Category = "Non-Fiction",
                        CategoryColor = Colors.LightSkyBlue,
                        BookName = "Sapiens: A Brief History of Humankind",
                        BookDescription = "An exploration of the history of Homo sapiens by Yuval Noah Harari."
                    },
                    new SubBookInfo
                    {
                        Category = "Science Fiction",
                        CategoryColor = Colors.LightGreen,
                        BookName = "Dune",
                        BookDescription = "A science fiction novel by Frank Herbert, set in the distant future amidst a feudal interstellar society."
                    },
                    new SubBookInfo
                    {
                        Category = "Fantasy",
                        CategoryColor = Colors.LightPink,
                        BookName = "The Hobbit",
                        BookDescription = "A fantasy novel by J.R.R. Tolkien, introducing the world of Middle-earth."
                    }
                }
            },
            //new BookInfo
            //{
            //    Category = "Fantasy",
            //    CategoryColor = Colors.LightPink,
            //    BookName = "The Hobbit",
            //    BookDescription = "A fantasy novel by J.R.R. Tolkien, introducing the world of Middle-earth."
            //},
            //new BookInfo
            //{
            //    Category = "Mystery",
            //    CategoryColor = Colors.LightGray,
            //    BookName = "The Da Vinci Code",
            //    BookDescription = "A mystery-detective novel by Dan Brown, exploring religious themes and art history."
            //},
            //new BookInfo
            //{
            //    Category = "Biography",
            //    CategoryColor = Colors.LightSalmon,
            //    BookName = "Steve Jobs",
            //    BookDescription = "A biography of Steve Jobs, co-founder of Apple Inc., written by Walter Isaacson."
            //},
            //new BookInfo
            //{
            //    Category = "History",
            //    CategoryColor = Colors.LightGoldenrodYellow,
            //    BookName = "Guns, Germs, and Steel",
            //    BookDescription = "A Pulitzer Prize-winning book by Jared Diamond, exploring the role of geography and environment in shaping human history."
            //},
            //// Add more books here
            //new BookInfo
            //{
            //    Category = "Fiction",
            //    CategoryColor = Colors.LightCoral,
            //    BookName = "1984",
            //    BookDescription = "A dystopian novel by George Orwell, depicting a totalitarian regime and surveillance society."
            //},
            //new BookInfo
            //{
            //    Category = "Non-Fiction",
            //    CategoryColor = Colors.LightSkyBlue,
            //    BookName = "The Power of Habit",
            //    BookDescription = "A book by Charles Duhigg, exploring the science behind habits and how they can be changed."
            //},
            //new BookInfo
            //{
            //    Category = "Science Fiction",
            //    CategoryColor = Colors.LightGreen,
            //    BookName = "Foundation",
            //    BookDescription = "A science fiction novel by Isaac Asimov, exploring the future of a galactic empire."
            //},
            //new BookInfo
            //{
            //    Category = "Fantasy",
            //    CategoryColor = Colors.LightPink,
            //    BookName = "Harry Potter and the Philosopher's Stone",
            //    BookDescription = "The first book in the Harry Potter series by J.K. Rowling, following the adventures of a young wizard."
            //},
            //new BookInfo
            //{
            //    Category = "Mystery",
            //    CategoryColor = Colors.LightGray,
            //    BookName = "The Girl with the Dragon Tattoo",
            //    BookDescription = "A crime novel by Stieg Larsson, featuring the investigative journalist Mikael Blomkvist and the hacker Lisbeth Salander."
            //},
            //new BookInfo
            //{
            //    Category = "Biography",
            //    CategoryColor = Colors.LightSalmon,
            //    BookName = "Becoming",
            //    BookDescription = "A memoir by Michelle Obama, former First Lady of the United States, recounting her life and experiences."
            //},
            //new BookInfo
            //{
            //    Category = "History",
            //    CategoryColor = Colors.LightGoldenrodYellow,
            //    BookName = "A People's History of the United States",
            //    BookDescription = "A book by Howard Zinn, presenting American history from the perspective of marginalized groups."
            //},
            //new BookInfo
            //{
            //    Category = "Fiction",
            //    CategoryColor = Colors.LightCoral,
            //    BookName = "The Catcher in the Rye",
            //    BookDescription = "A novel by J.D. Salinger, narrated by a young protagonist struggling with alienation and identity."
            //},
            //new BookInfo
            //{
            //    Category = "Non-Fiction",
            //    CategoryColor = Colors.LightSkyBlue,
            //    BookName = "Thinking, Fast and Slow",
            //    BookDescription = "A book by Daniel Kahneman, exploring the two systems of thought that drive human decision-making."
            //},
            //new BookInfo
            //{
            //    Category = "Science Fiction",
            //    CategoryColor = Colors.LightGreen,
            //    BookName = "Neuromancer",
            //    BookDescription = "A cyberpunk novel by William Gibson, pioneering the genre of cyberspace and virtual reality."
            //},
            //new BookInfo
            //{
            //    Category = "Fantasy",
            //    CategoryColor = Colors.LightPink,
            //    BookName = "The Name of the Wind",
            //    BookDescription = "The first book in the Kingkiller Chronicle series by Patrick Rothfuss, following the life of the legendary figure Kvothe."
            //},
            //new BookInfo
            //{
            //    Category = "Mystery",
            //    CategoryColor = Colors.LightGray,
            //    BookName = "Gone Girl",
            //    BookDescription = "A psychological thriller novel by Gillian Flynn, exploring the complexities of marriage and deception."
            //},
            //new BookInfo
            //{
            //    Category = "Biography",
            //    CategoryColor = Colors.LightSalmon,
            //    BookName = "Elon Musk: Tesla, SpaceX, and the Quest for a Fantastic Future",
            //    BookDescription = "A biography of Elon Musk, entrepreneur and CEO, written by Ashlee Vance."
            //},
            //new BookInfo
            //{
            //    Category = "History",
            //    CategoryColor = Colors.LightGoldenrodYellow,
            //    BookName = "The Guns of August",
            //    BookDescription = "A Pulitzer Prize-winning book by Barbara W. Tuchman, analyzing the causes and early stages of World War I."
            //}
        };
    }


}


public partial class SubBookInfo
{
    public Color CategoryColor { get; set; }
    public string? Category { get; set; }
    public string? BookName { get; set; }
    public string? BookDescription { get; set; }



}


public partial class BookInfo : ObservableObject
{
    public Color CategoryColor { get; set; }
    public string? Category { get; set; }
    public string? BookName { get; set; }
    public string? BookDescription { get; set; }

    [ObservableProperty] private bool _isExpanded;

    public ObservableCollection<SubBookInfo> SubBookInfoCollection { get; set; } = new ObservableCollection<SubBookInfo>();

}