using chapter3.Model.ColorPick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace chapter3.ViewModel.ColorPick
{
    public class Page7ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private  Page7Model _page7Model;

       
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

        public int REDcolor
        {
            get { return (int)RedColor; }
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

        public int GREENcolor
        {
            get { return (int)GreenColor; }
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


        public int BLUEcolor
        {
            get { return (int)BlueColor; }
        }

        public Color Color
        {
            get => Color.FromRgb((int)RedColor, (int)GreenColor, (int)BlueColor);

        }

        
        public string HexValue
        {
            get => REDcolor.ToString("X") + GREENcolor.ToString("X") + BLUEcolor.ToString("X") ;
        }



        protected virtual void OnPropertyChanged(string name = "")
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        public void RandomColor()
        {

             Random random = new();
             RedColor = random.Next(0, 256);
             GreenColor = random.Next(0, 256);
             BlueColor = random.Next(0, 256);

        }

        public ICommand RandomButton { get; private set; }

        public Page7ViewModel()
        {
            _page7Model = new Page7Model();
            RandomButton = new Command(RandomColor);
            _page7Model.BlueColor=BlueColor;
            _page7Model.RedColor= RedColor; 
            _page7Model.GreenColor= GreenColor;
            _page7Model.BgColor = Color;
        }


    }
}



       
       
    
