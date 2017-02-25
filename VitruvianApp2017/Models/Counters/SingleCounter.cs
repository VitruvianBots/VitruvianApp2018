﻿using System;
using Xamarin.Forms;

namespace VitruvianApp2017
{
	public class SingleCounter:Grid
	{
		public event PropertyChangingEventHandler ValueChanged;
		int i;
		public int lowerLimit = 0;
		public int upperLimit = 9001;

		public SingleCounter(String title): this(title, 0){

		}

		public SingleCounter(String title, int counter)
		{
			lowerLimit = counter;
			i = counter;

			var titleLbl = new Label()
			{
				Text = title,
				TextColor = Color.Black,
				FontAttributes = FontAttributes.Bold,
				FontSize = GlobalVariables.sizeMedium,
				HorizontalTextAlignment = TextAlignment.Center
			};

			var valueLbl = new Label()
			{
				Text = i.ToString(),
				HorizontalTextAlignment = TextAlignment.Center
			};

			var decrement = new Button()
			{
				Text = "-",
				BackgroundColor = Color.Red,
			};
			decrement.Clicked += (object sender, EventArgs e) =>
			{
				if (i > lowerLimit)
				{
					i--;
					valueLbl.Text = i.ToString();
					this.OnPropertyChanged();
				}
			};

			var increment = new Button()
			{
				Text = "+",
				BackgroundColor = Color.Green,
			};
			increment.Clicked += (object sender, EventArgs e) =>
			{
				if (i < upperLimit) {
					i++;
					valueLbl.Text = i.ToString();
					this.OnPropertyChanged();
				}
			};

			this.Children.Add(titleLbl, 0, 3, 0, 1);
			this.Children.Add(decrement, 0, 1);
			this.Children.Add(valueLbl, 1, 1);
			this.Children.Add(increment, 2, 1);
		}

		public int value()
		{
			return i;
		}

		protected void OnValueChanged(string i) {
			PropertyChangingEventHandler c = this.ValueChanged;

			if (c != null) {
				c(this, new PropertyChangingEventArgs(i));
			}
		}
	}
}
