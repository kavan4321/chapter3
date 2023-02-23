using chapter3.Model.ColorPick;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace chapter3.ViewModel.ColorPick
{
    public class Page7ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private Page7Model _page7Model;
      
        private double _redColor;
        public double RedColor
        {
            get => _redColor;
            set
            {
                _redColor = value;
                OnPropertyChanged();
            }
        }

        
        private double _greenColor;

        public double GreenColor
        {
            get { return _greenColor; }
            set
            {
                _greenColor = value;
                OnPropertyChanged();
            }

        }



        private double _blueColor;
        public double BlueColor
        {
            get { return _blueColor; }
            set
            {
                _blueColor = value;
                OnPropertyChanged();
            }

        }



        private Color _color;
        public Color Colors {
            get { return _color;}
            set
            {
                _color = value;
                OnPropertyChanged();
            }
        }


        private string _hexValue="000000";
        public string HexValue
        {
            get { return _hexValue; }
            set
            {
                _hexValue = value;
                OnPropertyChanged();
            }
        }

        public void Values()
        {          
             Colors = Color.FromRgb((int)RedColor, (int)GreenColor, (int)BlueColor);
             var red =((int)RedColor).ToString("X2");
             var green =((int) GreenColor).ToString("X2");
             var blue = ((int)BlueColor).ToString("X2");
             HexValue = red.ToString() + green.ToString() + blue.ToString();
        }
        public void RandomColor()
        {
             Random random = new();
             RedColor = random.Next(0, 255);
             GreenColor = random.Next(0, 255);
             BlueColor = random.Next(0, 255);
             Values();
        }

        public void MethodCalling()
        {
            _page7Model.BlueColor = BlueColor;
            _page7Model.RedColor = RedColor;
            _page7Model.GreenColor = GreenColor;
            _page7Model.BgColor = Colors;
        }
        public ICommand RandomButton { get; private set; }
      
        public Page7ViewModel()
        {
            _page7Model = new Page7Model();
            RandomButton = new Command(RandomColor);
            MethodCalling();
        }


    }
}



       
       
    
