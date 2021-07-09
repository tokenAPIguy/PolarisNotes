using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows;

namespace DailyTasksApp.MVVM.ViewModel {
    public sealed class NoteViewModel {

        private static NoteViewModel noteVM = null;
        private static readonly object padlock = new object();

        public NoteViewModel() {}
        
        public static NoteViewModel NoteVM {

            get {
                lock (padlock) {
                    if (noteVM == null) {
                        noteVM = new NoteViewModel();
                    }

                    return noteVM;
                }
            }
        }
    }
}

