using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Repositories;
using Mapster;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        DatabaseRepository _databaseRepository = new DatabaseRepository();
        public Form1()
        {
            InitializeComponent();
        }
        public string FirstConnectString { set; get; }
        public string SecondConnectString { set; get; }
        private void Form1_Load(object sender, EventArgs e)
        {
            Config form = new Config();
            form.ShowDialog();
            BaseRepository.FirstConnectString = form.FirstConnectString;
            BaseRepository.SecondConnectString = form.SecondConnectString;
            comboBox1.DataSource = _databaseRepository.GetFirstDatabaseList();
            comboBox2.DataSource = _databaseRepository.GetSecondDatabaseList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaseRepository.FirstDatabaseName = comboBox1.SelectedItem.ToString();
            _databaseRepository.GetTableName().ForEach(item =>
            {
                ListViewItem viewItem = new ListViewItem(item);
                listView1.Items.Add(viewItem);
            });
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaseRepository.SecondDatabaseName = comboBox2.SelectedItem.ToString();
            _databaseRepository.GetTableName(true).ForEach(item =>
            {
                ListViewItem viewItem = new ListViewItem(item);
                listView2.Items.Add(viewItem);
            });
        }

        string tableName = "Model";
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            var tableName = listView1.SelectedItems[0].Text;
            var a = _databaseRepository.GetCollumns(tableName);
            this.tableName = tableName;
            a.ForEach(item =>
            {
                ListViewItem it = new ListViewItem(item.COLUMN_NAME);
                it.SubItems.Add(item.DATA_TYPE);
                it.SubItems.Add(item.CHARACTER_MAXIMUM_LENGTH.ToString());
                listView3.Items.Add(it);
            });
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            var tableName = listView2.SelectedItems[0].Text;
            var a = _databaseRepository.GetCollumns(tableName, true);
            a.ForEach(item =>
            {
                ListViewItem it = new ListViewItem(item.COLUMN_NAME);
                it.SubItems.Add(item.DATA_TYPE);
                it.SubItems.Add(item.CHARACTER_MAXIMUM_LENGTH.ToString());
                listView4.Items.Add(it);
            });
        }

        private void listView3_DoubleClick(object sender, EventArgs e)
        {
            bool isHas = false;
            foreach (var item in listView5.Items)
                if (((ListViewItem)item).Text == listView3.SelectedItems[0].Text)
                    isHas = true;
            if (!isHas)
            {
                var listViewItem = new ListViewItem(listView3.SelectedItems[0].Text);
                listViewItem.SubItems.Add(listView3.SelectedItems[0].SubItems[1].Text);
                listViewItem.SubItems.Add(listView3.SelectedItems[0].SubItems[2].Text);
                listView5.Items.Add(listViewItem);
            }
        }

        private void listView4_DoubleClick(object sender, EventArgs e)
        {
            bool isHas = false;
            foreach (var item in listView6.Items)
                if (((ListViewItem)item).Text == listView4.SelectedItems[0].Text)
                    isHas = true;
            if (!isHas)
            {
                var listViewItem = new ListViewItem(listView4.SelectedItems[0].Text);
                listViewItem.SubItems.Add(listView4.SelectedItems[0].SubItems[1].Text);
                listViewItem.SubItems.Add(listView4.SelectedItems[0].SubItems[2].Text);
                listView6.Items.Add(listViewItem);
            }
        }

        string[] sqlType = new string[]
        {
            "decimal"
            ,"float"
            ,"int"
            ,"bigint"
            ,"money"
            ,"nchar"
            ,"ntext"
            ,"numeric"
            ,"nvarchar"
            ,"smalldatetime"
            ,"text"
            ,"time"
            ,"uniqueidentifier"
            ,"varchar"
        };
        string[] csType = new string[]
        {
            "decimal?"
            ,"double?"
            ,"int?"
            ,"long?"
            ,"decimal?"
            ,"string"
            ,"string"
            ,"decimal?"
            ,"string"
            ,"DateTime?"
            ,"String"
            ,"TimeSpan?"
            ,"string"
            ,"string"
        };

        string modelString = @"
public class {modelName}
{
    {properties}
}
";
        string selectSql = "SELECT {0} FROM {1}";

        string openJson = @"
IF OBJECT_ID('tempdb..#{0}') IS NOT NULL DROP TABLE #{0}
CREATE TABLE #{0}
(
	{1}
)
SELECT
{2}
FROM OPENJSON(@JInput)
WITH
(
	{1}
)
";

        string merge = @"
MERGE {0} AS TARGET
USING #{0} AS SOURCE
ON TARGET.key = SOURCE.key
WHEN MATCHED 
THEN
	UPDATE SET {1}
WHEN NOT MATCHED BY TARGET
THEN	INSERT
	(	
		{2}
	)
	VALUES
	(	
		{3}
	)
WHEN NOT MATCHED BY SOURCE 
	UPDATE SET 
";
        private void button1_Click(object sender, EventArgs e)
        {
            if(listView5.Items.Count == listView6.Items.Count && listView5.Items.Count > 0)
            {
                var fields = new List<string>();
                var fieldWithType = new List<string>();
                var properties = new List<string>();
                var updates = new List<string>();
                var values = new List<string>();
                string model = "public {0} {1} {{ get; set; }}";
                for (int i = 0; i < listView5.Items.Count; i++)
                {
                    if(listView5.Items[i].Text == listView6.Items[i].Text)
                    {
                        fields.Add(listView5.Items[i].Text);
                    } 
                    else
                    {
                        fields.Add(listView5.Items[i].Text + " AS " + listView6.Items[i].Text);
                    }
                    var index = sqlType.ToList().IndexOf(listView6.Items[i].SubItems[1].Text.Trim());
                    var type = csType[index];
                    fieldWithType.Add(listView6.Items[i].Text + " " + sqlType[index].ToUpper() + " (" + listView6.Items[i].SubItems[2].Text + ")");
                    properties.Add(string.Format(model, type, listView6.Items[i].Text));
                    updates.Add(string.Format("TARGET.{0} = SOURCE.{0}", listView6.Items[i].Text));
                    values.Add(string.Format("SOURCE.{0}", listView6.Items[i].Text));
                }
                var sqlCommand = string.Format(selectSql, string.Join(",", fields), tableName);
                textBox1.Text = sqlCommand;
                textBox2.Text = modelString.Replace("{modelName}", tableName).Replace("{properties}", string.Join("\r\n    ", properties));
                textBox3.Text = string.Format(openJson, tableName, string.Join(",\r\n", fieldWithType), string.Join(",\r\n", fields));
                textBox4.Text = string.Format(merge, tableName, string.Join(",\r\n", updates), string.Join(", ", fields), string.Join(", ", values));
                
                return;
            }
            MessageBox.Show("Cannot map!");
        }
    }
}
