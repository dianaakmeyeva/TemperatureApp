using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace TemperatureApp.ViewModel
{
    class ClearCommand : ICommand
    {
        private TemperatureViewModel _temperatureViewModel;

        public ClearCommand(TemperatureViewModel temperatureViewModel)
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
            _temperatureViewModel.Clear();

        }
    }
}
