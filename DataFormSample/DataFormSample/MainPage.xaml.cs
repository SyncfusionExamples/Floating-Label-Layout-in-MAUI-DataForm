using Syncfusion.Maui.DataForm;
using System.ComponentModel.DataAnnotations;

namespace DataFormSample
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void SfDataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                if (e.DataFormItem.FieldName == "FirstName")
                {
                    e.DataFormItem.LabelText = "Name";
                    e.DataFormItem.PlaceholderText = "Enter your first name";
                    e.DataFormItem.TextInputLayoutSettings = new TextInputLayoutSettings
                    {
                        ContainerType = TextInputLayoutContainerType.Filled,
                        ShowHelperText = false
                    };
                    e.DataFormItem.ShowLeadingView = true;
                    e.DataFormItem.LeadingView = new Label
                    {
                        Text = "F",
                        FontFamily = "InputLayoutIcons",
                        TextColor = Colors.Gray,
                        FontSize = 18,
                        HeightRequest = 24,
                        VerticalTextAlignment = TextAlignment.End
                    };
                }
                else if (e.DataFormItem.FieldName == "ContactNumber")
                {
                    e.DataFormItem.ShowTrailingView = true;
                    e.DataFormItem.TrailingView = new Label
                    {
                        Text = "E",
                        FontFamily = "InputLayoutIcons",
                        TextColor = Colors.Gray,
                        FontSize = 18,
                        HeightRequest = 24,
                        VerticalTextAlignment = TextAlignment.End
                    };
                    e.DataFormItem.TrailingViewPosition = TextInputLayoutViewPosition.Inside;
                }
                else if (e.DataFormItem.FieldName == "Password" && e.DataFormItem is DataFormPasswordItem passwordItem)
                {
                    passwordItem.EnablePasswordVisibilityToggle = true;
                    passwordItem.TextInputLayoutSettings = new TextInputLayoutSettings
                    {
                        OutlineCornerRadius = 10,
                        Stroke = Colors.DeepPink,
                        FocusedStroke = Colors.DodgerBlue,
                        FocusedStrokeThickness = 4.0,
                        UnfocusedStrokeThickness = 2.0
                    };
                }
            }
        }
    }

    public class ContactInfo
    {
        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? LastName { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public string? ContactNumber { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }

        public DateTime? BirthDate { get; set; }
    }

    public class ViewModel
    {
        public ContactInfo Info { get; set; }

        public ViewModel()
        {
            Info = new ContactInfo();
        }
    }

}
