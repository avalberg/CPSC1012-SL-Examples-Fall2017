using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleLibrary
{
    public class Book
    {
        private int _bookID, _timesCheckedOut;
        private string _title, _genre;
        private bool _checkedOut;
        private DateTime _dateCheckedOut;
        private decimal _finePerDay;

        public int BookID { get { return _bookID; } set { _bookID = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Genre { get { return _genre; } set { _genre = value; } }
        public bool CheckedOut { get { return _checkedOut; } set { _checkedOut = value; } }
        public DateTime DateCheckedOut { get { return _dateCheckedOut; } set { _dateCheckedOut = value; } }
        public decimal FinePerDay { get { return _finePerDay; } set { _finePerDay = value; } }
        public int TimesCheckedOut { get { return _timesCheckedOut; } set { _timesCheckedOut = value; } }

        public Book(int bookid,string title,string genre,bool checkedout,DateTime datecheckedout,decimal fineperday,int timescheckedout)
        {
            _bookID = bookid;
            _title = title;
            _genre = genre;
            _checkedOut = checkedout;
            _dateCheckedOut = datecheckedout;
            _finePerDay = fineperday;
            _timesCheckedOut = timescheckedout;
        }
    }
}
