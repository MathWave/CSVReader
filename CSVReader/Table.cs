using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSVReader
{
    public partial class Table : Form
    {

        string FilePath;

        static string[] colomns = 
        {
            "ROWNUM", "FullName", "ShortName", "AdmArea", "District", "PostalCode", "Address", "ChiefName", "ChiefPosition",
            "ChiefGender", "ChiefPhone", "PublicPhone", "Fax", "Email", "CloseFlag", "CloseReason", "CloseDate", "ReopenDate",
            "WorkingHours", "ClarificationOfWorkingHours", "Specialization", "BeneficialDrugPrescriptions", "ExtraInfo",
            "POINT_X", "POINT_Y", "GLOBALID"
        };

        DataTable data = new DataTable();
        public List<Dispanser> dispansers = new List<Dispanser>();
        public List<Dispanser> ReserveCopy = new List<Dispanser>();
        public bool reserved = false;

        public Table()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {

            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                FilePath = dialog.FileName;
            else
                return;
            if (FilePath.Substring(FilePath.Length - 4, 4) != ".csv")
            {
                MessageBox.Show("Файл не в формате .csv!", "Ошибка!");
                return;
            }
            DataTable tmp = new DataTable();
            List<Dispanser> dis = new List<Dispanser>();
            try
            {
                string[] lines = File.ReadAllLines(FilePath);
                string[] line = lines[0].Split(';');
                for (int j = 0; j < line.Length - 1; j++)
                    tmp.Columns.Add(line[j]);
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] elems = Formats.Parse(lines[i]);
                    Dispanser d = new Dispanser(elems);
                    dis.Add(d);
                }
                dispansers = dis;
                AmountRequest f = new AmountRequest(this);
                f.Show();
            }
            catch(FormatException)
            {
                MessageBox.Show("Не удалось преобразовать данные!", "Ошибка!");
            }
            catch (IOException)
            {
                MessageBox.Show("Файл уже открыт другой программой! Закройте файл и повторите попытку!", "Ошибка!");
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла!", "Ошибка!");
            }
        }

        public void ShowOnGrid()
        {
            int counter = 1;
            data = new DataTable();
            foreach (string str in colomns)
                data.Columns.Add(str);
            foreach (Dispanser d in dispansers)
            {
                DataRow dr = data.NewRow();
                dr["ROWNUM"] = counter++;
                dr["FullName"] = d.FullName;
                dr["ShortName"] = d.ShortName;
                dr["PostalCode"] = d.PostalCode;
                dr["Address"] = d.Address;
                dr["ChiefName"] = d.ChiefName;
                dr["ChiefPosition"] = d.ChiefPosition;
                dr["ChiefGender"] = d.ChiefGender ? "мужской" : "женский";
                dr["ChiefPhone"] = d.ChiefPhone;
                dr["PublicPhone"] = d.PublicPhone;
                dr["Fax"] = d.Fax;
                dr["Email"] = d.Email;
                dr["CloseFlag"] = d.CloseFlag ? "не действует" : "действует";
                dr["CloseReason"] = d.CloseReason;
                dr["CloseDate"] = d.CloseDate;
                dr["ReopenDate"] = d.ReopenDate;
                dr["WorkingHours"] = d.WorkingHours;
                dr["ClarificationOfWorkingHours"] = d.ClarificationOfWorkingHours;
                dr["Specialization"] = d.Specialization;
                dr["BeneficialDrugPrescriptions"] = d.BeneficialDrugPrescriptions;
                dr["ExtraInfo"] = d.ExtraInfo;
                dr["GLOBALID"] = d.GLOBALID;
                dr["AdmArea"] = d.location.AdmArea;
                dr["District"] = d.location.District;
                dr["POINT_X"] = d.location.Coordinates.X;
                dr["POINT_Y"] = d.location.Coordinates.Y;
                data.Rows.Add(dr);
            }
            dataGridView1.DataSource = data;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.Columns[0].Frozen = true;
        }

        private void saveas_Click(object sender, EventArgs e)
        {
            if (data.Columns.Count == 0)
            {
                MessageBox.Show("Таблицы нет!", "Ошибка!");
                return;
            }
            string newpath = "";
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                newpath = dialog.FileName;
            else
                return;
            newpath += ".csv";
            StreamWriter fstream = new StreamWriter(newpath, false, System.Text.Encoding.UTF8);
            for (int i = 0; i < data.Columns.Count; i++)
                fstream.Write(data.Columns[i].Caption + ";");
            fstream.WriteLine();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];
                fstream.Write(row[0] + ";");
                for (int j = 1; j < data.Columns.Count; j++)
                    fstream.Write("\"" + row[j] + "\";");
                fstream.WriteLine();
            }
            fstream.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (FilePath == null || FilePath.Length == 0 || data.Columns.Count == 0)
            {
                saveas_Click(sender, e);
                return;
            }
            StreamWriter fstream = new StreamWriter(FilePath, false, System.Text.Encoding.UTF8);
            string[,] dt = new string[data.Rows.Count, data.Columns.Count];
            for (int i = 0; i < data.Columns.Count; i++)
                fstream.Write(data.Columns[i].Caption + ";");
            fstream.WriteLine();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];
                fstream.Write(row[0] + ";");
                for (int j = 1; j < data.Columns.Count; j++)
                    fstream.Write("\"" + row[j] + "\";");
                fstream.WriteLine();
            }
            fstream.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            data.Columns.Clear();
            dispansers = new List<Dispanser>();
            reserved = false;
            button1.Visible = false;
        }

        private void create_Click(object sender, EventArgs e)
        {
            data = new DataTable();
            dispansers = new List<Dispanser>();
            foreach (string str in colomns)
                data.Columns.Add(str);
            dataGridView1.DataSource = data;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.Width = Width - 40;
            dataGridView1.Height = Height - 100;
            button1.Location = new System.Drawing.Point(Width - 140, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Width = Width - 40;
            dataGridView1.Height = Height - 100;
            button1.Location = new System.Drawing.Point(Width - 140, 0);
            MaximumSize = Screen.PrimaryScreen.Bounds.Size;
            MinimumSize = Size;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (data.Columns.Count == 0)
            {
                MessageBox.Show("Таблицы нет!", "Ошибка!");
                return;
            }
            Add f = new Add(this);
            f.Show();
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (data.Columns.Count == 0)
            {
                MessageBox.Show("Таблицы нет!", "Ошибка!");
                return;
            }
            ChangeRequest f = new ChangeRequest(this);
            f.Show();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (data.Columns.Count == 0)
            {
                MessageBox.Show("Таблицы нет!", "Ошибка!");
                return;
            }
            Remove f = new Remove(this);
            f.Show();   
        }

        private void NameGrow_Click(object sender, EventArgs e)
        {
            if (data.Columns.Count == 0)
            {
                MessageBox.Show("Таблицы нет!", "Ошибка!");
                return;
            }
            Dispanser[] disp = dispansers.ToArray<Dispanser>();
            Array.Sort(disp, (d1, d2) => string.Compare(d1.ChiefName, d2.ChiefName));
            dispansers = disp.ToList<Dispanser>();
            ShowOnGrid();
        }

        private void NameRise_Click(object sender, EventArgs e)
        {
            if (data.Columns.Count == 0)
            {
                MessageBox.Show("Таблицы нет!", "Ошибка!");
                return;
            }
            Dispanser[] disp = dispansers.ToArray<Dispanser>();
            Array.Sort(disp, (d1, d2) => string.Compare(d2.ChiefName, d1.ChiefName));
            dispansers = disp.ToList<Dispanser>();
            ShowOnGrid();
        }

        private void GenderGrow_Click(object sender, EventArgs e)
        {
            if (data.Columns.Count == 0)
            {
                MessageBox.Show("Таблицы нет!", "Ошибка!");
                return;
            }
            Dispanser[] disp = dispansers.ToArray<Dispanser>();
            Array.Sort(disp, (d1, d2) => GenderCompare(d1, d2));
            dispansers = disp.ToList<Dispanser>();
            ShowOnGrid();
        }

        private void GenderRise_Click(object sender, EventArgs e)
        {
            if (data.Columns.Count == 0)
            {
                MessageBox.Show("Таблицы нет!", "Ошибка!");
                return;
            }
            Dispanser[] disp = dispansers.ToArray<Dispanser>();
            Array.Sort(disp, (d1, d2) => GenderCompare(d2, d1));
            dispansers = disp.ToList<Dispanser>();
            ShowOnGrid();
        }

        int GenderCompare(Dispanser d1, Dispanser d2)
        {
            if (d1.ChiefGender ^ d2.ChiefGender == false)
                return 0;
            else if (d1.ChiefGender == true)
                return 1;
            else
                return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = reserved;
            dispansers = ReserveCopy;
            reserved = false;
            button1.Visible = false;
            ShowOnGrid();
        }

        private void FilterSame_Click(object sender, EventArgs e)
        {
            if (data.Columns.Count == 0)
            {
                MessageBox.Show("Таблицы нет!", "Ошибка!");
                return;
            }
            if (!reserved)
                ReserveCopy = dispansers;
            SameSpecializationRequest f = new SameSpecializationRequest(this);
            f.Show();
        }

        private void FilterSpecialization_Click(object sender, EventArgs e)
        {
            if (data.Columns.Count == 0)
            {
                MessageBox.Show("Таблицы нет!", "Ошибка!");
                return;
            }
            if (!reserved)
                ReserveCopy = dispansers;
            FilterSpecialization f = new FilterSpecialization(this);
            f.Show();
        }

        private void FilterChiefPosition_Click(object sender, EventArgs e)
        {
            if (data.Columns.Count == 0)
            {
                MessageBox.Show("Таблицы нет!", "Ошибка!");
                return;
            }
            if (!reserved)
                ReserveCopy = dispansers;
            FilterChiefPosition f = new FilterChiefPosition(this);
            f.Show();
        }

        private void CreateToolStrip_Click(object sender, EventArgs e)
        {
            create_Click(sender, e);
        }

        private void OpenToolStrip_Click(object sender, EventArgs e)
        {
            open_Click(sender, e);
        }

        private void SaveToolStrip_Click(object sender, EventArgs e)
        {
            save_Click(sender, e);
        }

        private void SaveAsToolStrip_Click(object sender, EventArgs e)
        {
            saveas_Click(sender, e);
        }
    }
}