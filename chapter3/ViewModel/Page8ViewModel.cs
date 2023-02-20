using chapter3.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace chapter3.ViewModel.QAQuiz
{
    public class Page8ViewModel : INotifyPropertyChanged
    {
        private Page8Model _page8Model;

        public event PropertyChangedEventHandler PropertyChanged;

        private int _counts=0;
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

       
        private string _question= "Have You finished Graduation?";
        public string Question
        {
            get { return _question; }
            set
            {
                _question = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public ICommand NextCommand { get; private set; }
        public Page8ViewModel()
        {
            _page8Model = new Page8Model();
            NextCommand = new Command(Methods);
        }

        public void MethodCalling()
        {
            Question = _page8Model.ListOfQuestion[Counts];
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

            if (Question == "Have You finished Graduation?" && Yes == true)
            {
                Question = _page8Model.ListOfQuestion[1];
            }
            else if (Question == "Have You finished Graduation?" && No == true)
            {
                Question = _page8Model.ListOfQuestion[2];
            }
            else if (Question == _page8Model.ListOfQuestion[1] && Yes == true)
            {
                Question = _page8Model.ListOfQuestion[3];
            }
            else if (Question == _page8Model.ListOfQuestion[1] && No == true)
            {
                Question = _page8Model.ListOfQuestion[4];
            }
            else if (Question == _page8Model.ListOfQuestion[3] && Yes == true)
            {
                Question = _page8Model.ListOfQuestion[7];
            }
            else if (Question == _page8Model.ListOfQuestion[3] && No == true)
            {
                Question = _page8Model.ListOfQuestion[8];
            }
            else if (Question == _page8Model.ListOfQuestion[4] && Yes == true)
            {
                Question = _page8Model.ListOfQuestion[9];
            }
            else if (Question == _page8Model.ListOfQuestion[4] && No == true)
            {
                Question = _page8Model.ListOfQuestion[8];
            }
            else if (Question == _page8Model.ListOfQuestion[2] && Yes == true)
            {
                Question = _page8Model.ListOfQuestion[5];
            }
            else if (Question == _page8Model.ListOfQuestion[2] && No == true)
            {
                Question = _page8Model.ListOfQuestion[6];
            }
            else if (Question == _page8Model.ListOfQuestion[5] && Yes == true)
            {
                Question = _page8Model.ListOfQuestion[11];
            }
            else if (Question == _page8Model.ListOfQuestion[5] && No == true)
            {
                Question = _page8Model.ListOfQuestion[12];
            }
            else if (Question == _page8Model.ListOfQuestion[6] && Yes == true)
            {
                Question = _page8Model.ListOfQuestion[13];
            }
            else if (Question == _page8Model.ListOfQuestion[6] && Yes == true)
            {
                Question = _page8Model.ListOfQuestion[14];
            }
        }        

               
    }
}
