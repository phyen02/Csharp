using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Multi_Task.ViewModel;

namespace WPF_Multi_Task.Model
{
    public class SettingData : BaseViewModel
    {
        private int _TotalData;
        public int TotalData
        {
            get => _TotalData;
            set
            {

                _TotalData = value;
                OnPropertyChanged();
            }
        }
    }
}
