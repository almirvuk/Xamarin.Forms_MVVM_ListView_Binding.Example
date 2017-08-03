using CarsExample.Models;
using CarsExample.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CarsExample.ViewModels {

    public class CarsViewModel {

        // We are using ObservableCollection because:
        // When an object is added to or removed from an observable collection, the UI is automatically updated.
        private ObservableCollection<Car> items;
        public ObservableCollection<Car> Items {
            get { return items; }
            set {
                items = value;
            }
        }

        public CarsViewModel() {

            // Here you can have your data form db or something else,
            // some data that you already have to put in the list
            Items = new ObservableCollection<Car>() {
                new Car()
                {
                    CarID = 1,
                    Make = "Tesla Model S",
                    YearOfModel = 2015
                },
                  new Car()
                {
                    CarID = 2,
                    Make = "Audi R8",
                    YearOfModel = 2012
                },

            };

            // Web service call to update list with new values
            MyHTTP.GetAllNewsAsync(list =>
            {
                foreach (Car item in list)
                    Items.Add(item);
            });
        }
    }
}