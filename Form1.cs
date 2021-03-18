using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Media;

namespace fsuae_launcher
{
    public partial class Form1 : Form
    {
        private FsuaeExec _execManager;
        private config _configFile;
        private SoundPlayer _bgmManager;

        public Form1()
        {
            InitializeComponent();
            _configFile = new config("fsuaeLauncherData/config.xml");
            foreach(profil p in _configFile.profilList) {
                profilList.Items.Add(p.name);
            }
            _execManager = new FsuaeExec(_configFile.fsuae);
            _bgmManager = new SoundPlayer(_configFile.bgm.loop);
            _bgmManager.PlayLooping();
            profilList.SetSelected(0, true);
            SetSelectedProfile(0);
            profilDesc.Select(0, 0);
            yosmontLink.Click += new EventHandler(OpenSocialLink);
            profilList.SelectedIndexChanged += new EventHandler(SelectedProfileChange);
            playButton.Click += new EventHandler(StartFsuae);
        }

        private void OpenUrl(string url)
        {
            try {
                Process.Start(url);
            } catch {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                } else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                    Process.Start("xdg-open", url);
                } else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
                    Process.Start("open", url);
                } else {
                    throw;
                }
            }
        }
        private void OpenSocialLink(object sender, EventArgs e)
        {
            OpenUrl("https://github.com/yosmont");
        }

        private void SelectedProfileChange(object sender, EventArgs e)
        {
            SetSelectedProfile(profilList.SelectedIndex);
        }

        private void SetSelectedProfile(int index)
        {
            profilDesc.Text = _configFile.profilList[index].desc;
            profilCover.BackgroundImage = (Image)(new Bitmap(_configFile.profilList[index].cover));
        }

        private void StartFsuae(object sender, EventArgs e)
        {
            if (_execManager.StartFsua(_configFile.profilList[profilList.SelectedIndex].fsuaeConf)) {
                _bgmManager.Stop();
                //_execManager.WaitFsuaStop();
                Application.Exit();
            }
        }
    }
}
