using Library.infa;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Library.Model
{
    /*********************************************
     *  Catalog - модель каталога
     * 
     * 
     * ******************************************/
    public class Catalog : INotifyPropertyChanged
    {
        //первичный ключ
        public int Id { get; set; }

        string _title;
        string _author;
        Tematikas _tematika;
        int _year;
        public string Title 
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged("Author");
            }
        }

        public Tematikas Tematika 
        {
            get { return _tematika; }
            set
            {
                _tematika = value;
                OnPropertyChanged("Tematika");
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                _year = value;
                OnPropertyChanged("Year");
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
