using System;

namespace Class6
{
    public class PhotoAlbum
    {
        public PhotoAlbum()
        {
            numberOfPages = 16;
        }
        public PhotoAlbum(int pages)
        {
            numberOfPages = pages;
        }

        private int numberOfPages;
        public int GetnumberOfPages()
        {
            return numberOfPages;
        }
    }

    public class BigPhotoAlbum
    {
        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }
        public int numberOfPages;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //In main method create a "PhotoAlbum" instance with its default constructor
            var album16 = new PhotoAlbum();
            //In main method create a "PhotoAlbum" instance and one with 24 pages
            var album24 = new PhotoAlbum(24);
            //create "BigPhotoAlbum" and show the number of pages that the three albums have
            var album64 = new BigPhotoAlbum();
            Console.WriteLine($"Total number of pages is: {album16.GetnumberOfPages() + album24.GetnumberOfPages() + album64.numberOfPages}");

            Console.ReadLine();
        }
    }
}
