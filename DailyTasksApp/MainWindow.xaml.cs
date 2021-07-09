using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System;
using System.Windows.Input;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace DailyTasksApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) {
            Close();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e) {
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e) {

            if (this.WindowState != WindowState.Maximized) {
                this.WindowState = WindowState.Maximized;
            }

            else {
                this.WindowState = WindowState.Normal;
            }
            
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e) {
            Microsoft.Win32.SaveFileDialog saveFileDlg = new Microsoft.Win32.SaveFileDialog();
            saveFileDlg.FileName = "Document"; // Default file name
            saveFileDlg.DefaultExt = ".text"; // Default file extension
            saveFileDlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            Nullable<bool> result = saveFileDlg.ShowDialog();

            if (result == true) {
                File.WriteAllText(saveFileDlg.FileName, TextBox.Text);
            }
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e) {

            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = openFileDlg.ShowDialog();

            if (result == true) {
                TextBox.Text = openFileDlg.FileName;
                TextBox.Text = File.ReadAllText(openFileDlg.FileName);
            }
        }
    }
}