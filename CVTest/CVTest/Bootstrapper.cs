using Caliburn.Micro;
using CVTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CVTest
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //Log.Instance.Debug("We're going to start ShellViewModel");
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
