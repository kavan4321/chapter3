using chapter3.Model;
using System.ComponentModel;
using System.Windows.Input;

namespace chapter3.ViewModel.QAQuiz
{
    public class Page8ViewModel : INotifyPropertyChanged
    {
        private Page8Model _page8Model;

        public event PropertyChangedEventHandler PropertyChanged;

        private int _counts;
        public int Counts
        {
            get { return _counts; }
            set
            {
                _counts = value;
                OnPropertyChanged();
            }
        }

        private bool _yes;
        public bool Yes
        {

            get => _yes;
            set { _yes = value;
                OnPropertyChanged();
            }
        }

        private bool _no;

        public bool No
        {

            get => _no;
            set
            {
                _no = value;
                OnPropertyChanged();
            }
        }

        public string Que
        {
            get
            {
                if (Counts == 0)
                {
                    return _page8Model.ListOfQuestion[0];
                }
                else
                    return Question;
            }
        }
        private string _question;
        public string Question
        {
            get { return _question; }
            set
            {
                _question = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged(string name = "")
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        public ICommand NextCommand { get; private set; }
        public Page8ViewModel()
        {
            _page8Model = new Page8Model();
            NextCommand = new Command(Methods);
        }

        public void Methods()
        {
           
            CheckAnswer();
             ClearCheck();
        }

        public void ClearCheck()
        {
            Yes= false;
            No= false;
        }



        public void CheckAnswer()
        {
            if (Yes == true && Question == _page8Model.ListOfQuestion[0])
            {

                Question = _page8Model.ListOfQuestion[1];
                Yes = false;
            }
            else
            {
                Question = _page8Model.ListOfQuestion[2];
                No = false;
            }
        }        
               
    }
}
