using System;
using MortgageCalculator_PCL;
using UIKit;

namespace MortgageCalculator_iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            calculateButton.TouchUpInside += CalculateButton_TouchUpInside;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        void CalculateButton_TouchUpInside (object sender, EventArgs e)
        {
            float mortgageAmount = float.Parse(mortgageAmoutTextField.Text);
            float interestRate = float.Parse(mortgageInterestRateTextField.Text);
            int mortgageTerm = int.Parse(mortgageTermTextField.Text);

            montlhyPaymentLabel.Text = $"{Calculator.CalculateMonthlyPayment(mortgageAmount, interestRate, mortgageTerm):C}";
        }
    }
}