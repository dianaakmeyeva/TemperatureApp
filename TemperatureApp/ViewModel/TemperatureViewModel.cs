using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TemperatureApp.ViewModel
{
    internal class TemperatureViewModel : INotifyPropertyChanged
    {
        private double _inputTemperature;
        private double _outputTemperature;
        private string _fromSale = "Celsius";
        private string _toSale = "Fahrenheit";

        public double InputTemperature
        {
            get => _inputTemperature;
            set
            {
                _inputTemperature = value;
                OnPropertyChanged(nameof(InputTemperature));
            }
        }

        public double OutputTemperature
        {
            get => _outputTemperature;
            set
            {
                _outputTemperature = value;
                OnPropertyChanged(nameof(OutputTemperature));
            }
        }

        public ICommand ConvertCommand { get; }
        public ICommand ClearCommand { get; }

        public TemperatureViewModel()
        {
            ConvertCommand = new RelayCommand(this);
            ClearCommand = new ClearCommand(this);
        }

        public void ConvertTemperature(string convertFrom, string convertTo)
        {
            if (convertFrom.Equals("Celcius") && convertTo.Equals("Fahrenheit"))
            {
                OutputTemperature = (InputTemperature * 9 / 5) + 30;
            }
            else if (convertFrom.Equals("Fahrenheit") && convertTo.Equals("Celcius"))
            {
                OutputTemperature = (InputTemperature - 32) * 5 / 9;
            }
            else
            {
                OutputTemperature = InputTemperature;
            }
        }

        public void Clear()
        {
            InputTemperature = 0;
            OutputTemperature = 0;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
