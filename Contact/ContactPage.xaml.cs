using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System;

namespace Contact
{
	public partial class ContactPage : ContentPage	
	{
        ContactsProvider provider;

		public ContactPage()
		{
			this.LoadFromXaml(typeof(ContactPage));

			InitializeComponent();

			provider = new ContactsProvider();
            ContactList.ItemsSource = provider.getcontacts();

			ContactList.ItemTemplate = new DataTemplate(typeof(CustomCell));
		}

		async void OnAddContactButtonClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new AddContactView());
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            provider.getcontacts();
        }
	}
}