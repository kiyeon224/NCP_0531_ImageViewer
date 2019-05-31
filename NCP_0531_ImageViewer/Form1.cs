using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NCP_0531_ImageViewer
{
    public partial class Form1 : Form
    {
        int imgCount = 0;  //현재 보고있는 이미지 번호

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.picImg.Image = (Image)this.imgList.Images[this.imgCount];
            this.lblNum.Text = (this.imgCount + 1) + "/" + this.imgList.Images.Count;
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            this.imgCount--;
            if (this.imgCount < 0)
            {
                this.imgCount = this.imgList.Images.Count - 1;
            }
            this.picImg.Image = (Image)this.imgList.Images[this.imgCount];
            this.lblNum.Text = (this.imgCount + 1) + "/" + this.imgList.Images.Count;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.imgCount++;
            if (this.imgCount > 42)
            {
                this.imgCount = 0;
            }
            this.picImg.Image = (Image)this.imgList.Images[this.imgCount];
            this.lblNum.Text = (this.imgCount + 1) + "/" + this.imgList.Images.Count;
        }
    }
}
