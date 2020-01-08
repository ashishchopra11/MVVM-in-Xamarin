using MVVMPart1.Models;
using MVVMPart1.Services;
using MVVMPart1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MVVMPart1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }
        //public List<Employee> _employeesList;
        private List<Employee> _employeesList;
        public List<Employee> EmployeesList
        {
            get { return _employeesList; }
            set { _employeesList = value;
                OnPropertyChanged();

            }
        }
        public Command AddEmployee => new Command(() =>
                 {
                     Navigation.PushAsync(new AddEmployeePage());
                 });

        //public List<Employee> EmployeesList
        //{ get => _employeesList;
        //  set => _employeesList = value;
        //         OnPropertyChanged();
        // }

        public MainViewModel(INavigation navigation)
        {
            Navigation = navigation;
            var employeesServices = new EmployeesServices();
            EmployeesList = employeesServices.GetEmployees();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
