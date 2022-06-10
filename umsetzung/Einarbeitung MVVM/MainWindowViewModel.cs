using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einarbeitung_MVVM
{
    public class MainWindowViewModel
    {
        public Person Person { get; }

        public MainWindowViewModel()
        {
            Person = new Person()
            {
                Vorname = "Lian",
                Nachname = "Studer",
                Alter = 16
            };
        }
    }
}
