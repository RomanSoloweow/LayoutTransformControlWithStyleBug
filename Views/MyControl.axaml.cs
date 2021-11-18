using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using LayoutTransformControlWithStyleBug.ViewModels;

namespace LayoutTransformControlWithStyleBug.Views
{
    public class MyControl : ReactiveUserControl<ViewModelBase>
    {
        #region IsRotatedProperty

        public static readonly AvaloniaProperty<bool> IsRotatedProperty =
            AvaloniaProperty.Register<MyControl, bool>(nameof(IsRotated));

        public bool IsRotated
        {
            get => this.GetValue<bool>(IsRotatedProperty);
            set => SetValue(IsRotatedProperty, value);
        }

        #endregion IsRotatedProperty
        public MyControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}