using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace ExerciseGenerator.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged == null)
                return;

            if (Application.Current != null && Application.Current.Dispatcher.Thread != Thread.CurrentThread)
                Application.Current.Dispatcher.Invoke(() => PropertyChanged(this, new PropertyChangedEventArgs(info)), DispatcherPriority.DataBind);
            else
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
