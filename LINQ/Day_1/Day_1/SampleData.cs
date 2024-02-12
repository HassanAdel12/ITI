using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace LINQtoObject
{
  static public class SampleData
  {
    static public Publisher[] Publishers =
    {
      new Publisher {Name="Hassan"},
      new Publisher {Name="Adel"},
      new Publisher {Name="I Publisher"}
    };

    static public Author[] Authors =
    {
      new Author {FirstName="Johnny", LastName="Good"},
      new Author {FirstName="Graziella", LastName="Simplegame"},
      new Author {FirstName="Octavio", LastName="Prince"},
      new Author {FirstName="Jeremy", LastName="Legrand"}
    };

    static public Subject[] Subjects =
    {
      new Subject {Name="Software development"},
      new Subject {Name="Novel"},
      new Subject {Name="Science fiction"},
      new Subject {Name="New Subject"}
    };

    static public Book[] Books =
    {
      new Book {
        Title="Funny Stories",
        Publisher=Publishers[0],
        Authors=new[]{Authors[0], Authors[1]},
        PageCount=101,
        Price=25.55M,
        PublicationDate=new DateTime(2004, 11, 10),
        Isbn="0-000-77777-2",
        Subject=Subjects[0]
      },
      new Book {
        Title="LINQ rules",
        Publisher=Publishers[1],
        Authors=new[]{Authors[2]},
        PageCount=300,
        Price=12M,
        PublicationDate=new DateTime(2007, 9, 2),
        Isbn="0-111-77777-2",
        Subject=Subjects[0]
      },
      new Book {
        Title="C# on Rails",
        Publisher=Publishers[1],
        Authors=new[]{Authors[2]},
        PageCount=256,
        Price=35.5M,
        PublicationDate=new DateTime(2007, 4, 1),
        Isbn="0-222-77777-2",
        Subject=Subjects[0]
      },
      new Book {
        Title="The Incredibles",
        Publisher=Publishers[1],
        Authors=new[]{Authors[3]},
        PageCount=1205,
        Price=35.5M,
        PublicationDate=new DateTime(2006, 5, 5),
        Isbn="0-333-77777-2",
        Subject=Subjects[2]
      },
      new Book {
        Title="Bonjour mon Amour",
        Publisher=Publishers[0],
        Authors=new[]{Authors[1], Authors[0]},
        PageCount=50,
        Price=29M,
        PublicationDate=new DateTime(1973, 2, 18),
        Isbn="2-444-77777-2",
        Subject=Subjects[1]
      }
    };

    public static ArrayList GetBooks()
    {
        return new ArrayList(Books);
    }

    public static IEnumerable<Book> FindBooksSorted(string publisher, string sortingCriteria, string sortingWay)
    {
        IEnumerable<Book> Query9;
        
        if (sortingWay == "ASC")
        {
                try
                {
                    Query9 = SampleData.Books.Where(b => b.Publisher.Name == publisher && b.GetType().GetProperty(sortingCriteria) != null)
                                .Select(b => b)
                                .OrderBy(b => b.GetType().GetProperty(sortingCriteria).GetValue(b));

                    return Query9;
                }
                catch(NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }

        }
        else if(sortingWay == "DESC")
        {
                try
                {
                    Query9 = SampleData.Books.Where(b => b.Publisher.Name == publisher && b.GetType().GetProperty(sortingCriteria) != null)
                                .Select(b => b)
                                .OrderByDescending(b => b.GetType().GetProperty(sortingCriteria).GetValue(b));

                    return Query9;
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }

        }
            
        return Query9 = new List<Book>();
    }


  }
}