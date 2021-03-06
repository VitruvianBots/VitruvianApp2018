﻿using System;
using Xamarin.Forms;
using Plugin.DeviceInfo;

namespace VitruvianApp2017
{
	public static class GlobalVariables {
		// Modifiable per competition/year
		public static string regionalPointer { get; set; } = "NULL";
		//public static string firebaseApplicationID = "1:222280551868:android:051a820459657e45\n";
		//public static string firebaseAPIKey = "AIzaSyDeNEa_Dgr7AfDfUyBWX6D5Le80H9t26es";
		public static string firebaseURL = "https://vitruvianapp.firebaseio.com/";
		public static string firebaseStorageURL = "vitruvianapp.appspot.com";
		public static string TBAAuthKey = "1SFLd7tZRlgJ4rR39wiLuylzMbAfdyJBgoGg1wdYBQ2qrZ9BTZpefWO1Cf15unOG";

		// Don't modify these
		public static double sizeTitle = Device.GetNamedSize(NamedSize.Large, typeof(Label)) * 1.5;
		public static double sizeMedium = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) * 1.5;
		public static double sizeSmall = Device.GetNamedSize(NamedSize.Small, typeof(Label)) * 1.5;
		public static double sizeTiny = Device.GetNamedSize(NamedSize.Small, typeof(Label));

		public static int screenHieght = CrossDevice.Hardware.ScreenHeight;
		public static int screenWidth = CrossDevice.Hardware.ScreenWidth;
		public static Thickness popupMargin = new Thickness((double)screenHieght * 0.025, (double)screenWidth * 0.025);
		//public static Page rootPage { get; set; }

		//public static string [] parseStrings = { };
	}
}
