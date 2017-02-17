using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace Contact
{
	public partial class AddContactView : ContentPage
	{
		public AddContactView()
		{
			this.LoadFromXaml(typeof(AddContactView));

			InitializeComponent();
		}

        async void OnAddContactButtonClicked(object sender, EventArgs args)
        {
           /* try
            {
                DependencyService.Get<IContactPreferences>().AddContactToPreferences(Person.CreatePersonWithData(
                    nameEntry.Text,
                    numberEntry.Text,
                    addressEntry.Text), "person5");

                await Navigation.PopAsync();
            }
            catch (PersonNullDataException ex)
            {
                await DisplayAlert("Alert !", ex.Message, "OK");
            }
            catch (PersonNumberFormatException ex)
            {
                await DisplayAlert("Alert !", ex.Message, "OK");
            }
            */

            try
            {
                ContactDataBaseManager contactProvider = new ContactDataBaseManager();
                bool result = contactProvider.InsertPersonIntoDataBase(
                    nameEntry.Text,
                    numberEntry.Text,
                    addressEntry.Text);

                await DisplayAlert("Name", result.ToString(), "OK");

                await Navigation.PopAsync();
            }
            catch (PersonNullDataException ex)
            {
                await DisplayAlert("Alert !", ex.Message, "OK");
            }
            catch (PersonNumberFormatException ex)
            {
                await DisplayAlert("Alert !", ex.Message, "OK");
            }

        }
	}
}
