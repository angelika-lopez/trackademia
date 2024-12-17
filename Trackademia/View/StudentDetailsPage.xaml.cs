using Trackademia_PDC50.ViewModel;

namespace Trackademia_PDC50.View
{
    public partial class StudentDetailsPage : ContentPage
    {
        public StudentDetailsPage()
        {
            InitializeComponent();
            BindingContext = new StudentDetailsViewModel();
        }
    }
}

