using Xamarin.Forms;
using MySpectrumApp.Behaviors;

namespace MySpectrumApp.ViewModels
{
    public class BitcoinViewSource : ContentPage
	{
		public BitcoinViewSource()
		{
			Title = "Numeric";
			IconImageSource = "csharp.png";

			var entry = new Entry { Placeholder = "Enter Numeric Numbers Only" };
			entry.Behaviors.Add(new MySpectrumBehaviors());

			Content = new StackLayout
			{
				Padding = new Thickness(5, 50, 5, 0),
				Children = {
					new Label {
						Text = "Enter BitChain Account Number (Numeric Only)",
						FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label))
					},
					entry
				}
			};
		}
	}
}
