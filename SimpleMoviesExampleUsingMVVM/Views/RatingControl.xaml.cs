using System;
using System.Windows;
using System.Windows.Controls;

namespace SimpleMoviesExampleUsingMVVM.Views
{
    /// <summary>
    /// Lógica de interacción para RatingControl.xaml
    /// </summary>
    public partial class RatingControl : UserControl
    {
        private static double _startSize = 14;

        public RatingControl()
        {
            InitializeComponent();
        }


        //Propiedad de dependencia
        public static readonly DependencyProperty RatingValueProperty =
            DependencyProperty.Register("RatingValue", typeof(Double), typeof(RatingControl),
                new FrameworkPropertyMetadata((Double)0,
                    new PropertyChangedCallback(OnValorChanged)));

        //Propiedad
        public Double RatingValue
        {
            get { return (Double)GetValue(RatingValueProperty); }
            set { SetValue(RatingValueProperty, value); }
        }

        //Metodo que se lanza cuando cambia la propiedad
        private static void OnValorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            RatingControl ratingControl = (RatingControl)d;

            ratingControl.mask.Margin = new Thickness(_startSize * (ratingControl.RatingValue / 2), 0, 0, 0);

        }
    }
}
