using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using System.Collections.Generic;

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
            int providerChoice = (int)new ContactsProvider().providerType;
            try
            {
                if (providerChoice == 1)
                {
                    DependencyService.Get<IContactPreferences>().AddContactToPreferences(Person.CreatePersonWithData(
                        nameEntry.Text,
                        numberEntry.Text,
                        addressEntry.Text), "person5");
                }
                else
                {
                    ContactDataBaseManager contactProvider = new ContactDataBaseManager();
                    bool result = contactProvider.InsertPersonIntoDataBase(Person.CreatePersonWithData(
                        nameEntry.Text,
                        numberEntry.Text,
                        addressEntry.Text));
                }
                    
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

        async void OnCancelAddingContactButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
        }
	}
}
