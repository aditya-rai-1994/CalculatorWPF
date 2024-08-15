using calculatorPractice.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace calculatorPractice.ViewModel
{
    public class CalculatorViewModel: INotifyPropertyChanged
    {
        private CalculatorModel _model = new CalculatorModel();
        private double _operand1;
        private double _operand2;
        private double _result;
        public double Operand1
        {
            get => _operand1;
            set
            {
                _operand1 = value;
                OnPropertyChanged(nameof(Operand1));
            }
        }
        public double Operand2
        {
            get => _operand2;
            set
            {
                _operand2 = value;
                OnPropertyChanged(nameof(Operand2));
            }
        }
        public double Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }
        private bool CanExecute() => true;
        private void Add() => Result = _model.Add(Operand1, Operand2);
        private void Substract() => Result = _model.Substract(Operand1, Operand2);
        private void Multiply()=> Result = _model.Multiply(Operand1, Operand2);
        private void Divide()=> Result = _model.Divide(Operand1, Operand2);

        public ICommand AddCommand { get; }
        public ICommand SubtractCommand { get; }
        public ICommand MultiplyCommand { get; }
        public ICommand DivideCommand { get; }
        public CalculatorViewModel()
        {
            AddCommand = new RelayCommand(_ => Add(), _ => CanExecute());
            SubtractCommand = new RelayCommand(_ => Substract(), _ => CanExecute());
            MultiplyCommand = new RelayCommand(_ => Multiply(), _ => CanExecute());
            DivideCommand = new RelayCommand(_ => Divide(), _ => CanExecute());
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
