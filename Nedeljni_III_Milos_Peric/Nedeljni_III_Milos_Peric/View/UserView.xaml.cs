﻿using Nedeljni_III_Milos_Peric.ViewModel;
<<<<<<< HEAD
using System.Windows;
=======
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
>>>>>>> features/Milos

namespace Nedeljni_III_Milos_Peric.View
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : Window
    {
        public UserView(tblUser user)
        {
            InitializeComponent();
<<<<<<< HEAD
            this.DataContext = new UserViewModel(this, user);
        }

        public UserView()
        {
            InitializeComponent();
            this.DataContext = new UserViewModel(this);
=======
            DataContext = new UserViewModel(this, user);
>>>>>>> features/Milos
        }
    }
}
