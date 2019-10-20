using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable table = new DataTable();
        private int selectedRow;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "росимуществоDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.росимуществоDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "росимуществоDataSet.Подразделение". При необходимости она может быть перемещена или удалена.
            this.подразделениеTableAdapter.Fill(this.росимуществоDataSet.Подразделение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "росимуществоDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.росимуществоDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "росимуществоDataSet.Съемщики". При необходимости она может быть перемещена или удалена.
            this.съемщикиTableAdapter.Fill(this.росимуществоDataSet.Съемщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "росимуществоDataSet.Купля_продажа". При необходимости она может быть перемещена или удалена.
            this.купля_продажаTableAdapter.Fill(this.росимуществоDataSet.Купля_продажа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "росимуществоDataSet.Имущество". При необходимости она может быть перемещена или удалена.
            this.имуществоTableAdapter.Fill(this.росимуществоDataSet.Имущество);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            росимуществоDataSet.Имущество.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            dataGridView1.DataSource = росимуществоDataSet.Имущество;

            this.Validate();
            this.имуществоBindingSource.EndEdit();
            this.имуществоTableAdapter.Update(this.росимуществоDataSet.Имущество);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDatarow = dataGridView1.Rows[selectedRow];
            newDatarow.Cells[0].Value = textBox1.Text;
            newDatarow.Cells[1].Value = textBox2.Text;
            newDatarow.Cells[2].Value = textBox3.Text;
            newDatarow.Cells[3].Value = textBox4.Text;
            newDatarow.Cells[4].Value = textBox5.Text;
            newDatarow.Cells[5].Value = textBox6.Text;

            this.Validate();
            this.имуществоBindingSource.EndEdit();
            this.имуществоTableAdapter.Update(this.росимуществоDataSet.Имущество);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult vibor2 = MessageBox.Show("Вы действительно хотите удалить строку?", "Сообщение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (vibor2 == DialogResult.Yes)
            {
                selectedRow = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(selectedRow);

                this.Validate();
                this.имуществоBindingSource.EndEdit();
                this.имуществоTableAdapter.Update(this.росимуществоDataSet.Имущество);
            }
            else
                MessageBox.Show("Вы не удалили строку!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox7.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = null;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[selectedRow];
            textBox9.Text = row.Cells[0].Value.ToString();
            textBox10.Text = row.Cells[1].Value.ToString();
            textBox11.Text = row.Cells[2].Value.ToString();
            textBox12.Text = row.Cells[3].Value.ToString();
            textBox13.Text = row.Cells[4].Value.ToString();
            textBox14.Text = row.Cells[5].Value.ToString();
            textBox15.Text = row.Cells[6].Value.ToString();
            textBox16.Text = row.Cells[7].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            росимуществоDataSet.Купля_продажа.Rows.Add(textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, textBox16.Text);
            dataGridView2.DataSource = росимуществоDataSet.Купля_продажа;

            this.Validate();
            this.купляпродажаBindingSource.EndEdit();
            this.купля_продажаTableAdapter.Update(this.росимуществоDataSet.Купля_продажа);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDatarow = dataGridView2.Rows[selectedRow];
            newDatarow.Cells[0].Value = textBox9.Text;
            newDatarow.Cells[1].Value = textBox10.Text;
            newDatarow.Cells[2].Value = textBox11.Text;
            newDatarow.Cells[3].Value = textBox12.Text;
            newDatarow.Cells[4].Value = textBox13.Text;
            newDatarow.Cells[5].Value = textBox14.Text;
            newDatarow.Cells[6].Value = textBox15.Text;
            newDatarow.Cells[7].Value = textBox16.Text;

            this.Validate();
            this.купляпродажаBindingSource.EndEdit();
            this.купля_продажаTableAdapter.Update(this.росимуществоDataSet.Купля_продажа);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox8.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox8.Text = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult vibor2 = MessageBox.Show("Вы действительно хотите удалить строку?", "Сообщение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (vibor2 == DialogResult.Yes)
            {
                selectedRow = dataGridView2.CurrentCell.RowIndex;
                dataGridView2.Rows.RemoveAt(selectedRow);

                this.Validate();
                this.купляпродажаBindingSource.EndEdit();
                this.купля_продажаTableAdapter.Update(this.росимуществоDataSet.Купля_продажа);
            }
            else
                MessageBox.Show("Вы не удалили строку!");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView3.Rows[selectedRow];
            textBox18.Text = row.Cells[0].Value.ToString();
            textBox19.Text = row.Cells[1].Value.ToString();
            textBox20.Text = row.Cells[2].Value.ToString();
            textBox21.Text = row.Cells[3].Value.ToString();
            textBox22.Text = row.Cells[4].Value.ToString();
            textBox23.Text = row.Cells[5].Value.ToString();
            textBox24.Text = row.Cells[6].Value.ToString();
            textBox25.Text = row.Cells[7].Value.ToString();
            textBox26.Text = row.Cells[8].Value.ToString();
            textBox27.Text = row.Cells[9].Value.ToString();
            textBox28.Text = row.Cells[10].Value.ToString();
            textBox29.Text = row.Cells[11].Value.ToString();
            textBox30.Text = row.Cells[12].Value.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            росимуществоDataSet.Съемщики.Rows.Add(textBox18.Text, textBox19.Text, textBox20.Text, textBox21.Text, textBox22.Text, 
                textBox23.Text, textBox24.Text, textBox25.Text, textBox26.Text, textBox27.Text, textBox28.Text, textBox29.Text, textBox30.Text);
            dataGridView3.DataSource = росимуществоDataSet.Съемщики;

            this.Validate();
            this.съемщикиBindingSource.EndEdit();
            this.съемщикиTableAdapter.Update(this.росимуществоDataSet.Съемщики);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDatarow = dataGridView3.Rows[selectedRow];
            newDatarow.Cells[0].Value = textBox18.Text;
            newDatarow.Cells[1].Value = textBox19.Text;
            newDatarow.Cells[2].Value = textBox20.Text;
            newDatarow.Cells[3].Value = textBox21.Text;
            newDatarow.Cells[4].Value = textBox22.Text;
            newDatarow.Cells[5].Value = textBox23.Text;
            newDatarow.Cells[6].Value = textBox24.Text;
            newDatarow.Cells[7].Value = textBox25.Text;
            newDatarow.Cells[8].Value = textBox26.Text;
            newDatarow.Cells[9].Value = textBox27.Text;
            newDatarow.Cells[10].Value = textBox28.Text;
            newDatarow.Cells[11].Value = textBox29.Text;
            newDatarow.Cells[12].Value = textBox30.Text;

            this.Validate();
            this.съемщикиBindingSource.EndEdit();
            this.съемщикиTableAdapter.Update(this.росимуществоDataSet.Съемщики);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult vibor2 = MessageBox.Show("Вы действительно хотите удалить строку?", "Сообщение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (vibor2 == DialogResult.Yes)
            {
                selectedRow = dataGridView3.CurrentCell.RowIndex;
                dataGridView3.Rows.RemoveAt(selectedRow);

                this.Validate();
                this.съемщикиBindingSource.EndEdit();
                this.съемщикиTableAdapter.Update(this.росимуществоDataSet.Съемщики);
            }
            else
                MessageBox.Show("Вы не удалили строку!");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                dataGridView3.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView3.ColumnCount; j++)
                    if (dataGridView3.Rows[i].Cells[j].Value != null)
                        if (dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(textBox17.Text))
                        {
                            dataGridView3.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox17.Text = null;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView4.Rows[selectedRow];
            textBox32.Text = row.Cells[0].Value.ToString();
            textBox33.Text = row.Cells[1].Value.ToString();
            textBox34.Text = row.Cells[2].Value.ToString();
            textBox35.Text = row.Cells[3].Value.ToString();
            textBox36.Text = row.Cells[4].Value.ToString();
            textBox37.Text = row.Cells[5].Value.ToString();
            textBox38.Text = row.Cells[6].Value.ToString();
            textBox39.Text = row.Cells[7].Value.ToString();
            textBox40.Text = row.Cells[8].Value.ToString();
            textBox41.Text = row.Cells[9].Value.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            росимуществоDataSet.Сотрудники.Rows.Add(textBox32.Text, textBox33.Text, textBox34.Text, textBox35.Text,
                textBox36.Text, textBox37.Text, textBox38.Text, textBox39.Text, textBox40.Text, textBox41.Text);
            dataGridView4.DataSource = росимуществоDataSet.Сотрудники;

            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.сотрудникиTableAdapter.Update(this.росимуществоDataSet.Сотрудники);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDatarow = dataGridView4.Rows[selectedRow];
            newDatarow.Cells[0].Value = textBox32.Text;
            newDatarow.Cells[1].Value = textBox33.Text;
            newDatarow.Cells[2].Value = textBox34.Text;
            newDatarow.Cells[3].Value = textBox35.Text;
            newDatarow.Cells[4].Value = textBox36.Text;
            newDatarow.Cells[5].Value = textBox37.Text;
            newDatarow.Cells[6].Value = textBox38.Text;
            newDatarow.Cells[7].Value = textBox39.Text;
            newDatarow.Cells[8].Value = textBox40.Text;
            newDatarow.Cells[9].Value = textBox41.Text;

            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.сотрудникиTableAdapter.Update(this.росимуществоDataSet.Сотрудники);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DialogResult vibor2 = MessageBox.Show("Вы действительно хотите удалить строку?", "Сообщение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (vibor2 == DialogResult.Yes)
            {
                selectedRow = dataGridView4.CurrentCell.RowIndex;
                dataGridView4.Rows.RemoveAt(selectedRow);

                this.Validate();
                this.сотрудникиBindingSource.EndEdit();
                this.сотрудникиTableAdapter.Update(this.росимуществоDataSet.Сотрудники);
            }
            else
                MessageBox.Show("Вы не удалили строку!");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                dataGridView4.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView4.ColumnCount; j++)
                    if (dataGridView4.Rows[i].Cells[j].Value != null)
                        if (dataGridView4.Rows[i].Cells[j].Value.ToString().Contains(textBox31.Text))
                        {
                            dataGridView4.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox31.Text = null;
        }
    }
}
