using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace fsuae_launcher
{
    static class configPathConst
    {
        public const string bgmDir = "fsuaeLauncherData/bgm/";
        public const string profilDir = "fsuaeLauncherData/profil/";
    }

    public struct BGM
    {
        public string intro;
        public string loop;
    }

    public struct FSUAE
    {
        public string installDir;
        public string exec;
    }

    public struct profil
    {
        public string name;
        public string desc;
        public string cover;
        public string fsuaeConf;
    }

    class config
    {
        public BGM bgm;
        public FSUAE fsuae;
        public List<profil> profilList;

        public config(string configFilepath)
        {
            XmlReader reader = XmlReader.Create(configFilepath);
            loadBGMConfig(reader);
            loadFSUAEConfig(reader);
            loadProfilListConfig();
        }

        private void loadBGMConfig(XmlReader reader)
        {
            reader.ReadToFollowing("BGM");
            //reader.ReadToFollowing("intro");
            bgm.intro = /*configPathConst.bgmDir + reader.ReadElementContentAsString()*/ "";
            reader.ReadToFollowing("loop");
            bgm.loop = configPathConst.bgmDir + reader.ReadElementContentAsString();
        }

        private void loadFSUAEConfig(XmlReader reader)
        {
            reader.ReadToFollowing("fsuae");
            reader.ReadToFollowing("installDir");
            fsuae.installDir = reader.ReadElementContentAsString();
            reader.ReadToFollowing("exec");
            fsuae.exec = reader.ReadElementContentAsString();
        }

        private void loadProfilListConfig()
        {
            profilList = new List<profil>();
            string[] profilFileList = Directory.GetFiles(configPathConst.profilDir);
            foreach (string filepath in profilFileList) {
                if (Path.GetExtension(filepath) == ".xml") {
                    XmlReader reader = XmlReader.Create(filepath);
                    profil tmp = new profil();
                    reader.ReadToFollowing("Name");
                    tmp.name = reader.ReadElementContentAsString();
                    reader.ReadToFollowing("Desc");
                    tmp.desc = reader.ReadElementContentAsString();
                    reader.ReadToFollowing("Cover");
                    tmp.cover = configPathConst.profilDir + reader.ReadElementContentAsString();
                    reader.ReadToFollowing("FsuaeConf");
                    tmp.fsuaeConf = configPathConst.profilDir + reader.ReadElementContentAsString();
                    profilList.Add(tmp);
                }
            }
        }
    }
}
