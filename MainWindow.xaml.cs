﻿using System;
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
using System.Collections.ObjectModel;

namespace CA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> fullTimeEmployees = new ObservableCollection<Employee>();
        ObservableCollection<Employee> partTimeEmployees = new ObservableCollection<Employee>();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           

        }


        private void tbxNewName_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxFirstName.Clear();
        }



        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
           

                string firstName = tbxFirstName.Text;
                string lastName = tbxSurname.Text;
                decimal salary = Convert.ToInt32(tbxSalary.Text);

                //create student object



                FullTimeEmployee e1 = new FullTimeEmployee(firstName, lastName, salary);


                //add to observable collection
                fullTimeEmployees.Add(e1);

                lbxNames.Items.Add(e1);
            
            //refresh display manually
            //lbxNames.ItemsSource = null;
            //lbxNames.ItemsSource = names;

        }

        private void lbxNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FullTimeEmployee selectedWorker = lbxNames.SelectedItem as FullTimeEmployee;

            if (selectedWorker != null)
            {
                //take action - update the display
                tbxFirstName.Text = selectedWorker.FirstName;
                tbxSurname.Text = selectedWorker.LastName;
                tbxSalary.Text = selectedWorker.Salary.ToString();
                
            }

          
        }

        private void cBoxFullTime_Checked(object sender, RoutedEventArgs e)
        {

        }

        
    }

    
}
