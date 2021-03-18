using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace fsuae_launcher
{
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
            loadProfilListConfig(reader);
        }

        private void loadBGMConfig(XmlReader reader)
        {
            reader.ReadToFollowing("BGM");
            reader.ReadToFollowing("intro");
            bgm.intro = reader.ReadElementContentAsString();
            reader.ReadToFollowing("loop");
            bgm.loop = reader.ReadElementContentAsString();
        }

        private void loadFSUAEConfig(XmlReader reader)
        {
            reader.ReadToFollowing("fsuae");
            reader.ReadToFollowing("installDir");
            fsuae.installDir = reader.ReadElementContentAsString();
            reader.ReadToFollowing("exec");
            fsuae.exec = reader.ReadElementContentAsString();
        }

        private void loadProfilListConfig(XmlReader reader)
        {
            reader.ReadToFollowing("profilConfig");
            profilList = new List<profil>();
            while (reader.ReadToFollowing("Item")) {
                profil tmp = new profil();
                reader.ReadToFollowing("ItemName");
                tmp.name = reader.ReadElementContentAsString();
                reader.ReadToFollowing("ItemDesc");
                tmp.desc = reader.ReadElementContentAsString();
                reader.ReadToFollowing("ItemCover");
                tmp.cover = reader.ReadElementContentAsString();
                reader.ReadToFollowing("ItemFsuaeConf");
                tmp.fsuaeConf = reader.ReadElementContentAsString();
                profilList.Add(tmp);
            }
        }
    }
}
