using CommunityToolkit.Mvvm.ComponentModel;
using FileOrbisProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOrbisProject.ViewModels
{
    public partial class BaseClientViewModel : BaseViewModel
    {
        [ObservableProperty]
        private Clients _clients;
    }
}
