using Library.Model;
using Library.View;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace Library.ViewModel
{
    class ApplicationViewModel
    {
        ApplicationContext db = new ApplicationContext();
        
        RelayCommand? addCommand;
        RelayCommand? editCommand;
        RelayCommand? deleteCommand;

        public ObservableCollection<Catalog> Catalogs { get; set; }

        public ApplicationViewModel()
        {
            db.Database.EnsureCreated();
            db.Catalogs.Load();
            Catalogs = db.Catalogs.Local.ToObservableCollection();
        }

        // команда добавления
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand((o) =>
                  {
                      CataloEdit userWindow = new CataloEdit(new Catalog());
                      if (userWindow.ShowDialog() == true)
                      {
                          Catalog user = userWindow.Catalogs;
                          db.Catalogs.Add(user);
                          db.SaveChanges();
                      }
                  }));
            }
        }

    }
}
