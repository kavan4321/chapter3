
using chapter3.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace chapter3.ViewModel.ConfirmDelete
{
    public class Page4ViewModel : INotifyPropertyChanged
    {

        private Page4Model _page4Model;
        private bool _enable;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public bool Check { get; set; }

        public bool Enable
        {
            get => _enable;
            set { 
                _enable = value;
                OnPropertyChanged();
            }
        }

        public void EnableButton()
        {
            if (Check == true)
            {
                Enable= true;
            }
            else
            {
                Enable = false;
            }
        }
        public ICommand EnableCommand { get; private set; }

        public Page4ViewModel()
        {
            _page4Model= new Page4Model();
            EnableCommand = new Command(EnableButton);
            _page4Model.Check = Check;
            _page4Model.Enable = Enable;
        }
    }
}
