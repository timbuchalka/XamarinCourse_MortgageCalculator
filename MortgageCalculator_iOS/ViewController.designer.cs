// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MortgageCalculator_iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton calculateButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel montlhyPaymentLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField mortgageAmoutTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField mortgageInterestRateTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField mortgageTermTextField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (calculateButton != null) {
				calculateButton.Dispose ();
				calculateButton = null;
			}
			if (montlhyPaymentLabel != null) {
				montlhyPaymentLabel.Dispose ();
				montlhyPaymentLabel = null;
			}
			if (mortgageAmoutTextField != null) {
				mortgageAmoutTextField.Dispose ();
				mortgageAmoutTextField = null;
			}
			if (mortgageInterestRateTextField != null) {
				mortgageInterestRateTextField.Dispose ();
				mortgageInterestRateTextField = null;
			}
			if (mortgageTermTextField != null) {
				mortgageTermTextField.Dispose ();
				mortgageTermTextField = null;
			}
		}
	}
}
