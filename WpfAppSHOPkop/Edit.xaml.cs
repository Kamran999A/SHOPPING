using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.IO;
using Microsoft.Win32;
using WpfAppSHOPkop.Extensions;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace WpfAppSHOPkop
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Window/*, INotifyPropertyChanged*/
    {
        //private MainWindow mm = new MainWindow();

        public Product Produ
        {
            get { return (Product)GetValue(ProduProperty); }
            set { SetValue(ProduProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Produ.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProduProperty =
            DependencyProperty.Register("Produ", typeof(Product), typeof(Edit));
        public Edit()
        {
            this.DataContext = this;
            InitializeComponent();
        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;    
            this.Visibility = Visibility.Hidden;
        }
        private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        //private void Window_Closed(object sender, EventArgs e)
        //{
        //    e.Cancel = true;
        //    this.Visibility = Visibility.Hidden;
        //}


        //protected void OnPropertyChanged([CallerMemberName] string name = null)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (handler != null)
        //    {
        //        handler(this, new PropertyChangedEventArgs(name));
        //    }
        //}
        //private Car infoCar;

        //public Car InfoCar
        //{
        //    get { return infoCar; }
        //    set { infoCar = value; OnPropertyChanged(); }
        //}



        //private void UIElement_OnMouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    var open = new OpenFileDialog();

        //    open.Multiselect = false;
        //    open.Filter = "Image file (*.png)|*.png";

        //    if (open.ShowDialog() != true)
        //        return;

        //    var image = new BitmapImage(new Uri(open.FileName));

        //    var fileName = $@"Images/{Guid.NewGuid()}.png";

        //    if (!Directory.Exists("Images"))
        //        Directory.CreateDirectory("Images");

        //    image.Save(fileName);

        //    var fullFileName = Directory.GetCurrentDirectory() + "\\" + fileName;

        //    ImageProduct.Source = new BitmapImage(new Uri(fullFileName));
        //}
        //private void ButtonUpdate_OnClick(object sender, RoutedEventArgs e)
        //{   

        //    if (_selectedProduct == null)
        //        return;

        //    if (ImageProduct.Source != null)
        //        _selectedProduct.ImagePath = ImageProduct.Source.ToString();

        //    _selectedProduct.Name = TextBoxProductName.Text;
        //    _selectedProduct.Price = Convert.ToDouble(TextBoxProductPrice.Text);
        //    _selectedProduct.Quantity = Convert.ToInt32(TextBoxProductQuantity.Text);

        //    RefreshListBox(Products);
        //}
        //private void RefreshListBox(List<Product> products)
        //{

        //    //ListBoxProducts.ItemsSource = null;
        //    //ListBoxProducts.ItemsSource = products;
        //}
        //private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
        //{
        //    if (_selectedProduct == null)
        //        return;

        //   prod.Remove(_selectedProduct);
        //    Products.Remove(_selectedProduct);

        //    RefreshListBox(Products);
        //}

        string m = "";
        private void ProductImage_Drop(object sender, DragEventArgs e)
        {
            if (!Directory.Exists("Add ProductImage"))
            {
                Directory.CreateDirectory("Add ProductImage");
            }



            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var file in files)
            {
                m = file;

                PathTextbox.Visibility = Visibility.Visible;

                PathTextbox.Text = m;
            }

            try
            {

                string dircopyfrom = m;

                string[] fileEnter1 = Directory.GetFiles(dircopyfrom);

                string dircopyto = $@"Add ProductImage";

                foreach (var f in fileEnter1)
                {
                    string filename = System.IO.Path.GetFileName(f);
                    File.Copy(f, dircopyto + "\\" + filename, true);
                    File.Delete(f);
                }
            }

            catch (Exception)
            {


            }

            File.Copy(m, $@"Add ProductImage/image.png", true);
        }

        private void ProductImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effects = DragDropEffects.All;
            }
        }

        private void EditProductImage_Drop(object sender, DragEventArgs e)
        {
            if (!Directory.Exists("Add ProductImage"))
            {
                Directory.CreateDirectory("Add ProductImage");
            }



            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var file in files)
            {
                m = file;

                PathTextbox.Visibility = Visibility.Visible;

                PathTextbox.Text = m;
            }

            try
            {

                string dircopyfrom = m;

                string[] fileEnter1 = Directory.GetFiles(dircopyfrom);

                string dircopyto = $@"Add ProductImage";

                foreach (var f in fileEnter1)
                {
                    string filename = System.IO.Path.GetFileName(f);
                    File.Copy(f, dircopyto + "\\" + filename, true);
                    File.Delete(f);
                }

            }

            catch (Exception)
            {


            }

            File.Copy(m, $@"Add ProductImage/image.png", true);
            EditProductImage.Source = new BitmapImage(new Uri(m));
        }

        private void EditProductImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effects = DragDropEffects.All;
            }
        }



        private void StackDragDrop_Drop(object sender, DragEventArgs e)
        {
            if (!Directory.Exists("Add ProductImage"))
            {
                Directory.CreateDirectory("Add ProductImage");
            }



            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var file in files)
            {
                m = file;

                PathTextbox.Visibility = Visibility.Visible;

                PathTextbox.Text = m;
            }

            try
            {

                string dircopyfrom = m;

                string[] fileEnter1 = Directory.GetFiles(dircopyfrom);

                string dircopyto = $@"Add ProductImage";

                foreach (var f in fileEnter1)
                {
                    string filename = System.IO.Path.GetFileName(f);
                    File.Copy(f, dircopyto + "\\" + filename, true);
                    File.Delete(f);
                }

            }

            catch (Exception)
            {


            }

            File.Copy(m, $@"Add ProductImage/image.png", true);
           // ProductImage.Source = new BitmapImage(new Uri(m));
        }

        private void StackDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effects = DragDropEffects.All;
            }
        }

    

      

    }
}
