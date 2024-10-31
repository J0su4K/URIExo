using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Packaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace URITrain
{
    public class ImageURL : ModelViewBase
    {
        DataAPI _api = new DataAPI();
        public RelayCommand GenerateImageCommand => new RelayCommand(GenerateImage);


          string url = @"https://picsum.photos/200";

        public  string URL
        {
            get 
            {
                return url; 
            }
            set 
            { 
                url = value; OnPropertyChanged(); 
            }
        }
        void GenerateImage(object _object)
        {
            _api.GetDataFromAPI(URL);
            MessageBox.Show("Nouvelle image generer !");
        }

    }
}
