using TWJ_LAB2.ViewModels;

namespace TWJ_LAB2.Views
{
    public partial class MainPage : ContentPage
    {
        // 通过构造函数注入接收 ViewModel
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            // 将 ViewModel 实例设置为页面的数据上下文
            BindingContext = viewModel;
        }

        // 移除原有的 OnCounterClicked 方法，因为所有逻辑已移至 ViewModel
        // 此时 Code-behind 中不应再有任何 UI 逻辑或事件处理方法
    }
}