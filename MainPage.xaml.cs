namespace Android_project
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }


        private async void btnSubmit_Clicked(object sender, EventArgs e)
        {
            //var response = await DisplayAlert("Confirmation", "Do you want to submit?", "Ok", "Cancle");
            

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                await DisplayAlert("Warning", "Please enter a  name.", "OK");
                return;
            }
            if (string.IsNullOrEmpty(txtDestination.Text) || string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                await DisplayAlert("Warning", "Please enter a  destination.", "OK");
                return;
            }
            if (txtParking.SelectedIndex==-1)
            {
                await DisplayAlert("Warning", "Please enter parking choice.", "OK");
                return;
            }
            if (txtLenght.SelectedIndex == -1)
            {
                await DisplayAlert("Warning", "Please enter lenght.", "OK");
                return;
            }
            if (txtLevel.SelectedIndex == -1)
            {
                await DisplayAlert("Warning", "Please enter Level.", "OK");
                return;
            }
            else 
            {
                await DisplayAlert("Information", "Information submitted", "Ok");

                SemanticScreenReader.Announce(btnSubmit.Text);
            }
        }
        
    }
}