using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestXaf.Models
{
    [DefaultClassOptions]
    [Persistent("spClass")]
    [DefaultProperty(nameof(Name))]
    public class spClass : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { SetPropertyValue(ref id, value); }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { SetPropertyValue(ref name, value); }
        }


        #region INotifyPropertyChanged
        private PropertyChangedEventHandler propertyChanged;
        protected bool SetPropertyValue<T>(ref T propertyValue, T newValue, [CallerMemberName] string propertyName = null) where T : struct
        {
            if (EqualityComparer<T>.Default.Equals(propertyValue, newValue))
            {
                return false;
            }
            propertyValue = newValue;
            OnPropertyChanged(propertyName);
            return true;
        }
        protected bool SetPropertyValue<T>(ref T? propertyValue, T? newValue, [CallerMemberName] string propertyName = null) where T : struct
        {
            if (EqualityComparer<T?>.Default.Equals(propertyValue, newValue))
            {
                return false;
            }
            propertyValue = newValue;
            OnPropertyChanged(propertyName);
            return true;
        }
        protected bool SetPropertyValue(ref string propertyValue, string newValue, [CallerMemberName] string propertyName = null)
        {
            if (propertyValue == newValue)
            {
                return false;
            }
            propertyValue = newValue;
            OnPropertyChanged(propertyName);
            return true;
        }
        protected bool SetReferencePropertyValue<T>(ref T propertyValue, T newValue, [CallerMemberName] string propertyName = null) where T : class
        {
            if (propertyValue == newValue)
            {
                return false;
            }
            propertyValue = newValue;
            OnPropertyChanged(propertyName);
            return true;
        }
        private void OnPropertyChanged(string propertyName)
        {
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add { propertyChanged += value; }
            remove { propertyChanged -= value; }
        }
        #endregion

    }
}
