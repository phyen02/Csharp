using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using WPF_Multi_Task.Model;

namespace WPF_Multi_Task.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties
        private SettingData _SettingData;
        public SettingData SettingData { get => _SettingData; set { _SettingData = value; OnPropertyChanged(); } }

        private ObservableCollection<ProfileDetail> _Profiles;
        public ObservableCollection<ProfileDetail> Profiles
        {
            get => _Profiles;
            set
            {

                _Profiles = value;
                OnPropertyChanged();
            }
        }

        
        #endregion

        public MainViewModel() 
        {
            FirstLoad();
            LoadCommand();
        }

        #region CMD
        public ICommand AddData_CMD { get; set; }
        public ICommand PauseProfile_CMD { get; set; }
        public ICommand ResumeProfile_CMD { get; set; }
        public ICommand StartProfile_CMD { get; set; }
        public ICommand DeleteProfile_CMD { get; set; }
        public ICommand CreateProfile_CMD { get; set; }
        public ICommand StartAll_CMD { get; set; }
        public ICommand StopAll_CMD { get; set; }
        public ICommand StopProfile_CMD { get; set; }
        public ICommand DeleteAll_CMD { get; set; }
        public ICommand CloseAll_CMD { get; set; }
        
        #endregion

        #region Method
        void FirstLoad()
        {
            LoadSavedData();
        }

        void LoadCommand()
        {
            StopProfile_CMD = new RelayCommand<ProfileDetail>((p) => { return p != null && Profiles != null && Profiles.Contains(p); }, (p) => { StopProfile(p); });
            AddData_CMD = new RelayCommand<ProfileDetail>((p) => { return true; }, (p) => { Add500Row(); });
            PauseProfile_CMD = new RelayCommand<ProfileDetail>((p) => { return p != null && Profiles != null && Profiles.Contains(p); }, (p) => { PauseProfile(p); });
            ResumeProfile_CMD = new RelayCommand<ProfileDetail>((p) => { return p != null && Profiles != null && Profiles.Contains(p); }, (p) => { ResumeProfile(p); });
            StartProfile_CMD = new RelayCommand<ProfileDetail>((p) => { return p != null && Profiles != null && Profiles.Contains(p); }, (p) => { StartProfile(p); });
            DeleteProfile_CMD = new RelayCommand<ProfileDetail>((p) => { return p != null && Profiles != null && Profiles.Contains(p); }, async (p) =>{ StopProfile(p); await DeleteProfile(p);});
            CreateProfile_CMD = new RelayCommand<object>((p) => { return true; }, (p) => { CreateProfile(); });
            StartAll_CMD = new RelayCommand<ProfileDetail>((p) => { return Profiles != null; }, (p) => { StartAll(); });
            StopAll_CMD = new RelayCommand<ProfileDetail>((p) => { return Profiles != null; }, (p) => { StopAll(); });
            DeleteAll_CMD = new RelayCommand<ProfileDetail>((p) => { return Profiles != null; }, (p) => { DeleteAll(); });
            CloseAll_CMD = new RelayCommand<ProfileDetail>((p) => { return Profiles != null; }, (p) => { CloseAll(); });
        }

        void StopProfile(ProfileDetail p)
        {
            p.Status = "Being stop";
            p.StopTask();
            p.Status = "Stop";
        }

        async void PauseProfile(ProfileDetail p)
        {
            if (await p.PauseTask())
            {
                p.Status = "Paused";
            }
        }

        async void ResumeProfile(ProfileDetail p)
        {
            if (await p.ResumeTask())
            {
                p.Status = "Resumed";
            }
        }

        void CloseAll()
        {
            StartTask(() =>
            {
                foreach (var item in Profiles)
                {
                    StopProfile(item);
                    CloseDriver(item);
                }
            }, null, null);
        }

        void StartAll()
        {
            StartTask(() => {
                foreach (var item in Profiles)
                {
                    StartProfile(item);
                }
            }, null, null);
        }

        void DeleteAll()
        {
            StartTask(async() => {
                while (Profiles.Count > 0)
                {
                    var item = Profiles.First();
                    StopProfile(item);
                    await DeleteProfile(item);
                }
              
            }, null, null);
        }

        void StopAll()
        {
            StartTask(() => {
                foreach (var item in Profiles)
                {
                    StopProfile(item);
                }
            }, null, null);
        }

        void Add500Row()
        {
            StartTask(() => {
                for (int i = 0; i < SettingData.TotalData; i++)
                {
                    CreateProfile(i+"");
                }
            }, null, null);
        }

        void OpenDriver(ProfileDetail p)
        {
            CloseDriver(p);
            p.Driver = new ChromeDriver();
        }

        void CloseDriver(ProfileDetail p)
        {
            if (p.Driver != null)
            {
                try
                {
                    p.Driver.Quit();
                }
                catch
                {

                }
            }
        }
        
        void StartProfile(ProfileDetail p)
        {
            CancellationTokenSource sourceToken = new CancellationTokenSource();
            PauseTokenSource pauseToken = new PauseTokenSource();
            var ct = p.StartTask(async () =>
            {
                OpenDriver(p);
                p.Driver.Navigate().GoToUrl("https://howkteam.vn/");

                while (true)
                {
                    
                    p.Status = $"Working...{DateTime.Now.Second}";
                    
                    p.Driver.Navigate().GoToUrl("https://howkteam.vn/learn");
                    await Task.Delay(TimeSpan.FromSeconds(5));
                    try
                    {
                        sourceToken.Token.ThrowIfCancellationRequested();
                    }
                    catch
                    {
                        return;
                    }
                    await pauseToken.Token.PauseIfRequestedAsync();

                    p.Driver.Navigate().GoToUrl("https://howkteam.vn/question");
                    await Task.Delay(TimeSpan.FromSeconds(5));
                    try
                    {
                        sourceToken.Token.ThrowIfCancellationRequested();
                    }
                    catch
                    {
                        return;
                    }
                    await pauseToken.Token.PauseIfRequestedAsync();
                }              

            }, sourceToken, pauseToken);
        }

        async Task DeleteProfile(ProfileDetail p)
        {
            p.Status = $"Deleting Profile";
            await Application.Current.Dispatcher.InvokeAsync(new Action(() =>
            {
                p.Status = $"Removing";
                Profiles.Remove(p);
                UpdateProfileIndex();
            }));
        }

        void UpdateProfileIndex()
        {
            if (Profiles == null || Profiles.Count == 0)
            {
                return;
            }
            int i = 0;
            foreach (var item in Profiles)
            {
                item.Index = ++i;
            }
        }

        ProfileDetail CreateProfile(string profileName = null)
        {
            if(Profiles == null)
            {
                Profiles = new ObservableCollection<ProfileDetail>();
            }
            var profile = new ProfileDetail() { Name = profileName, Status = "Created" };
            Application.Current.Dispatcher.InvokeAsync(new Action(() =>
            {
                Profiles.Add(profile);
                UpdateProfileIndex();
            }));

            return profile;
        }

        void LoadSavedData()
        {
            try
            {
                var text = File.ReadAllText("Saved.txt");
                SettingData = JsonConvert.DeserializeObject<SettingData>(text);

            }
            catch
            {

            }

            if (SettingData == null)
            {
                SettingData = new SettingData();
                SettingData.TotalData = 100;
            }
        }

        public void SaveData()
        {
            try
            {
                File.WriteAllText("Saved.txt", JsonConvert.SerializeObject(SettingData));
            }
            catch { }
        }
        #endregion
    }
}