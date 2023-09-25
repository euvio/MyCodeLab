using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 绑定失败案例分析
{
    internal class MainWindowViewModel:BindableBase
    {
        private string title = "Hello";

        public string Title { get => title; set
            {
                title = value;
                RaisePropertyChanged(nameof(Title));
            }
        }

        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>() { "1", "2", "3" };
    }
}
