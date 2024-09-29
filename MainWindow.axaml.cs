using Avalonia.Controls;
using Avalonia.Media.Imaging;
using AvaloniaApplication6.Models;
using System.Collections.Generic;

using System.Linq;
using System.Security.Cryptography;

namespace AvaloniaApplication6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Listins(SavingDate.products);
            Filtr1.SelectedIndex = 0;
          
            Listinss(SavingDate.manufactrur);
            Filtr2.SelectedIndex = 0;
        }

        private void Listins(List<Product> list)
        {

            lbox_books.ItemsSource = list.Select(x => new
            {
                x.Name,
                x.Price,
                photos = new Bitmap($"Assets/{x.Photo}"),
                x.Manufactured,
                Color=x.Isactive==1 ? "White" : "Gray"

            });
           ColvoKont.Text = $"Выведено записей {SavingDate.products.Count} из {SavingDate.products.Count}";
        }
        private void Listinss(List<Manuf> list)
        {

            Filtr2.ItemsSource = list.Select(x => new
            {
                x.Name,

            });
            
        }

        private void ComboBox_SizeChanged(object? sender, Avalonia.Controls.SizeChangedEventArgs e)
        {
            Filtrs();
        }

        private void ComboBox_SizeChanged_1(object? sender, Avalonia.Controls.SizeChangedEventArgs e)
        {
            Filtrs();
        }
        
        private void Filtrs()
        {
            List<Product> filtr = SavingDate.products;
            int d = Filtr1.SelectedIndex;
            switch (d)
            {
                case 0: Listins(SavingDate.products); break;
                case 1:
                    {
                        for (int i = 0; i < filtr.Count; i++)
                            for (int j = 0; j < filtr.Count - i - 1; j++)
                            {
                                if (filtr[j].Price < filtr[j + 1].Price)
                                {
                                    Product temp = filtr[j];
                                    filtr[j] = filtr[j + 1];
                                    filtr[j + 1] = temp;
                                }
                            }
                        Listins(filtr);
                    }
                    break;
                case 2:
                    {
                        for (int i = 0; i < filtr.Count; i++)
                            for (int j = 0; j < filtr.Count - i - 1; j++)
                            {
                                if (filtr[j].Price > filtr[j + 1].Price)
                                {
                                    Product temp = filtr[j];
                                    filtr[j] = filtr[j + 1];
                                    filtr[j + 1] = temp;
                                }
                            }
                        Listins(filtr);
                    }
                    break;
            }
            int v = Filtr2.SelectedIndex;
            if (v == 0)
            {
                Listins(SavingDate.products);
            }
            else
            {
                Listins(filtr.Where(x => x.Id == v).ToList());
            }
        }
        private void StackPanel_DoubleTapped(object? sender, Avalonia.Input.TappedEventArgs e)
        {
           // _SearchbarContent = tbox_searchbar.Text;
           // _FiltrationItemIndex = cbox_filtration.SelectedIndex;
           // _SortingItemIndex = cbox_sorting.SelectedIndex;
            var product = lbox_books.SelectedItem as Product;
           // Product product1 = lbox_books.SelectedIndex as Product;
           // SavingDate.tag = product1;
            new RedWindow1().Show();
            Close();
        }
    }
}