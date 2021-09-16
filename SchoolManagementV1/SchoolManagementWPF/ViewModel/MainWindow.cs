using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Toolkit.Mvvm;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using System.Windows.Input;
using System.Windows;

namespace SchoolManagementWPF.ViewModel
{
    public class MainWindow : ObservableObject
    {
        private WindowState _currentWindowState;
        public WindowState CurrentWindowState
        {
            get => _currentWindowState;
            set
            {
                _currentWindowState = value;
                base.OnPropertyChanged("CurrentWindowState");
            }
        }
        public MainWindow()
        {
            
        }

        public ICommand BtnMaximize
        {
            get { return new RelayCommand<object>(param => onBtnMaximize()); }
        }
        public ICommand BtnMinimize
        {
            get { return new RelayCommand<object>(param => onBtnMinimize()); }
        }
        void onBtnMaximize()
        {
            CurrentWindowState = CurrentWindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }
        void onBtnMinimize()
        {
            CurrentWindowState = WindowState.Minimized;
        }
    }
}
