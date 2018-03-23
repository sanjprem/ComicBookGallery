using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public class SeriesRepository
    {
        public Series[] GetSeries()
        {
            return Data.Series;
        }

        public Series GetSeriesDetail(int id)
        {
            Series seriesToReturn = null;

            foreach (var series in Data.Series)
            {
                if (series.Id == id)
                {
                    seriesToReturn = series;
                    break;
                }
            }

            if (seriesToReturn != null)
            {
                var comicBooks = new ComicBook[0];

                foreach (var comicBook in Data.ComicBooks)
                {
                    if (comicBook.Series != null && comicBook.Series.Id == id)
                    {
                        Array.Resize(ref comicBooks, comicBooks.Length + 1);
                        comicBooks[comicBooks.Length - 1] = comicBook;
                    }
                }

                seriesToReturn.Issues = comicBooks;
            }

            return seriesToReturn;
        }
    }
}