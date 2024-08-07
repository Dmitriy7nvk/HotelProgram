﻿using HotelProgram.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotelProgram.Views
{
    /// <summary>
    /// Логика взаимодействия для RoomsView.xaml
    /// </summary>
    public partial class RoomsView : UserControl
    {
        public RoomsView()
        {
            InitializeComponent();
            DataGrid.ItemsSource = Hotel_bdEntities.GetContext().rooms.ToList();
            var context = new Hotel_bdEntities();
            var viewModel = new RoomsViewModel(context, GetCurrentEmployeeId());
            DataContext = viewModel;
        }
        private int GetCurrentEmployeeId()
        {
            var authenticatedUser = LoginViewModel.GetAuthenticatedUser();
            if (authenticatedUser != null)
            {
                using (var context = new Hotel_bdEntities())
                {
                    var employee = context.employees.FirstOrDefault(e => e.Id == authenticatedUser.Id);
                    if (employee != null)
                    {
                        return employee.employee_id;
                    }
                }
            }
            return 0;
        }
    }
}
