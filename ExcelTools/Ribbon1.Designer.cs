namespace ExcelTools
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.amount = this.Factory.CreateRibbonEditBox();
            this.content = this.Factory.CreateRibbonCheckBox();
            this.copy = this.Factory.CreateRibbonCheckBox();
            this.select = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.editBox1 = this.Factory.CreateRibbonEditBox();
            this.checkBox1 = this.Factory.CreateRibbonCheckBox();
            this.checkBox2 = this.Factory.CreateRibbonCheckBox();
            this.button1 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.amount);
            this.group1.Items.Add(this.content);
            this.group1.Items.Add(this.copy);
            this.group1.Items.Add(this.select);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // amount
            // 
            this.amount.Label = "数量";
            this.amount.Name = "amount";
            this.amount.Text = null;
            this.amount.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.amount_TextChanged);
            // 
            // content
            // 
            this.content.Label = "内容";
            this.content.Name = "content";
            // 
            // copy
            // 
            this.copy.Label = "复制";
            this.copy.Name = "copy";
            // 
            // select
            // 
            this.select.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.select.Label = "选择";
            this.select.Name = "select";
            this.select.ShowImage = true;
            this.select.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.select_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.editBox1);
            this.group2.Items.Add(this.checkBox1);
            this.group2.Items.Add(this.checkBox2);
            this.group2.Items.Add(this.button1);
            this.group2.Label = "group1";
            this.group2.Name = "group2";
            // 
            // editBox1
            // 
            this.editBox1.Label = "数量";
            this.editBox1.Name = "editBox1";
            this.editBox1.Text = null;
            // 
            // checkBox1
            // 
            this.checkBox1.Label = "内容";
            this.checkBox1.Name = "checkBox1";
            // 
            // checkBox2
            // 
            this.checkBox2.Label = "复制";
            this.checkBox2.Name = "checkBox2";
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Label = "选择";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox amount;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox content;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox copy;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton select;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
