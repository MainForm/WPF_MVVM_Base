using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MVVM_Base.Commands;

namespace WPF_MVVM_Base.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        // 버튼 클릭 횟수
        private int _count;

        public ICommand IncreaseCommand { get; }

        public MainViewModel()
        {
            IncreaseCommand = new RelayCommand(Increase, canIncrease);
        }

        // 버튼 클릭 이벤트 콜백
        private void Increase()
        {
            _count++;

            MessageBox.Show($"Count: {_count}");
        }

        // 버튼 클릭 가능 여부 체크 콜백
        private bool canIncrease()
        {
            // 버튼 클릭 횟수가 5 미만일 때만 버튼이 활성화되도록 설정
            return _count < 5;
        }
    }
}
