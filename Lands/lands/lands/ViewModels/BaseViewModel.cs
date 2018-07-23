
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace lands.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        protected void SetValue<T>(ref T backingField,T value,[CallerMemberName]string PropertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField,value))
            {
                return;
            }

            backingField = value;
            OnPropertyChanged(PropertyName);
        }
    }
}
