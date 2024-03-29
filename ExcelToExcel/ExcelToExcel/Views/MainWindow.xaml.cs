﻿using ExcelToExcel.ViewModels;
using Microsoft.Win32;
using System.Windows;

namespace ExcelToExcel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mvm;
        public MainWindow()
        {
            InitializeComponent();
            mvm = new MainViewModel();
            DataContext = mvm;
        }

        private void BtnInputFile_Click(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == true)
            {
                mvm.InputFilename = ofd.FileName;
            }
        }

        private void BtnOutputFile_Click(object sender, RoutedEventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "CSV|*.csv|json|*.json|Fichier Excel|*.xlsx|Tous les fichiers|*.*";

            if (sfd.ShowDialog() == true)
            {
                mvm.OutputFilename = sfd.FileName;
            }
        }
    }
}
