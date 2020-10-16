using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkMedal
{
    public class MedalPng
    {
        string mfile, mfile_dc;
        float mx, my;
        public MedalPng(string file, string file_dc, double x, double y)
        {
            this.mfile = file;
            this.mfile_dc = file_dc;
            this.mx = (float)x;
            this.my = (float)y;
        }
        public string File
        {
            get
            {
                return mfile;
            }
        }
        public string File_dc
        {
            get
            {
                return mfile_dc;
            }
        }
        public float PosX
        {
            get
            {
                return mx;
            }
        }
        public float PosY
        {
            get
            {
                return my;
            }
        }
    }
}
