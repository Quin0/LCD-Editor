using Caliburn.Micro;
using EditorLCD.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace EditorLCD
{
    internal class HelloBootstrapper : BootstrapperBase
    {
        public HelloBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}
