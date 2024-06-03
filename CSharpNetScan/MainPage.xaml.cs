using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CSharpNetScan
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			entry.TextChanged += OnEntryTextChanged;
			entry.Completed += OnEntryTextEntered;

		}

		private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
		{
			string EnteredText = e.NewTextValue;
			lbl_Input.Text = EnteredText;
			Console.WriteLine(EnteredText);
		}


		private void OnEntryTextEntered(object sender, EventArgs e)
		{
			string uriString = entry.Text;
                        Uri myUri = new Uri(uriString);
			lbl_Input.Text = "https://metanit.com/";
			Console.WriteLine(myUri);
		}
	}
}
