using Trackademia_PDC50.ViewModel;

namespace Trackademia_PDC50.View;

public partial class EditAttendancePage : ContentPage
{
    public EditAttendancePage()
    {
        InitializeComponent();
        BindingContext = new EditAttendanceViewModel();
    }
}
