using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WK.Libraries.BetterFolderBrowserNS;

namespace ArkMedal
{
    public partial class FormMain : Form
    {
        string workdir, spritepath, defpath;
        BindingList<MedalPng> arr_medal;
        JObject defjson;

        public FormMain()
        {
            InitializeComponent();
            workdir = Application.StartupPath; 
            spritepath = workdir + "/Sprite/";
            defpath = workdir + "/MonoBehaviour";
            arr_medal = new BindingList<MedalPng>();
            lstFiles.DataSource = arr_medal;
            lstFiles.DisplayMember = "File";
            lstErr.Items.Clear();
            btnSave.Enabled = false;
        }

        public void ChangeWorkDir(string newdir)
        {
            workdir = newdir;
            spritepath = workdir + "/Sprite/";
            defpath = workdir + "/MonoBehaviour";
        }

        public Bitmap JoinBitmap(Bitmap back, Bitmap front, float x, float y)
        {
            float bh = back.Height;
            float fh = front.Height;
            float fw = front.Width;
            using (Graphics g = Graphics.FromImage(back))
            {
                g.DrawImage(front, new PointF(x - fw/2, bh - fh/2 - y));
            }
            return back;
        }

        public JObject ReadJsonFile(string path)
        {
            using (StreamReader file = File.OpenText(path))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o = (JObject)JToken.ReadFrom(reader);
                    return o;
                }
            }
        }

        public void HandleDef(JObject def)
        {
            StatusLabel1.Text = "读取定义文件...";

            string bkgname = def["_groupId"].ToString() + ".png";
            textBox1.Text = def["_groupId"].ToString();

            arr_medal.Clear();
            arr_medal.Add(new MedalPng(bkgname, bkgname, -1, -1));
            foreach (JObject imedal in def["_medalPosList"])
            {
                string sourcename = imedal["medalId"].ToString();
                string pngname = sourcename + ".png";
                string pngname_dc = sourcename + "5.png";
                if (!File.Exists(spritepath + pngname_dc))
                    pngname_dc = pngname;
                double pngx = Convert.ToDouble(imedal["pos"]["x"].ToString());
                double pngy = Convert.ToDouble(imedal["pos"]["y"].ToString());
                arr_medal.Add(new MedalPng(pngname, pngname_dc, pngx, pngy));
            }
            RenderImg();
        }

        public void RenderImg()
        {
            StatusLabel1.Text = "合成图像...";
            lstErr.Items.Clear();
            int errcount = 0;
            Bitmap bkgimg;
            try
            {
                bkgimg = new Bitmap(new Bitmap(spritepath + arr_medal[0].File), 1374, 459);
            }
            catch
            {
                bkgimg = new Bitmap(1374, 459);
                lstErr.Items.Add("\"" + arr_medal[0].File + "\"未找到");
                errcount++;
            }
            foreach (MedalPng medal in arr_medal)
            {
                if (medal.PosX < 0) continue;
                string imgname = chkDC.Checked ? medal.File_dc : medal.File;
                try
                {
                    Bitmap medalimg = new Bitmap(spritepath + imgname);
                    bkgimg = JoinBitmap(bkgimg, medalimg, medal.PosX, medal.PosY);
                }
                catch
                {
                    lstErr.Items.Add("\"" + imgname + "\"未找到");
                    errcount++;
                }
            }
            pictureBox1.Image = bkgimg;
            //bkgimg.Dispose();
            StatusLabel1.Text = "就绪";
            btnSave.Enabled = !(errcount == arr_medal.Count());
        }

        public void SearchDefFile()
        {
            label1.Text = workdir;
            Text = "ArkMedal - " + workdir;

            StatusLabel1.Text = "扫描定义文件...";

            lstDef.Items.Clear();
            arr_medal.Clear();
            pictureBox1.Image = null;
            textBox1.Text = "";

            DirectoryInfo di = new DirectoryInfo(defpath);
            FileInfo[] files;
            try
            {
                files = di.GetFiles("*.json");
                foreach (FileInfo fi in files)
                {
                    lstDef.Items.Add(fi.Name);
                }
                StatusLabel1.Text = "就绪";
            }
            catch
            {
                //throw e;
                btnSave.Enabled = false;
                StatusLabel1.Text = "工作目录不完整";
            }

        }

        private void chkDC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDC.Checked)
                lstFiles.DisplayMember = "File_dc";
            else
                lstFiles.DisplayMember = "File";

            RenderImg();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SearchDefFile();
        }

        private void btnRefreshDef_Click(object sender, EventArgs e)
        {
            SearchDefFile();
        }

        private void btnRefreshPng_Click(object sender, EventArgs e)
        {
            HandleDef(defjson);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            bfb.RootFolder = workdir;
            DialogResult dr = bfb.ShowDialog();
            string dirname = bfb.SelectedPath;
            if (dr==DialogResult.OK && !String.IsNullOrEmpty(dirname))
            {
                ChangeWorkDir(dirname);
                SearchDefFile();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string savename = "蚀刻章套组 " + textBox1.Text;
            if (chkDC.Checked)
                savename += " 镀层";
            savename += ".jpg";
            sfd.FileName = savename;
            sfd.Filter = "JPEG图像(*.jpg;*.jpeg)|*.jpg;*.jpeg";
            DialogResult dr = sfd.ShowDialog();
            string filename = sfd.FileName;
            if (dr == DialogResult.OK && !String.IsNullOrEmpty(filename))
            {
                StatusLabel1.Text = "正在保存...";
                Bitmap pic = (Bitmap)pictureBox1.Image;
                pic.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                StatusLabel1.Text = "保存成功！";
                pic.Dispose();
            }

        }



        private void lstDef_SelectedIndexChanged(object sender, EventArgs e)
        {
            string defFile = defpath + "/" +  lstDef.SelectedItem.ToString();
            defjson = ReadJsonFile(defFile);
            HandleDef(defjson);
        }
    }
}
