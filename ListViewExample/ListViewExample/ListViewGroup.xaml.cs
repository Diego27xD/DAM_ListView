using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<PersonTypeGroup> PersonList { get; set; } = new ObservableCollection<PersonTypeGroup>();

        public ListViewGroup()
        {
            InitializeComponent();

            PersonList.Add(new PersonTypeGroup("A", new[] {
                new Person{nombre = "Ariel", apellido = "Flores", edad = 20, genero = "M"},
                new Person{nombre="Alvaro", apellido = "Fernandez", edad = 21, genero = "M"},
                new Person{nombre="Alejandra",apellido = "Quinto",edad = 22,genero = "F"}
            }));

            PersonList.Add(new PersonTypeGroup("B", new[] {
                new Person{nombre = "Bartola", apellido = "Alvarez",edad = 19,genero = "F"},
                new Person{nombre="Benito",apellido = "Suarez",edad = 18,genero = "M"},
                new Person{nombre="Bruno",apellido = "Arias",edad =22,genero = "M"}
            }));

            PersonList.Add(new PersonTypeGroup("C", new[] {
                new Person{nombre="Carlos",apellido = "Bartolomè",edad = 20,genero = "M"},
                new Person{nombre="Casandra",apellido = "Velasquez",edad = 21,genero = "F"},
                new Person{nombre="Camilo",apellido = "Velo",edad = 22,genero = "M"}
            }));

            PersonList.Add(new PersonTypeGroup("D", new[] {
                new Person{nombre="Diego",apellido = "Flores",edad = 20,genero = "M"},
                new Person{nombre="Diana",apellido = "Alvarez",edad = 21,genero = "F"},
                new Person{nombre="Donna",apellido = "Antara",edad = 22,genero = "F"}
            }));

            ListaPersonas.ItemsSource = PersonList;
        }
    }
}