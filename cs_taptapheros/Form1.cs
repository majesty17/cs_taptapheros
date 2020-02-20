using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs_taptapheros
{
    public partial class Form1 : Form
    {

        private List<Hero> heros = null;
        public Form1()
        {
            InitializeComponent();
        }

        //启动初始化
        private void Form1_Load(object sender, EventArgs e)
        {
            heros = Hero.FromJSONArr<Hero>();
            comboBox_filter_camp.SelectedIndex = 0;
            comboBox_filter_major.SelectedIndex = 0;
            comboBox_filter_stars.SelectedIndex = 0;
            refreshHeroList();
        }
        //刷新英雄列表
        private void refreshHeroList()
        {
            listView_heros.Items.Clear();
            foreach(Hero h in heros)
            {
                ListViewItem lvi = new ListViewItem(h.camp);
                lvi.Tag = (Object)h;
                lvi.BackColor = h.getColor();
                lvi.SubItems.Add(h.major);
                lvi.SubItems.Add(h.stars.ToString());
                lvi.SubItems.Add(h.maxlvl.ToString());
                listView_heros.Items.Add(lvi);
            }
        }
        //过滤器调整
        private void comboBox_filter_camp_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshHeroList();
        }

        private void comboBox_filter_major_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshHeroList();
        }

        private void comboBox_filter_stars_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshHeroList();
        }

        private void listView_heros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_heros.SelectedItems.Count > 0)
            {
                Hero h = (Hero)listView_heros.SelectedItems[0].Tag;
                MessageBox.Show(h.name);
            }
        }
    }
}
