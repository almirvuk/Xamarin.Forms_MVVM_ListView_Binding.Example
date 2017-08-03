## Xamarin.Forms: ListView Simple MVVM Binding Example
Continuing this series of simple MVVM bindings in Xamarin.Forms. In this tutorial I will make simple ListView binding in XAML.  

Run your Visual Studio and create new Xamarin.Forms project, add Views, Models and ViewModels folders.  

This will be simple one page app with ListView as a main control on the page/view and we will demonstrate how to make simple MVVM binding in ListView.  

Scenario for this demo is: At constructor of ViewModel we will set some default values, and after couple of seconds using web services we will "grab" some other data and store (update) it in our list, and all of this will be inside of our view model with zero of code in code-behind file of our view/page.  

For this example I will use Xamari.Forms PCL for Core of the App.  

And for hosting simple api for my http get calls I will use free service called http://myjson.com/ it is very nice and handy for tutorials or small testings.  

This is how my project structure looks like for now:  

![](https://3.bp.blogspot.com/-sMRjXYZWa3E/WLBEvWpaENI/AAAAAAAACH8/lU9D9-ERyTMsuD0EBEyQJO3pEvXAF8apQCLcB/s1600/first_mvvm.png)  

In Models folder now I will add simple class "Car" with three properties: CarID, Make and YearofModel.  

... and it looks like this:  https://gist.github.com/almirvuk/2e04d28a6dfc62903cbc315532068483

Now I will add my page called CarsPage inside of Views folder, like this: 
https://gist.github.com/almirvuk/8b3da18252ee7bd1eaf9e5facf9121c5

As you can see we have very simple page with list view in it, list view has ItemTemplate and DataTemplate in side of it. ListView controls is binding to Items of type ObservableCollection <cars>and the data in side of list view will be binding to the properties of the class Car to the two properties Make and YearOfModel. If this is little confusing for you I suggest you to take a look at my early tutorials about bindings and hope that will be helpful for you.</cars>  

Now when we have this page we need a view model which we will make logic for updating the list data and we need view model in order to follow MVVM rules in our app.  

Maybe in future I will make my own blog post about why to use MVVM and for now I suggest you to take a look at this great answers on Stack Overflow. [Why use MVVM?](http://stackoverflow.com/questions/2653096/why-use-mvvm)  

.. Now lets create that view model called CarsViewModel.cs and it looks like this: 
https://gist.github.com/almirvuk/a6f227fbbf40524ec65d75f118427eec

If this code is confusing for you **I strongly recommend** you to take a look at my blog post: **[Xamarin.Forms Simple MVVM Binding Example](https://almirvuk.blogspot.ba/2016/12/xamarinforms-simple-mvvm-binding-example.html)**  

In that blog post I am explaining the INotifyPropertyChanged and OnPropertyChanged in more detail way.  

But I will now write couple of word here: INotifyPropertyChanged is interface which this view model class will implement and it have OnPropertyChanged  method which we will be calling on the spots where we are updating the data and OnPropertyChanged method will be changing the value of our controls with zero of code in the code behind classes.  

Now when we have this view model (in which we will add couple of lines of code later), we need to connect with our page and we can do that in the CarPage.xaml.cs like this (at line 19.) :  https://gist.github.com/almirvuk/b7722aa296c5bff594741fb19231cee4

Now we can run our app and hopefully we will have list of two cars displayed. (Also do not forget to set in your App.xaml.cs: main page to be: MainPage = new CarsExample.Views.CarsPage(); or navigate to the CarsPage as you want.)  

Here is our app and how CarsPage looks like:  

![](https://2.bp.blogspot.com/-TczKisN7ftg/WLBT2zpMOiI/AAAAAAAACIs/6UP4RvsJcekwQtNm363vRF4WHxG1IdpygCLcB/s1600/fourht_mvvm.png)  

For now this is a result that we want to accomplish, now we want to update automatically the data in the list and that will be very easy using MVVM and OnPropertyChanged Method.  

In the Utils folder I will add the class called MyHTTP and this will be my helper class for calling the web service to get data that will be in the list after update. So add that class and it looks something like this:  

Maybe this approach will be strange for you but this is a way that I like to use async methods:  https://gist.github.com/almirvuk/d7e260a790716b80d6835aad50734849

If you have any issue with HTTPClient you can solve this by adding Microsoft.Net.Http nuget package in your project PCL.  

After this we need to make API Call in the our view model class like this: (from line 47\. to 53.)  https://gist.github.com/almirvuk/0c718bec3c7e833a9deb8593850078d6

If everything is OK, now we can run our app, and result need to be that we have our list view with two default values and after couple of seconds (to make api call and deserialize data) we will have updated list with new values. (Do not forget to turn on wi fi on your device.)  

I will make a gif demo for this app, so you can see here how it will look like when you run it on your pc and device.  

As you can see on the gif down bellow there is a list of default values after couple of seconds list is updated and all that from our view model with minimum of lines of code at the code-behind.  

Demo:  

![](https://2.bp.blogspot.com/-hoVNB9EIw2I/WLBd0nIpL9I/AAAAAAAACJI/JpuBbjiKgCABULNAHDQj_AKGqnHIZXs5QCLcB/s1600/Untitled1.gif)  

As always demo code will be on the my GitHub, here at this this url.  

Hope that this tutorial was helpful for you in your process of development or learning Xamarin.Forms, if it is share it with your colleagues and good luck with development.  

Best regards!
