using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using HtmlAgilityPack;
using OfficeOpenXml;
using Shared_Class_Vivo_Apps.Enums;
using Shared_Class_Vivo_Apps.Models;
using System.Data;

namespace Vivo_Apps_API.Models.Converters
{
    public class Converters
    {
        public static List<string> ConvertStringToStringList(string input)
        {
            var enumList = new List<string>();

            if (!string.IsNullOrEmpty(input))
            {
                if (input.Contains(";"))
                {
                    // Multiple values separated by semicolon
                    var enumValues = input.Split(';').Select(x => x.Trim());

                    foreach (var value in enumValues)
                    {
                        enumList.Add(value);
                    }
                }
                else
                {
                    enumList.Add(input);
                }
            }

            return enumList;
        }
        public static DataTable ConvertHtmlTableToDataTable(string html)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            DataTable table = new DataTable();

            // Obtendo a primeira linha para criar colunas
            HtmlNodeCollection headerRows = doc.DocumentNode.SelectNodes("//table/tr");
            if (headerRows != null)
            {
                foreach (HtmlNode headerRow in headerRows.Take(1))
                {
                    foreach (HtmlNode cell in headerRow.SelectNodes("th|td"))
                    {
                        table.Columns.Add(cell.InnerText.Trim());
                    }
                }
            }

            // Adicionando linhas de dados
            HtmlNodeCollection dataRows = doc.DocumentNode.SelectNodes("//table/tr[position()>1]");
            if (dataRows != null)
            {
                foreach (HtmlNode dataRow in dataRows)
                {
                    DataRow row = table.NewRow();
                    int columnIndex = 0;

                    foreach (HtmlNode cell in dataRow.SelectNodes("th|td"))
                    {
                        row[columnIndex] = cell.InnerText.Trim();
                        columnIndex++;
                    }

                    table.Rows.Add(row);
                }
            }

            return table;
        }
        public static void ExportToExcel(DataTable dataTable, string outputPath)
        {
            FileInfo newFile = new FileInfo(outputPath);

            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Adicionando cabeçalho
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                }

                // Adicionando dados
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataTable.Rows[i][j];
                    }
                }

                // Salvar o arquivo XLSX
                package.Save();
            }
        }
        public static string RemoveNonNumericCharacters(string input) => new string(input.ToCharArray().Where(c => char.IsDigit(c)).ToArray());
        public static List<TEnum> ConvertStringToEnumList<TEnum>(string input) where TEnum : struct
        {
            var enumList = new List<TEnum>();

            if (!string.IsNullOrEmpty(input))
            {
                if (input.Contains(";"))
                {
                    // Multiple values separated by semicolon
                    var enumValues = input.Split(';').Select(x => x.Trim());

                    foreach (var value in enumValues)
                    {
                        if (Enum.TryParse(typeof(TEnum), value, out var categoriaValue) && categoriaValue is TEnum)
                        {
                            enumList.Add((TEnum)categoriaValue);
                        }
                        else
                        {
                            // Handle the case where parsing fails or provide a default value
                        }
                    }
                }
                else
                {
                    // Single value without semicolon
                    if (Enum.TryParse(typeof(TEnum), input.Trim(), out var categoriaValue) && categoriaValue is TEnum)
                    {
                        enumList.Add((TEnum)categoriaValue);
                    }
                    else
                    {
                        // Handle the case where parsing fails or provide a default value
                    }
                }
            }

            return enumList;
        }
        public static IEnumerable<Cargos> GetCargosFromStringList(string cargo)
        {
            var delimiter = new[] { ';' };
            var cargosArray = cargo.Split(delimiter, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(x => (Cargos)int.Parse(x))
                                   .ToList();

            return cargosArray;
        }
        public static IEnumerable<Canal> GetCanaisFromCargos(string cargo)
        {
            var cargosList = GetCargosFromStringList(cargo);
            var canaisArray = cargosList.Select(x => DePara.CanalCargoEnum(x)).ToList();

            return canaisArray;
        }
        public static DataTable ReadExcelToDataTable(byte[] content)
        {
            using (MemoryStream memoryStream = new MemoryStream(content))
            {
                using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(memoryStream, false))
                {
                    WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
                    Sheet sheet = workbookPart.Workbook.Descendants<Sheet>().FirstOrDefault();
                    WorksheetPart worksheetPart = (WorksheetPart)workbookPart.GetPartById(sheet.Id);

                    SharedStringTablePart sharedStringTablePart = workbookPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();

                    DataTable dataTable = new DataTable();

                    foreach (Row row in worksheetPart.Worksheet.Descendants<Row>())
                    {
                        if (row.RowIndex == 1)
                        {
                            // Assuming the first row contains column names
                            foreach (Cell cell in row.Elements<Cell>())
                            {
                                string columnName = GetCellValue(cell, sharedStringTablePart);
                                dataTable.Columns.Add(columnName);
                            }
                        }
                        else
                        {
                            DataRow dataRow = dataTable.NewRow();
                            int columnIndex = 0;

                            foreach (Cell cell in row.Elements<Cell>())
                            {
                                dataRow[columnIndex] = GetCellValue(cell, sharedStringTablePart);
                                columnIndex++;
                            }

                            dataTable.Rows.Add(dataRow);
                        }
                    }

                    return dataTable;
                }
            }
        }
        public static string GetCellValue(Cell cell, SharedStringTablePart sharedStringTablePart)
        {
            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return sharedStringTablePart.SharedStringTable.ChildElements[int.Parse(cell.InnerText)].InnerText;
            }
            else
            {
                return cell.InnerText;
            }
        }

    }
}
