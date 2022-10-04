using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using static Xamarin.Essentials.Permissions;

namespace ListViewExample
{
    public class PersonTypeGroup: ObservableCollection<Person>
    {
        public string Grupo { get; private set; }

        public PersonTypeGroup(string letra)
            : base()
        {
            Grupo = letra;
        }

        public PersonTypeGroup(string letra, IEnumerable<Person> source)
        : base(source)
        {
            Grupo = letra;
        }
    }
}
