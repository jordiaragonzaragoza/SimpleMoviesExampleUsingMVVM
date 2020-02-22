using System;
using System.Windows;

namespace SimpleMoviesExampleUsingMVVM.Views
{
    public partial class RatingControl
    {
        private static double _startSize = 14;

        public RatingControl()
        {
            InitializeComponent();
        }
        
        public static readonly DependencyProperty RatingValueProperty =
            DependencyProperty.Register("RatingValue", typeof(Double), typeof(RatingControl),
                new FrameworkPropertyMetadata((Double)0,
                    new PropertyChangedCallback(OnRatingChanged)));

        public Double RatingValue
        {
            get { return (Double)GetValue(RatingValueProperty); }
            set { SetValue(RatingValueProperty, value); }
        }

        private static void OnRatingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var ratingControl = (RatingControl)d;
            ratingControl.mask.Margin = new Thickness(_startSize * (ratingControl.RatingValue / 2), 0, 0, 0);

        }
    }
}
