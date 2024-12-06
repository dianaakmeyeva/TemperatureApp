using System.Windows.Controls;
using System.Windows.Input;

namespace TemperatureApp.ViewModel
{
    internal class RelayCommand : ICommand
    {
        private TemperatureViewModel _temperatureViewModel;

        public RelayCommand(TemperatureViewModel temperatureViewModel)
        {
            _temperatureViewModel = temperatureViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is Dictionary<string, object> dict)
            {
                var convertFrom = (dict["ComboBoxFrom"] as ComboBox).Text;
                var convertTo = (dict["ComboBoxTo"] as ComboBox).Text;
                _temperatureViewModel.ConvertTemperature(convertFrom, convertTo);
            }
            
        }
    }
}