using CommonLibrary;
using Prism.Commands;

namespace DataGridAbout
{
    internal class MainViewModel
    {
        public DelegateCommand ClickCommand { get; set; } = new DelegateCommand(() =>
        {
            ;
        });

        public List<FakeModel> FakeModels { get; set; } = new List<FakeModel>()
        {
            new FakeModel() {
                        Age = 1,
                        Name = "Foo",
                        Email = "203232@qq.com"
        },

                     new FakeModel() {
                     Age = 2,
                     Name = "CC",
                     Email = "uids@outlook.com"
                    }
        };
    }
}