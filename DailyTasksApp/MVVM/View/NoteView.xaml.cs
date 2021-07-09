using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Runtime.CompilerServices;


namespace DailyTasksApp.MVVM.View {
    /// <summary>
    /// Interaction logic for NoteView.xaml
    /// </summary>
    public partial class NoteView : UserControl, INotifyPropertyChanged {
        public NoteView() {

            DataContext = this;
            InitializeComponent();
        }

        private string _boundNote;
        public string BoundNote {
            get { return _boundNote; }
            set {
                if (value != _boundNote) {
                    _boundNote = value; OnPropertyChanged("_boundNote");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null) {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}