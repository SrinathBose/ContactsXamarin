using System;
using System.Collections.Generic;
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
	}
}
