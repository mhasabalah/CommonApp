namespace Employees.Client.EmployeePages;
public partial class EmployeeInfo
{
    [Parameter] public EmployeeViewModel? Employee { get; set; }
    private ModalForm modal { get; set; }

    private void CloseForm() => modal.Close();
}