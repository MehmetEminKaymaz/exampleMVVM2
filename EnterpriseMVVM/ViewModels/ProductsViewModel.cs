using EnterpriseMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;

namespace EnterpriseMVVM.ViewModels
{
    internal class ProductsViewModel : ViewModel
    {
        ObservableCollection<Product> products;
        public ProductsViewModel()
        {
            //stimulate a db query or api usage
            this.products = new ObservableCollection<Product>();
            products.Add(new Product() { Name = "Tuna Fish", Content = "Omega-3", Price = 80 });
            products.Add(new Product() { Name = "SailFish", Content = "Omega-3", Price = 140 });
            products.Add(new Product() { Name = "Blue Marlin", Content = "Omega-3", Price = 280 });
            products.Add(new Product() { Name = "Barracuda", Content = "Omega-3", Price = 169 });
            //
        }

        public Product SelectedItem { get; set; }

        public ObservableCollection<Product> Products
        {
            get
            {
                return products;
            }
        }

        
        public ActionCommand DeleteCommand
        {
            get
            {
                return new ActionCommand(x=>Delete(),y=>products.Contains(SelectedItem));
            }
        }

        private void Delete()
        {
            products.Remove(SelectedItem);
        }

        public ActionCommand DeleteAllCommand
        {
            get
            {
                return new ActionCommand(x=>DeleteAll(),y=> products.Count>0 );
            }
        }

        private void DeleteAll()
        {
            products.Clear();
        }


        public ActionCommand AddCommand
        {
            get
            {
                return new ActionCommand(x=>Add(),y=>addState());
            }
        }

        private bool addState()
        {
            
            if (string.IsNullOrEmpty(this.Error))
            {
                var p = new Product()
                {
                    Name = txtname,
                    Content = txtcontent,
                    Price = txtprice,
                };

                if (!this.products.Any(x => x.Name == txtname && x.Price == txtprice && x.Content == txtcontent))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        private void Add()
        {
            products.Add(new Product()
            {
                Name = txtname,
                Content = txtcontent,
                Price = txtprice,
            });
        }

        public ActionCommand UpdateCommand
        {
            get
            {
                return new ActionCommand(x=>Update(),y=>updateState());
            }
        }

        private bool updateState()
        {
            if (String.IsNullOrEmpty(this.Error))
            {
                if (SelectedItem != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }

        

        private void Update()
        {
            var obj = products.FirstOrDefault(x => x.Name == SelectedItem.Name && x.Price == SelectedItem.Price && x.Content == SelectedItem.Content);
            if ( obj != null)
            {
                var oldIndex = products.IndexOf(obj);
                products.RemoveAt(oldIndex);
                products.Insert(oldIndex, new Product() {
                    Price=txtprice,
                    Content=txtcontent,
                    Name=txtname
                });
              
            }
          

        }


       



        #region TxtName
        private string txtname;

        [Required]
        [MaxLength(30)]
        public string Txtname
        {
            get
            {
                return txtname;
            }
            set
            {
                if (txtname == value)
                {
                    return;
                }
                txtname = value;
                NotifyPropertyChanged();
            }
        }
        #endregion


        #region TxtContent
        private string txtcontent;

        [Required(ErrorMessage ="You must enter a valid content value!")]
        [MaxLength(100,ErrorMessage ="Maxlenght is 100")]
        public string Txtcontent
        {
            get
            {
                return txtcontent;
            }
            set
            {
                if (txtcontent == value)
                {
                    return;
                }
                txtcontent = value;
                NotifyPropertyChanged();
            }
        }

        #endregion


        #region TxtPrice

        private decimal txtprice;
        [Required(ErrorMessage ="You must enter a valid price value!")]
        public string Txtprice
        {
            get
            {
                return txtprice.ToString("C2");
            }
            set
            {
                decimal cache;
                if (decimal.TryParse(value, System.Globalization.NumberStyles.Currency, null, out cache))
                {
                    if (cache == txtprice)
                    {
                        return;
                    }
                   
                    txtprice = cache;
                    NotifyPropertyChanged();
                }
                else
                {
                    return;
                }



            }
        }
        #endregion








    }
}
