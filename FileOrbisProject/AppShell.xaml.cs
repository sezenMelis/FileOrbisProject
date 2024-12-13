﻿namespace FileOrbisProject;
using FileOrbisProject.Views;
using FileOrbisProject.ViewModels;


public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.BindingContext = new AppShellViewModel();
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(AddClientPage), typeof(AddClientPage)); 

        }
    }

