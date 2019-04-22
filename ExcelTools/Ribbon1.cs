using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ExcelTools
{
    public partial class Ribbon1
    {
        public Excel.Application ExcelApp;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            ExcelApp = Globals.ThisAddIn.Application;
            this.copy.Checked = true;
            this.content.Checked = true;
            this.amount.Text = 999.ToString();
        }

        private void select_Click(object sender, RibbonControlEventArgs e)
        {
            string i = this.amount.Text;
            if (Microsoft.VisualBasic.Information.TypeName(ExcelApp.Selection)=="Range")
            {
                if (ExcelApp.Application.ActiveCell.Row + Convert.ToInt32(this.amount.Text) <= ExcelApp.Application.Rows.Count)
                {
                    double MaxRow = ExcelApp.Application.WorksheetFunction.Min(ExcelApp.Application.WorksheetFunction.CountA(ExcelApp.Application.ActiveCell.Resize[i, 1]), i);
                    if (this.content.Checked == true && MaxRow != 0)
                    {
                        if (ExcelApp.Application.WorksheetFunction.CountA(ExcelApp.Application.ActiveCell.Resize[MaxRow, 1]) == MaxRow)
                        {

                            ExcelApp.ActiveCell.Offset[Convert.ToInt32(ExcelApp.Selection.Cells.Count > 1) * 1, 0].Resize[MaxRow, 1].Select();
                            ExcelApp.Application.Selection(MaxRow, 1).Activate();

                            if (this.copy.Checked == true)
                            {
                                ExcelApp.Application.Selection.Copy();
                            }
                        }
                        else
                        {
                            MessageBox.Show("请保证选择区域数据连续", "提示");
                        }
                    }
                    else if (this.content.Checked == true && MaxRow == 0)
                    {
                        MessageBox.Show("所选区域无内容", "提示");
                    }
                    else if (this.content.Checked == false)
                    {
                        ExcelApp.ActiveCell.Offset[Convert.ToInt32(ExcelApp.Selection.Cells.Count > 1) * 1, 0].Resize[i, 1].Select();
                        ExcelApp.Application.Selection(i, 1).Activate();
                        if (this.copy.Checked == true)
                        {
                            ExcelApp.Application.Selection.Copy();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("要选择的区域超出当前工作表最大行号，请重新设置选择数量", "提示");
                }
            }
        else
         {
                MessageBox.Show("请选择单元格");
         }

        }

        private void amount_TextChanged(object sender, RibbonControlEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(this.amount.Text) > ExcelApp.Application.Rows.Count)
                {
                    MessageBox.Show("选择的数量不能大于工作表的行数", "提示");
                    this.amount.Text = "999";
                }
                else if (Convert.ToInt32(this.amount.Text) < 1)
                {
                    MessageBox.Show("请输入大于0的正整数", "提示");
                    this.amount.Text = "999";
                }
            }
            catch
            {
                MessageBox.Show("请输入大于0的正整数", "提示");
                this.amount.Text = "999";
            }
        }
 
    }
}
