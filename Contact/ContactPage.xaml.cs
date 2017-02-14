using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System;

namespace Contact
{
	public partial class ContactPage : NavigationPage
	{
		List<Person> contacts;

		public ContactPage()
		{
			this.LoadFromXaml(typeof(ContactPage));

			InitializeComponent();

			ContactsProvider provider = new ContactsProvider();
			contacts = provider.getcontacts();

			ContactList.ItemsSource = contacts;
			ContactList.ItemTemplate = new DataTemplate(typeof(CustomCell));
			setContactsToList();
		}

		public void setContactsToList()
		{
			var personDataTemplate = new DataTemplate(() =>
			{
				var grid = new Grid();

				var nameLabel = new Label { FontAttributes = FontAttributes.Bold, FontSize = 15 };
				var numberlabel = new Label { FontAttributes = FontAttributes.Italic, FontSize = 12 };
				var addressLabel = new Label { FontSize = 15 };

				nameLabel.SetBinding(Label.TextProperty, "Name");
				numberlabel.SetBinding(Label.TextProperty, "Number");
				addressLabel.SetBinding(Label.TextProperty, "Address");

				grid.Children.Add(nameLabel, 0, 0);
				grid.Children.Add(numberlabel, 0, 1);
				grid.Children.Add(addressLabel, 0, 2);

				return new ViewCell { View = grid };
			});


			//var contactsList = new ListView { ItemsSource = contacts, ItemTemplate = personDataTemplate };
			//Content = new StackLayout
			//{
			//	Padding = new Thickness(10, 30, 10, 10),
			//	Spacing = 10,

			//	Children = { new Label { Text = " My Contacts ", HorizontalTextAlignment = TextAlignment.Center }, contactsList, new Button { Text = "Click Me" }}
			//};
		}

		async void OnButtonClicked(object sender, EventArgs args)
		{
			//Button button = (Button)sender;
			//button.Text = ContactList.SelectedItem.ToString();
			await DisplayAlert("ALERT", "You Pressed Me", "OK");
			//new NavigationPage(new AddContactView());
			await Navigation.PushAsync(new AddContactView());
		}
	}
}