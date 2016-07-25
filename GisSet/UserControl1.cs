using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
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
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory.ToString();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" ;//设置打开文件类型
            openFileDialog1.FilterIndex = 2 ;
            openFileDialog1.RestoreDirectory = true ;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                   // MessageBox.Show("你选择了" + openFileDialog1.FileName);//得到文件路径
                    MapPath = openFileDialog1.FileName;
                    AddLayerToMap(map,MapPath);
                }
            }
        }

        private void AddLayerToMap(AxMap MapSet, string dataPath)
        {
            MapSet.RemoveAllLayers();
            MapSet.LockWindow(tkLockMode.lmLock);
            try
            {
                int layerHandle = -1;
                Shapefile sf = new Shapefile();
                if (sf.Open(dataPath, null))
                    layerHandle = MapSet.AddLayer(sf, true);
                else
                    MessageBox.Show(sf.ErrorMsg[sf.LastErrorCode]);
                if (layerHandle != -1)
                    MapSet.set_LayerName(layerHandle, Path.GetFileName(dataPath));
            }
            finally
            {
                MapSet.LockWindow(tkLockMode.lmUnlock);
                Debug.Print("Layers added to the map:" + MapSet.NumLayers);
            }
        }
    }
}
