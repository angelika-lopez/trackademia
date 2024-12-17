using Trackademia_PDC50.ViewModel;

namespace Trackademia_PDC50.View
{
    public partial class AddGradePage : ContentPage
    {
        public AddGradePage()
        {
            InitializeComponent();
            BindingContext = new AddGradeViewModel();
        }
    }
}

