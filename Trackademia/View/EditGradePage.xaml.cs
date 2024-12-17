using Trackademia_PDC50.ViewModel;

namespace Trackademia_PDC50.View
{
    public partial class EditGradePage : ContentPage
    {
        public EditGradePage()
        {
            InitializeComponent();
            BindingContext = new EditGradeViewModel();
        }
    }
}
