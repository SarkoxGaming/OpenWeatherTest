using OpenWeatherAPI;
using System.ComponentModel;
using WeatherApp.Commands;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class WindDataViewModel : INotifyPropertyChanged
    {
        public IWindDataService WindDataService { get; set; }
        public DelegateCommand<string> GetDataCommand { get; set; }

        private WindDataModel currentData;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public WindDataModel CurrentData
        {
            get { return currentData; }
            set {
                currentData = value;
                NotifyPropertyChanged(nameof(CurrentData));
            }
        }


        public double KPHtoMPS(double kph) => kph * 1.0 / 36.0;
        public double MPStoKPH(double mps) => mps * 3.6;
        
        public WindDataViewModel()
        {
            GetDataCommand = new DelegateCommand<string>(getData);
        }

        public async void getData(string obj)
        { 


            OpenWeatherService ows = new OpenWeatherService(AppConfiguration.GetValue("Secrets:OWApiKey"));

            CurrentData = await ows.GetDataAsync();

           
            //StringData = string.Format("Latitute: {0} \nLongitude: {1} \nTimeZone: {2} \nTimeZoneOffSet: {3} \nTempérature: {4} \nDateTime: {5}", v.Latitude, v.Longitude, v.Timezone, v.TimezoneOffset, v.Current.Temperature, v.Current.DateTime);
        }

    }
}
