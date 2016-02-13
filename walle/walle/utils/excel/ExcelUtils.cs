using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.utils
{
    public class ExcelUtils
    {
        #region getExcel

        public static ExcelPackage getExcel(String strFilePath)
        {
            var oFileInfo = new FileInfo(strFilePath);
            var oExcelPackage = new ExcelPackage(oFileInfo);
            return oExcelPackage;
        }

        #endregion

        #region getWorkbook

        public static ExcelWorkbook getWorkbook(ExcelPackage oExcel)
        {
            var oExcelWorkbook = oExcel.Workbook;
            return oExcelWorkbook;
        }

        #endregion

        #region getSheet

        public static ExcelWorksheet getSheet(int iSheetIndex, ExcelWorkbook oExcelWorkbook)
        {
            var oExcelWorksheet = oExcelWorkbook.Worksheets[iSheetIndex];
            return oExcelWorksheet;
        }

        #endregion

        #region getRow

        public static ExcelRow getRow(int iRowIndex, ExcelWorksheet oExcelWorksheet)
        {
            var oExcelRow = oExcelWorksheet.Row(iRowIndex);
            return oExcelRow;
        }

        #endregion

        #region getCell

        public static ExcelRange getCell(int iRowIndex, int iColIndex, ExcelWorksheet oExcelWorksheet)
        {
            var oExcelRange = oExcelWorksheet.Cells[iRowIndex, iColIndex];
            return oExcelRange;
        }

        #endregion

        #region setValue

        public static void setValue(String strValue, ExcelRange oCell)
        {
            oCell.Value = strValue;
        }

        #endregion

        #region saveAs

        public static void saveAs(String strFilePathXlsx, ExcelPackage oExcel)
        {
            var oFileInfo = new FileInfo(strFilePathXlsx);
            oExcel.SaveAs(oFileInfo);
        }

        #endregion

        #region dispose

        public static void dispose(ExcelPackage oExcel)
        {
            oExcel.Dispose();
        }

        #endregion
    }
}
