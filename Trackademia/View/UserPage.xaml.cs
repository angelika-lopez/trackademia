using Microsoft.Maui.Controls;
using Trackademia_PDC50.ViewModel;

namespace Trackademia_PDC50.View
{
    public partial class UserPage : ContentPage
    {
        private readonly UserViewModel _viewModel;
        public UserPage()
	    {
		    InitializeComponent();
		    _viewModel = new UserViewModel();
            BindingContext = _viewModel;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.LoadUserCommand.Execute(null);
        }
    }

}
