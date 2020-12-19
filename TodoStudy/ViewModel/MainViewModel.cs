using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using TodoStudy.Models;

namespace TodoStudy.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        public MainViewModel()
        {
            MenuModels = new ObservableCollection<MenuModel>();
            menuModels.Add(new MenuModel() { IconFont = "\xe635", Title = "我的一天" });
            menuModels.Add(new MenuModel() { IconFont = "\xe6b6", Title = "重要" });
            menuModels.Add(new MenuModel() { IconFont = "\xe6e1", Title = "已计划日程" });
            menuModels.Add(new MenuModel() { IconFont = "\xe614", Title = "已分配给我" });
            menuModels.Add(new MenuModel() { IconFont = "\xe755", Title = "任务" });
        }

/*        private ObservableCollection<MenuModel> menuModels;

        public ObservableCollection<MenuModel> MenuModles
        {
            get { return menuModels; }
            set { menuModels = value;RaisePropertyChanged(); }
        }*/

        private ObservableCollection<MenuModel> menuModels;

        public ObservableCollection<MenuModel> MenuModels
        {
            get { return menuModels; }
            set { menuModels = value; RaisePropertyChanged(); }
        }

    }


}
