using DailyTasksApp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyTasksApp.MVVM.ViewModel {
    class MainViewModel : ObservableObject {

        public HomeViewModel HomeVM { get; set; }
        public NoteViewModel NoteVM {get; set;}
        public ReminderViewModel ReminderVM { get; set; }
        public UrgentViewModel UrgentVM { get; set; }
        public OpenViewModel OpenVM { get; set; }
        public SaveViewModel SaveVM { get; set; }

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand NoteViewCommand { get; set; }
        public RelayCommand ReminderViewCommand { get; set; }
        public RelayCommand UrgentViewCommand { get; set; }
        public RelayCommand OpenViewCommand { get; set; }
        public RelayCommand SaveViewCommand { get; set; }

        private object _currentView;
        public Object CurrentView {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public MainViewModel() {

            HomeVM = new HomeViewModel();
            NoteVM = new NoteViewModel();
            ReminderVM = new ReminderViewModel();
            UrgentVM = new UrgentViewModel();
            OpenVM = new OpenViewModel();
            SaveVM = new SaveViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => {

                CurrentView = HomeVM;
            });

            NoteViewCommand = new RelayCommand(o => {

                CurrentView = NoteVM;
            });

            ReminderViewCommand = new RelayCommand(o => {

                CurrentView = ReminderVM;
            });

            UrgentViewCommand = new RelayCommand(o => {

                CurrentView = UrgentVM;
            });
        }
    }  
}
