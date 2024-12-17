using Trackademia_PDC50.ViewModel;
using Trackademia_PDC50.Model;
using Trackademia_PDC50.View;

namespace Trackademia_PDC50
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(StudentDetailsPage), typeof(StudentDetailsPage));
            Routing.RegisterRoute(nameof(AddGradePage), typeof(AddGradePage));
            Routing.RegisterRoute(nameof(EditGradePage), typeof(EditGradePage));
            Routing.RegisterRoute(nameof(AddAttendancePage), typeof(AddAttendancePage));
            Routing.RegisterRoute(nameof(EditAttendancePage), typeof(EditAttendancePage));
        }
    }
}
