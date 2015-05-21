using Windows.Media.Capture;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WindowsAppAliseHome
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender,  RoutedEventArgs e) 
        {
            CameraCaptureUI capture = new CameraCaptureUI();
            capture.PhotoSettings.CroppedAspectRatio = new Size(16, 9);
                StorageFile file = await capture.CaptureFileAsync(CameraCaptureUIMode.Photo); 
            IRandomAccessStream filestream = await file.OpenAsync(FileAccessMode.Read); 
            BitmapImage img = new BitmapImage(); 
            img.SetSource(filestream); img_viewer.Source = img;

            CameraCaptureUI capture1 = new CameraCaptureUI();
            capture1.PhotoSettings.CroppedAspectRatio = new Size(16, 9);
            StorageFile file1 = await capture1.CaptureFileAsync(CameraCaptureUIMode.Photo);
            IRandomAccessStream filestream1 = await file1.OpenAsync(FileAccessMode.Read);
            BitmapImage img1 = new BitmapImage();
            img1.SetSource(filestream1); imgviewer1.Source = img1;

            CameraCaptureUI capture2 = new CameraCaptureUI();
            capture2.PhotoSettings.CroppedAspectRatio = new Size(16, 9);
            StorageFile file2 = await capture2.CaptureFileAsync(CameraCaptureUIMode.Photo);
            IRandomAccessStream filestream2 = await file2.OpenAsync(FileAccessMode.Read);
            BitmapImage img2 = new BitmapImage();
            img2.SetSource(filestream2); imgviewer2.Source = img2;

            CameraCaptureUI capture3 = new CameraCaptureUI();
            capture3.PhotoSettings.CroppedAspectRatio = new Size(16, 9);
            StorageFile file3 = await capture3.CaptureFileAsync(CameraCaptureUIMode.Photo);
            IRandomAccessStream filestream3 = await file3.OpenAsync(FileAccessMode.Read);
            BitmapImage img3 = new BitmapImage();
            img3.SetSource(filestream3); imgviewer3.Source = img3; 
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
