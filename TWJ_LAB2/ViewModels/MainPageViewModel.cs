using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Input;
using TWJ_LAB2.Models;
using Microsoft.Maui.Controls;

namespace TWJ_LAB2.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        // 公开 Model 实例，View 将绑定到其属性
        public PetDetails PetDetails { get; }

        // 用于按钮交互的命令 (ICommand)
        public ICommand FavoriteCommand { get; }
        public ICommand AdoptCommand { get; }

        // 示例：一个动态属性，用于演示数据绑定
        private string _adoptionButtonText = "Adoption";
        public string AdoptionButtonText
        {
            get => _adoptionButtonText;
            set => SetProperty(ref _adoptionButtonText, value);
        }

        public MainPageViewModel()
        {
            PetDetails = new PetDetails();

            // 初始化命令并指向对应的逻辑方法
            FavoriteCommand = new Command(OnFavoriteClicked);
            AdoptCommand = new Command(OnAdoptClicked);
        }

        private void OnFavoriteClicked()
        {
            // 心形按钮的逻辑
            App.Current.MainPage.DisplayAlert("操作", "Robin Hood has been added to favorites! ♥", "OK");
        }

        private void OnAdoptClicked()
        {
            // 领养按钮的逻辑
            App.Current.MainPage.DisplayAlert("操作", "The adopt button has been clicked!", "OK");
            // 更新按钮文本以演示 MVVM 属性更新
            AdoptionButtonText = "Request sent!";
        }
    }
}
