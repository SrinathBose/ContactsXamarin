using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using Newtonsoft.Json;


namespace Contact
{
	public partial class AddContactView : ContentPage
	{
		public AddContactView()
		{
			this.LoadFromXaml(typeof(AddContactView));

			InitializeComponent();
		}

		void OnAddContactButtonClicked(object sender, EventArgs args)
		{
			DependencyService.Get<IContactPreferences>().SaveContactToPreferences(new Person(
				nameEntry.Text.ToString(),
				Convert.ToInt64(numberEntry.Text.ToString()),
				addressEntry.Text.ToString()), "person5");
		}
	}
}
