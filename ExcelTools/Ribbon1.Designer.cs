﻿namespace ExcelTools
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
            this.label1 = this.Factory.CreateRibbonLabel();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.label1);
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
            // label1
            // 
            this.label1.Label = "label1";
            this.label1.Name = "label1";
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
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox amount;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox content;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox copy;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton select;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
