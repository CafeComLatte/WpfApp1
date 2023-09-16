using Common;
using Views.UI.Windows;

namespace Services
{
    public interface IDialogService
    {
        Views.UI.Windows.IDialog Dialog { get; }

        void SetSize (double width, double height);
        void SetVM (BaseViewModel vm, string title);
    }

    public class DialogService : IDialogService
    {
        private readonly IDialog _popWindow;

        public DialogService(IDialog popWindow)
        {
            _popWindow = popWindow;
            _popWindow.CloseCallback = () =>
            {
                if (_popWindow.DataContext is BaseViewModel vm)
                {
                    vm.Cleanup();
                    _popWindow.DataContext = null;
                }
            };
        }

        public IDialog Dialog => _popWindow;

        

        public void SetSize(double width, double height)
        {
            _popWindow.Width = width;
            _popWindow.Height = height;
        }

        public void SetVM(BaseViewModel vm, string title)
        {
            /*
            if(_popWindow.DataContext is PopViewModel viewModel)
            {
                _popWindow.Title = title;
                viewModel.PopupVM = vm;
            }
            */

            _popWindow.DataContext = vm;
            _popWindow.Title = title;


        }
    }
}
