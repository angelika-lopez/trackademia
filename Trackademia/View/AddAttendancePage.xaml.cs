using Trackademia_PDC50.ViewModel;

namespace Trackademia_PDC50.View;

public partial class AddAttendancePage : ContentPage
{
    public AddAttendancePage()
    {
        InitializeComponent();
        BindingContext = new AddAttendanceViewModel();
    }
}
