using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;

namespace fsuae_launcher
{
    class FsuaeExec
    {
        private FSUAE _config;
        private Process _fsuaeProcess;

        public FsuaeExec(FSUAE fsuaConfig)
        {
            _config = fsuaConfig;
        }

        public bool StartFsua(string configPath)
        {
            _fsuaeProcess = new Process();
            _fsuaeProcess.StartInfo.UseShellExecute = false;
            _fsuaeProcess.StartInfo.FileName = _config.exec;
            _fsuaeProcess.StartInfo.Arguments = Path.GetFullPath(configPath);
            Directory.SetCurrentDirectory(_config.installDir);
            _fsuaeProcess.Start();
            return true;
        }

        public bool WaitFsuaStop()
        {
            _fsuaeProcess.WaitForExit();
            return true;
        }
    }

}
