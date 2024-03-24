using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookAddIn2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            GetAllCalendarItems(textBox1.Text);
        }

        //Função para obter todos os eventos de calendário da sessão atual do outlook
        public void GetAllCalendarItems(string search)
        {
            Outlook.Application oApp = null;
            Outlook.NameSpace mapiNameSpace = null;
            Outlook.MAPIFolder calendarFolder = null;
            Outlook.Items calendarItems = null;

            oApp = new Outlook.Application();
            mapiNameSpace = oApp.GetNamespace("MAPI");
            calendarFolder = mapiNameSpace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderCalendar); //Pasta do calendário
            calendarItems = calendarFolder.Items;
            calendarItems.IncludeRecurrences = true;

            //Criar tabela e definir as colunas
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Assunto", typeof(string)));
            dt.Columns.Add(new DataColumn("Início", typeof(string)));
            dt.Columns.Add(new DataColumn("Fim", typeof(string)));
            dt.Columns.Add(new DataColumn("Mensagem", typeof(string)));

            //Por cada item de evento no calendário do outlook, adicionar linha à tabela
            foreach (Outlook.AppointmentItem item in calendarItems)
            {
                if (item.Subject.ToUpper().Contains(search) == true)    //Se o item a pesquisar existe em alguma linha da tabela
                    dt.Rows.Add(item.Subject, item.Start.ToShortDateString(), item.End.ToShortDateString(), item.Body);
            }

            dataGridView1.Size = new Size(1400, 400);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns["Mensagem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string tb1ToUpper = textBox1.Text.ToUpper();            //Converter para maiúsculas  
            GetAllCalendarItems(tb1ToUpper);
        }
    }
}
