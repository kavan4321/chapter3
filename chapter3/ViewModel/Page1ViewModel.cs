using chapter3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace chapter3.ViewModel.DisplayRandomQuote
{
    class Page1ViewModel : INotifyPropertyChanged
    {
        private readonly Page1Model _page1Model;
        
        private string _quoteDisplay;       
        public string QuoteDisplay
        {
            get => _quoteDisplay;
            set
            {
                _quoteDisplay = value;
                OnPropertyChanged();
            }
        }

             
       
        public ICommand RandomCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public Page1ViewModel()
        {
            RandomCommand = new Command(PerformAction);
           _page1Model = new Page1Model();

        }
        public void PerformAction()
        {
           _page1Model.QuoteList();
            QuoteDisplay = _page1Model.QuoteDisplay;
            OnPropertyChanged();
        }

    }
}
