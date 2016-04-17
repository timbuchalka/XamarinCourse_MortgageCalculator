using System;
using MortgageCalculator_PCL;
using AppKit;
using Foundation;

namespace MortgageCalculator_Mac
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        partial void calculateButton_TouchUpInside (Foundation.NSObject sender)
        {
            float mortgageAmount = float.Parse(mortgageAmountTextField.Title);
            float interestRate = float.Parse(_mortgageInterestRateTextField.Title);
            int mortgageTerm = int.Parse(mortgageTermTextField.Title);

            monthlyPaymentLabel.StringValue = string.Format("{0:C}", Calculator.CalculateMonthlyPayment(mortgageAmount, interestRate, mortgageTerm));
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
