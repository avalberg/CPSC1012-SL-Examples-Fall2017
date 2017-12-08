using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleLibrary
{
    public class Account
    {
        private string _accountID, _firstName, _lastName;
        private decimal _fines;
        private List<Book> _booksOut;
        private DateTime _dateCreated;

        public string AccountID { get { return _accountID; } set { _accountID = value; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public decimal Fines { get { return _fines; } set { _fines = value; } }
        public List<Book> BooksOut { get { return _booksOut; } set { _booksOut = value; } }
        public DateTime DateCreated { get { return _dateCreated; } set { _dateCreated = value; } }

        public Account(string firstname, string lastname)
        {
            _accountID = firstname.Substring(0, 1) + lastname;
            _firstName = firstname;
            _lastName = lastname;
            _dateCreated = DateTime.Today;           
        }

        private void CalculateFines()
        {

        }

        public static void TakeOutBook(int bookid)
        {

        }

        public static void ReturnBook(int bookid)
        {

        }

        public static void PayFines(decimal payment)
        {

        }
    }
}
