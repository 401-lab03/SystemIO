using System;
using Xunit;
using Lab03SytemIO;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ListExistsTest1()
        {
            //string items = "bananas";
            //string blah = (method name)File.AppendAllLines("../../../list.txt", items)
            //Assert.IsTrue(list.txt.Includes(items));

            string[] items = new string[] { "bananas" };
            string[] listShows = Program.CreateAFile(items);
            Assert.Equal(items, listShows);
            
        }

        //[Fact]
        //public void ItemIsRemovedTest1()
        //{
        //    string[] items = new string[] { "water", "toilet paper", "bananas" };
        //    string[] reducedItem = Program.methodname();
        //    Assert.Equals(Array.length - 1, items);

        //}

        //[Fact]
        //public void ItemisAddedTest1()
        //{
        //    string[] items = new string[] { "water", "toilet paper", "bananas" };
        //    string[] reducedItem = Program.methodname();
        //    Assert.Equals(Array.length + 1, items);
        //}

        //[Fact]
        //public void ListIsCreatedTest1()
        //{
        //    string[] items = new string [];
        //    File.WriteAllLines(path, items);
        //    Assert.equals(../path, items)
        //}


        //[TestMethod()]
        //public void WriteMovieListToFileTest1()
        //{
        //    Movie movie1 = new Movie("Title", "Genre", "Actor", "Year");
        //    movieSystem.AddMovie(movie1);
        //    movieSystem.WriteMovieListToFile("MovieListTEST.txt");
        //    var fileText = File.ReadLines("MovieListTEST.txt");
        //    Assert.IsTrue(fileText.ToString().Length > 1);
        //}



    }
}
