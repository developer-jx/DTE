﻿using DTE.ViewModels;
using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace DTE.Views.Windows
{
    /// <summary>
    /// Interaction logic for GeneratePeasyWindow.xaml
    /// </summary>
    public partial class GeneratePeasyWindow : MetroWindow
    {
        public GeneratePeasyWindow()
        {
            InitializeComponent();
        }
        public GeneratePeasyWindow(List<Domains.Table> selectedTables, CORE.DTECore dteCore)
        {
            InitializeComponent();
            DataContext = new PeasyVM(selectedTables,dteCore);
        }
    }
}
