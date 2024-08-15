using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace calculatorPractice.AttachedProperties
{
    public static class HighLightAttachedProperty
    {
        public static readonly DependencyProperty IsHighLightedProperty = DependencyProperty.RegisterAttached(
            "IsHighlighted", typeof(bool), typeof(HighLightAttachedProperty), new PropertyMetadata(false, OnIsHighlightedChanged));
        public static bool GetIsHighlighted(UIElement element) => (bool)element.GetValue(IsHighLightedProperty);
        public static void SetIsHighlighted(UIElement element, bool value) => element.SetValue(IsHighLightedProperty, value);

        private static void OnIsHighlightedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Control control)
            {
                control.Background = (bool)e.NewValue ? Brushes.Yellow : Brushes.Transparent;
            }
        }
    }
}
