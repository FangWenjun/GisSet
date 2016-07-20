namespace GisSet
{
    partial class GisSetControl
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.addlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addlayer
            // 
            this.addlayer.Location = new System.Drawing.Point(95, 73);
            this.addlayer.Name = "addlayer";
            this.addlayer.Size = new System.Drawing.Size(75, 23);
            this.addlayer.TabIndex = 0;
            this.addlayer.Text = "加载地图";
            this.addlayer.UseVisualStyleBackColor = true;
            this.addlayer.Click += new System.EventHandler(this.addlayer_Click);
            // 
            // GisSetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addlayer);
            this.Name = "GisSetControl";
            this.Size = new System.Drawing.Size(407, 239);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addlayer;
    }
}
