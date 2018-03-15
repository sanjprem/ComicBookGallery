using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        public ComicBook[] GetComicBooks()
        {
            return Data.ComicBooks;
        }

        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;
            foreach (var comicBook in Data.ComicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }
            return comicBookToReturn;
        }
    }
}