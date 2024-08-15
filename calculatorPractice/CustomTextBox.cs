using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace calculatorPractice.CustomControls
{
    public class CustomTextBox : TextBox
    {
        public static readonly DependencyProperty HighLightProperty = DependencyProperty.Register(
            "HighLight", typeof(bool), typeof(CustomTextBox), new PropertyMetadata(false, OnIsHighLightedChanged) );
        public bool HighLight
        {
            get=>(bool)GetValue(HighLightProperty); set => SetValue(HighLightProperty, value);
        }
        private static void OnIsHighLightedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is Control control)
            {
                control.Background = (bool)e.NewValue ? Brushes.Yellow : Brushes.Transparent;
            }
        }
    }
}
