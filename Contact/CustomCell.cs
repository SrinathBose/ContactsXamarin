using System;
using Xamarin.Forms;

namespace Contact
{
	public class CustomCell : ViewCell
	{
		public CustomCell()
		{
			StackLayout cellWrapper = new StackLayout();
			StackLayout verticalLayout = new StackLayout();

			Label nameLabel = new Label();
			Label numberLabel = new Label();
			Label addressLabel = new Label();

			//set bindings
			nameLabel.SetBinding(Label.TextProperty, "Name");
			numberLabel.SetBinding(Label.TextProperty, "Number");
			addressLabel.SetBinding(Label.TextProperty, "Address");

			//Set properties for desired design
			cellWrapper.BackgroundColor = Color.FromHex("#123456");
			verticalLayout.Orientation = StackOrientation.Vertical;

			nameLabel.TextColor = Color.FromHex("#f35e20");
			nameLabel.FontSize = 20;
			nameLabel.Margin = new Thickness(20,0);

			numberLabel.TextColor = Color.FromHex("ffaa00");
			numberLabel.FontSize = 12;
			numberLabel.Margin = new Thickness(20,0);

			addressLabel.TextColor = Color.FromHex("65acd2");
			addressLabel.FontSize = 14;
			addressLabel.Margin = new Thickness(20,0);


			addressLabel.VerticalOptions = LayoutOptions.EndAndExpand;
			//add views to the view hierarchy
			verticalLayout.Children.Add(nameLabel);
			verticalLayout.Children.Add(numberLabel);
			verticalLayout.Children.Add(addressLabel);

			cellWrapper.Children.Add(verticalLayout);

			View = cellWrapper;
		}
	}
}
