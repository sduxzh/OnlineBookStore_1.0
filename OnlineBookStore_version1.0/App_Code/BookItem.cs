﻿namespace OnlineBookStore.App_Code
{
    public class BookItem
    {
        private Book book;
        private decimal totalprice;//某一类书的总价格
        private int bookamount;//某一类书的总数量

        public int bookAmount
        {
            get { return bookamount; }
        }

        public Book Book
        {
            get { return book;}
        }

        public BookItem(Book abook)
        {
            this.book = abook;
            bookamount++;
        }

        public BookItem(Book abook, int bookAmount)
        {
            this.book = abook;
            bookamount = bookAmount;
        }

        /// <summary>
        /// 增加某一类书的数量
        /// </summary>
        /// <param name="book"></param>
        public void AddBookToItem()
        {
                bookamount++;
        }

        /// <summary>
        /// 减少某一本书的数量
        /// </summary>
        /// <param name="book"></param>
        public void DeleteBookFromItem()
        {
            if (bookamount > 1)
            {
                bookamount--;
            }
           
        }

        /// <summary>
        /// 计算某一类书的总价格
        /// </summary>
        /// <returns></returns>
        public decimal ComputeBookItemCost()
        {
            totalprice = bookamount*book.bookPrice;
            return totalprice;
        }
    }
}