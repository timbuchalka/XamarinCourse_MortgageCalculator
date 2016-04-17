using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MortgageCalculator_PCL;

namespace MortgageCalculator_Android
{
    [Activity(Label = "MortgageCalculator_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        EditText mortgageAmountEditText, interestRateEditText, mortgageTermEditText;
        TextView monthlyPaymentTextView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.calculateButton);
            mortgageAmountEditText = FindViewById<EditText>(Resource.Id.mortgageAmountEditText);
            interestRateEditText = FindViewById<EditText>(Resource.Id.interestRateEditText);
            mortgageTermEditText = FindViewById<EditText>(Resource.Id.mortgageTermEditText);
            monthlyPaymentTextView = FindViewById<TextView>(Resource.Id.monthlyPaymentTextView);

            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            float mortgageAmount = float.Parse(mortgageAmountEditText.Text);
            float interestRate = float.Parse(interestRateEditText.Text);
            int term = int.Parse(mortgageTermEditText.Text);

            monthlyPaymentTextView.Text = $"{Calculator.CalculateMonthlyPayment(mortgageAmount, interestRate, term):C}";
        }
    }
}

