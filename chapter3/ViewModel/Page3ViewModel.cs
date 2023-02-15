using chapter3.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace chapter3.ViewModel.Profile
{
    public class Page3ViewModel : INotifyPropertyChanged

    {
        private readonly Page3Model _page3Model;
        public bool OtherCheck { get; set; }
       
        private bool _visible;
        public bool Visible
        {
            get => _visible;
            set 
            { 
                _visible = value;
                OnPropertyChanged();
            }
        }

        public ICommand DisplayCommand { get; private set; }

        public void Display()
        {

            if (OtherCheck == true)
            {
               Visible = true;
            }
            else
            {
               Visible = false;
            }         
        }

        public void Values()
        {
            _page3Model.OtherCheck = OtherCheck;
            _page3Model.Visible=Visible;
        }
        public void Methods()
        {
            Display();
            Values();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public Page3ViewModel()
        {
            _page3Model = new Page3Model();  
            DisplayCommand = new Command(Methods);
        }


    }
}
