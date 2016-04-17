// WARNING
//
// This file has been generated automatically by Xamarin Studio Business to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MortgageCalculator_Mac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextFieldCell _mortgageInterestRateTextField { get; set; }

		[Outlet]
		AppKit.NSTextField monthlyPaymentLabel { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell mortgageAmountTextField { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell mortgageTermTextField { get; set; }

		[Action ("calculateButton_TouchUpInside:")]
		partial void calculateButton_TouchUpInside (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (_mortgageInterestRateTextField != null) {
				_mortgageInterestRateTextField.Dispose ();
				_mortgageInterestRateTextField = null;
			}

			if (mortgageTermTextField != null) {
				mortgageTermTextField.Dispose ();
				mortgageTermTextField = null;
			}

			if (monthlyPaymentLabel != null) {
				monthlyPaymentLabel.Dispose ();
				monthlyPaymentLabel = null;
			}

			if (mortgageAmountTextField != null) {
				mortgageAmountTextField.Dispose ();
				mortgageAmountTextField = null;
			}
		}
	}
}
