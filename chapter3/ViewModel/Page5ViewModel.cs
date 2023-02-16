using chapter3.Model;
using CommunityToolkit.Maui.Alerts;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace chapter3.ViewModel.MyCart
{
    public class Page5ViewModel : INotifyPropertyChanged
    {
        private readonly Page5Model _page5Model;
       
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private double _subTotal;
        public double SubTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                OnPropertyChanged();
            }
        }
        public ICommand CalculateCommand { get; private set; }



        public double ModeloPrize
        {
            get;
            set;
        }           
        public bool ModeloCheck { get; set;}
        public ICommand ModeloMinusCommand { get; private set;}
        public ICommand ModeloPlusCommand { get; private set;}
  
        private int _modeloValue=1;
        public int ModeloValue
        {
            get => _modeloValue;
            set
            {
                _modeloValue = value;
                OnPropertyChanged();
            }
        }

        public void ModeloIncrement()
        {
            _modeloValue++;
            ModeloValue = _modeloValue;
        }
        public void ModeloDecrement()
        {
            if (_modeloValue <= 1)
            {
                Toast.Make("Can't Less than that", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                _modeloValue--;
                ModeloValue = _modeloValue;
            }
            
        }
        public double ModeloTotal { get; set;}
        public void ModeloCalculate()
        {
            if (ModeloCheck == true)
            {
                ModeloTotal = ModeloPrize * ModeloValue;
            }
            else
            {
                ModeloTotal = 0;
            }
        }





        public double SurelyPrize
        {
            get;
            set;
        }
        public bool SurelyCheck { get; set; }
        public ICommand SurelyMinusCommand { get; private set; }
        public ICommand SurelyPlusCommand { get; private set; }
        
        private int _surelyValue=1;
        public int SurelyValue
        {
            get => _surelyValue;
            set
            {
                _surelyValue = value;
                OnPropertyChanged();
            }
        }

        public void SurelyIncrement()
        {
            _surelyValue++;
            SurelyValue = _surelyValue;
        }
        public void SurelyDecrement()
        {
            if (_surelyValue <= 1)
            {
                Toast.Make("Can't Less than that", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                _surelyValue--;
                SurelyValue = _surelyValue;
            }

        }

        public double SurelyTotal { get; set; }
        public void SurelyCalculate()
        {
            if (SurelyCheck == true)
            {
                SurelyTotal = SurelyPrize * SurelyValue;
            }
            else
            {
                SurelyTotal = 0;
            }
        }






        public double BaiPrize
        {
            get;
            set;
        }
        public bool BaiCheck { get; set; }
        public ICommand BaiMinusCommand { get; private set; }
        public ICommand BaiPlusCommand { get; private set; }
        
        private int _baiValue=1;
        public int BaiValue
        {
            get => _baiValue;
            set
            {
                _baiValue = value;
                OnPropertyChanged();
            }
        }
       
        public void BaiIncrement()
        {
            _baiValue++;
            BaiValue = _baiValue;
        }
        public void BaiDecrement()
        {
            if (_baiValue <= 1)
            {
                Toast.Make("Can't Less than that", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                _baiValue--;
                BaiValue = _baiValue;
            }

        }

        public double BaiTotal { get; set; }
       
        public void BaiCalculate()
        {
            if (BaiCheck == true)
            {
                BaiTotal = BaiPrize * BaiValue;
            }
            else
            {
                BaiTotal = 0;
            }
        }




        private string _promoCode;
        public string PromoCode 
        {
            get => _promoCode;
            set
            {
                _promoCode = value;
                OnPropertyChanged();
            }
        }

        public string Promo = "1Rivet";
        public double _discount = 0;
        public ICommand ApplyCommand { get; private set; }
       
        private bool _visible;
        public bool Visible
        { 
            get => _visible;
            set
            {
                _visible= value;
                OnPropertyChanged();
            } 
       }
            
        public double Shipping
        {
            get;
            set;   
        }

       
        public void SubTotals()
        {
            SubTotal =Math.Round((ModeloTotal+SurelyTotal+BaiTotal),2);
        }

        public int C = 0;
        public void Discount()
        {
            C++;
            if (ModeloCheck == false && SurelyCheck == false && BaiCheck == false)
            {
                Toast.Make("Please select Item",CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
                C--;
            }
            else if (string.IsNullOrEmpty(PromoCode))
            {
               
                Toast.Make("Please Enter Promo Code",CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
                C--;
            }
            else if (!string.Equals(PromoCode, Promo))
            {
                Toast.Make("Please Enter Correct Promo Code", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
                C--;
            }
            else if (string.Equals(PromoCode, Promo) && C == 0)
            {
                Toast.Make("Alredy Apply", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (string.Equals(PromoCode, Promo) && C==1)
            {
                _discount= SubTotal - ((SubTotal * 10) / 100);
                 SubTotal=Math.Round(_discount,2);
                C--;
               
            }
            
            else
            {
                SubTotal = SubTotal - _discount;
                

            }

        }

        private int _item;
        public int Item
        {
            get=> _item;
            set
            {
                _item= value;
                OnPropertyChanged();
            }
        }

        public void ItemTotal()
        {
            if(ModeloCheck==true && SurelyCheck==true && BaiCheck == true)
            {
                Item = 3;
            }
            else if(ModeloCheck == true && SurelyCheck == true)
            {
                Item = 2;
            }
            else if(ModeloCheck == true && BaiCheck == true)
            {
                Item = 2;
            }
            else if(BaiCheck == true && SurelyCheck == true)
            {
                Item = 2;
            }else if(ModeloCheck == false && SurelyCheck == false && BaiCheck == false)
            {
                Item = 0;
            }
            else
            {
                Item = 1;
            }
        }




        private double _checkOut;
        public double CheckOut 
        {
            get => _checkOut;
            set
            {
                _checkOut = value; 
                OnPropertyChanged();
            }
        }

        public void CheckOutTotal()
        {
            if(ModeloCheck==true)
            {
                CheckOut = Math.Round((SubTotal + Shipping), 2);
            }
            else if(SurelyCheck == true)
            {
                CheckOut = Math.Round((SubTotal + Shipping), 2);
            }else if(BaiCheck == true)
            {
                CheckOut = Math.Round((SubTotal + Shipping), 2);
            }
            else
            {
                CheckOut = 0;
            }
           
        }

        public void Total()
        {
            ModeloCalculate();
            SurelyCalculate();
            BaiCalculate();
            SubTotals();
            ItemTotal();
            CheckOutTotal();
        }


        public void ApplyCommands()
        {
            Discount();
            CheckOutTotal();
        }
        public void CommandMethods()
        {
            ModeloPlusCommand = new Command(ModeloIncrement);
            ModeloMinusCommand = new Command(ModeloDecrement);
            SurelyMinusCommand = new Command(SurelyDecrement);
            SurelyPlusCommand = new Command(SurelyIncrement);
            BaiMinusCommand = new Command(BaiDecrement);
            BaiPlusCommand = new Command(BaiIncrement);
            CalculateCommand = new Command(Total);
            ApplyCommand = new Command(ApplyCommands);
        }

        public void MethodCalling()
        {
            _page5Model.ModeloCheck = ModeloCheck;
             ModeloPrize=_page5Model.ModeloPrize;
            _page5Model.ModeloValue= ModeloValue;

            _page5Model.SurelyCheck = SurelyCheck;
            SurelyPrize = _page5Model.SurelyPrize;
            _page5Model.SurelyValue = SurelyValue;

            _page5Model.BaiCheck = BaiCheck;
            BaiPrize = _page5Model.BaiPrize;
            _page5Model.BaiValue = BaiValue;

            _page5Model.PromoCode= PromoCode;
            _page5Model.SubTotal = SubTotal;
            Shipping = _page5Model.Shipping;

            _page5Model.Item= Item;
            _page5Model.CheckOut=CheckOut;
        }

        public Page5ViewModel()
        {
            _page5Model =new Page5Model();
            CommandMethods();
            MethodCalling();
            
        }

    }
}
