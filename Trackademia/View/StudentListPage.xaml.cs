using Microsoft.Maui.Controls;
using Trackademia_PDC50.ViewModel;

namespace Trackademia_PDC50.View
{
	public partial class StudentListPage : ContentPage
	{
		private readonly StudentListViewModel _viewModel;

		public StudentListPage()
		{
			InitializeComponent();
			_viewModel = new StudentListViewModel();
			BindingContext = _viewModel;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			_viewModel.LoadStudentsCommand.Execute(null);
		}
	}
}