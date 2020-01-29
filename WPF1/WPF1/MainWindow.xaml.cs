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

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClearAllTextBoxes();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void ClearAllTextBoxes()
        {
            txtbxAddress.Clear();
            txtbxName.Clear();
            txtbxZipCode.Clear();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string address, name, zipCode;
            address = txtbxAddress.Text;
            name = txtbxName.Text;
            zipCode = txtbxZipCode.Text;
            EntryForm newEntryForm = new EntryForm(name, address, Convert.ToInt32(zipCode));
            lstbxEntryForms.Items.Add(newEntryForm);
            ClearAllTextBoxes();
        }
    }
}
