using GeometricLayouts.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace GeometricLayouts.Shared
{
    public abstract class Helper
    {
        public static bool ValidateRow(string row)
        {
            try
            {
                if (row.Length == 1)
                {
                    return ConvertRowAlphabetToNumber(row) < Convert.ToInt32(ConfigurationManager.AppSettings["NO_OF_ROWS"]);
                }
            }
            catch 
            {
                //do nothing, returns false.
            }

            return false;
        }
        public static bool ValidateColumn(string column)
        {

            try
            {
                if (column.Length == 1)
                {
                    return Convert.ToInt32(column) < Convert.ToInt32(ConfigurationManager.AppSettings["NO_OF_COLUMNS"]);
                }
                
            }
            catch
            {
                //do nothing, return false.
            }

            return false;
        }
        public static bool ValidateRowAndColumn(string rowAndColumn)
        {
            bool isValid = false;
            string[] split = new string[2];

            try
            {
                split = SplitRowAndColumn(rowAndColumn);
                isValid = ValidateRow(split[0]) && ValidateColumn(split[1]);
            }
            catch
            {
                //Do nothing. Returns false.
            }

            return isValid;
        }
        public static string[] SplitRowAndColumn(string rowAndColumn)
        {
            string[] split = new string[2];

            try
            {
                Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
                Match result = re.Match(rowAndColumn);

                split[0] = result.Groups[1].Value;
                split[1] = result.Groups[2].Value;
            }
            catch(Exception ex)
            {
                throw ex;
            }
           return split;
        }

        public static Int32 ConvertRowAlphabetToNumber(string row)
        {
            Int32 RowNumber;

            try
            {
                RowNumber = Convert.ToChar(row) - 'A';
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RowNumber;
        }
        public static string ConvertRowNumberToAlphabet(Int32 row)
        {
            string RowAlphabet;

            try
            {
                RowAlphabet = Convert.ToString(Convert.ToChar('A' + row));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RowAlphabet;
        }
    }
}