using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxMapWinGIS;
using MapWinGIS;

namespace GisSet
{
    public partial class GisSetControl: UserControl
    {
        public GisSetControl()
        {
            InitializeComponent();
        }

        //地图控件的实例化
        private AxMap map;
        //加载地图的地址
        private string MapPath;

        public AxMap MAP
        {
            get
            {
                return map;
            }
            set
            {
                map = value;
            }
        }

        private void addlayer_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folder = new System.Windows.Forms.FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                MapPath = folder.SelectedPath;
                AddLayerToMap(map);
            }
        }

        private int AddLayerToMap(AxMap MapSet)
        {
            return MapSet.AddLayerFromFilename(MapPath, tkFileOpenStrategy.fosAutoDetect, true);
        }
    }
}
