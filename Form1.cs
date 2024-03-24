using Ical.Net;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using Ical.Net.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using IronXL;
using System.Threading;
using System.Globalization;

namespace OutlookAddIn2
{
    public partial class Form1 : Form
    {
        public List<DateTime> datas = new List<DateTime>(); //Lista para guardar datas de avisos
        public List<string> bodyMail = new List<string>();  //Lista para guardar textos de avisos
        public List<string> toMail = new List<string>();    //Lista para guardar destinatários de avisos


        public Form1()
        {
            InitializeComponent();

        }

        //Função que carrega a view principal (inserção de avisos)
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;       //Mudar formato da data nos inputs de calendários
            dateTimePicker1.CustomFormat = "dddd dd-MM-yyyy";           //Formato opcional ('dia da semana' '01-01-2022')
            dateTimePicker2.Format = DateTimePickerFormat.Custom;       //Mudar formato da data nos inputs de calendários
            dateTimePicker2.CustomFormat = "dddd dd-MM-yyyy HH:mm tt";  //Formato opcional ('dia da semana' '01-01-2022' '12:00' - 'tt' para formato 24horas)
            dateTimePicker3.Format = DateTimePickerFormat.Custom;       //Mudar formato da data nos inputs de calendários
            dateTimePicker3.CustomFormat = "dddd dd-MM-yyyy";           //Formato opcional ('dia da semana' '01-01-2022')

            dateTimePicker1.MinDate = DateTime.Now;                     //Definir a data mínima a apresentar no input de calendário
            dateTimePicker2.MinDate = DateTime.Now;                     //Definir a data mínima a apresentar no input de calendário
            dateTimePicker3.MinDate = DateTime.Now;                     //Definir a data mínima a apresentar no input de calendário

            dateTimePicker1.Value = DateTime.Now;                       //Definir a data a apresentar no input de calendário
            dateTimePicker2.Value = DateTime.Now;                       //Definir a data a apresentar no input de calendário
            dateTimePicker3.Value = DateTime.Now;                       //Definir a data a apresentar no input de calendário


            checkBox1.Checked = false;                                  //Marcar checkbox sem pisco
            textBox6.Enabled = false;                                   //Marcar caixa de texto apenas de leitura
            dateTimePicker3.Enabled = false;                            //Marcar input de calendário apenas de leitura

            dateTimePicker1.Visible = false;                            //Não apresentar input de calendário na view principal
            dateTimePicker3.Visible = false;                            //Não apresentar input de calendário na view principal
            textBox5.Visible = false;                                   //Não apresentar caixa de texto na view principal
            textBox6.Visible = false;                                   //Não apresentar caixa de texto na view principal
            label2.Visible = false;                                     //Não apresentar label na view principal
            checkBox1.Visible = false;                                  //Não apresentar checkbox na view principal
        }

        //Função que controla o comportamento da caixa de texto
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //Função que controla o comportamento do input de calendário
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //Construir string que apresenta por extenso a data escolhida no input de calendário, para apresentar na caixa de texto
            string tb2 = dateTimePicker2.Value.ToString("dddd") + ", " + dateTimePicker2.Value.ToLongDateString() + " ás " + dateTimePicker2.Value.ToShortTimeString();
            textBox2.Text = tb2;

            //Após escolha da data no calendário, definir a data mínima do calendário com o valor da data escolhida
            dateTimePicker1.MinDate = dateTimePicker2.Value;
        }

        //Função que controla o comportamento da caixa de texto
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Função que controla o comportamento do input de calendário
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        
        //Funcção iniciada quando é pressionado o botão em questão
        private void button1_Click_1(object sender, EventArgs e)
        {

            //Ler de ficheiro Excel (problema de mudança de células)
            //string fileName = "Datas_Alertas_SIADAP1.xlsx";
            //string path = Path.Combine(Environment.CurrentDirectory, fileName);
            //WorkBook workbook = WorkBook.Load(path);
            //WorkSheet sheet = workbook.WorkSheets.First();
            //foreach (var cell in sheet["C5:C31"])
            //{
            //    toMail.Add(cell.Text);
            //}

            //Ligação ao servidor de email
            //var client = new SmtpClient("mail.drapnorte.gov.pt", 25)    //Servidor + porta
            var client = new SmtpClient("smtp.freesmtpservers.com", 25)    //Servidor + porta - testes
            {
                Credentials = System.Net.CredentialCache.DefaultNetworkCredentials, //Credenciais para ligar ao servidor (vai buscar credenciais automaticamente à sessão ligada no outlook)
                //EnableSsl = true,
                Timeout = 100000
            };
            
            Outlook._Application olApp = (Outlook._Application)new Outlook.Application();   //Nova instância da aplicação outlook
            Outlook.NameSpace mapins = olApp.GetNamespace("MAPI");                          
            //string address = olApp.Session.CurrentUser.AddressEntry.Address;                //Guardar o endereço de email da sessão atual de outlook
            string address = olApp.Session.CurrentUser.AddressEntry.GetExchangeUser().PrimarySmtpAddress;   //Guardar o endereço de email da sessão atual de outlook - (fora da organização esta instrução funciona melhor, pois dá o email em string)

            MailMessage msg = new MailMessage();            //Nova mensagem de mail
            msg.From = new MailAddress(address, address);   //Adicionar ao remetente do mail o endereço da sessão atual de outlook


            string emailAddresses = textBox4.Text;          //Guardar os endereços de email inseridos na caixa de texto
            string[] emails = emailAddresses.Split(';');    //Guardar num array cada email separado por ;

            foreach (var email in emails)
            {
                email.Replace(" ", String.Empty);           //Por cada endereço de email guardado no array, limpar os espaços em branco para prevenir eventuais erros de envio de email

                msg.To.Add(new MailAddress(email));         //Adicionar os endereços de email à lista de destinatários
            }

            //foreach (var toM in toMail)
            //    msg.To.Add(toM);


            msg.Subject = textBox3.Text;                    //Guardar o assunto do email inserido na caixa de texto
            //msg.Body = textBox1.Text;
            msg.IsBodyHtml = true;


            //Construir ficheiro ics através dum String Builder
            StringBuilder str = new StringBuilder();
            str.AppendLine("BEGIN:VCALENDAR");
            str.AppendLine("PRODID:-//Schedule a Meeting");
            str.AppendLine("VERSION:2.0");
            str.AppendLine("METHOD:PUBLISH");
            str.AppendLine("X-WR-CALNAME:Avisos");
            str.AppendLine("BEGIN:VTIMEZONE");
            str.AppendLine("TZID:Europe/London");
            str.AppendLine("LAST-MODIFIED:20220317T223602Z");
            str.AppendLine("TZURL:http://tzurl.org/zoneinfo-outlook/Europe/London");
            str.AppendLine("X-LIC-LOCATION:Europe/London");
            str.AppendLine("BEGIN:DAYLIGHT");
            str.AppendLine("TZNAME:BST");
            str.AppendLine("TZOFFSETFROM:+0000");
            str.AppendLine("TZOFFSETTO:+0100");
            str.AppendLine("DTSTART:19700329T010000");
            str.AppendLine("RRULE:FREQ=YEARLY;BYMONTH=3;BYDAY=-1SU");
            str.AppendLine("END:DAYLIGHT");
            str.AppendLine("BEGIN:STANDARD");
            str.AppendLine("TZNAME:GMT");
            str.AppendLine("TZOFFSETFROM:+0100");
            str.AppendLine("TZOFFSETTO:+0000");
            str.AppendLine("DTSTART:19701025T020000");
            str.AppendLine("RRULE:FREQ=YEARLY;BYMONTH=10;BYDAY=-1SU");
            str.AppendLine("END:STANDARD");
            str.AppendLine("END:VTIMEZONE");


            for (int j = 0; j < datas.Count; j++)
            {
                str.AppendLine("BEGIN:VEVENT");
                str.AppendLine(string.Format("DTSTART;TZID=Europe/London:{0:yyyyMMddTHHmmss}", datas[j]));
                str.AppendLine(string.Format("DTSTAMP:{0:yyyyMMddTHHmmssZ}", DateTime.UtcNow));
                str.AppendLine(string.Format("DTEND;TZID=Europe/London:{0:yyyyMMddTHHmmss}", datas[j]));
                str.AppendLine("LOCATION:Plataforma GESQUAR");
                str.AppendLine(string.Format("UID:{0}", Guid.NewGuid()));
                str.AppendLine("SEQUENCE:1655985539");
                str.AppendLine(string.Format("DESCRIPTION:{0}", bodyMail[j]));
                str.AppendLine(string.Format("X-ALT-DESC;FMTTYPE=text/html:{0}", bodyMail[j]));
                str.AppendLine(string.Format("SUMMARY:{0}", msg.Subject));
                for (int i = 0; i < msg.To.Count; i++)
                    str.AppendLine(string.Format("ATTENDEE;CN=\"{0}\";ROLE=REQ-PARTICIPANT;PARTSTAT=NEEDS-ACTION;RSVP=TRUE:mailto:{1}",  msg.To[i].Address, msg.To[i].Address));
                str.AppendLine(string.Format("ORGANIZER:MAILTO:{0}", msg.From.Address));
                str.AppendLine(string.Format("TRANSP:OPAQUE"));
                str.AppendLine("PRIORITY:5");
                str.AppendLine("CLASS:PUBLIC");
                str.AppendLine("BEGIN:VALARM");
                str.AppendLine("TRIGGER:-PT55M");
                str.AppendLine("ACTION:DISPLAY");
                str.AppendLine("DESCRIPTION:Reminder");
                str.AppendLine("END:VALARM");
                str.AppendLine("END:VEVENT");
            }

            str.AppendLine("END:VCALENDAR");
            
            
            //MessageBox.Show(str.ToString());

            //Guardar o ficheiro ics em memória
            byte[] byteArray = Encoding.UTF8.GetBytes(str.ToString());
            MemoryStream stream = new MemoryStream(byteArray);


            System.Net.Mime.ContentType contype = new System.Net.Mime.ContentType("text/calendar"); //Content type text/calendar para que o mail tenha o formato de calendário
            contype.CharSet = "UTF-8";  //Charset para o mail incluir todos os caracteres
            contype.Parameters.Add("method", "REQUEST");
            contype.Parameters.Add("name", "Meeting2.ics");

            //Anexo do email (ficheiro ics)
            System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(stream, contype);
            att.TransferEncoding = System.Net.Mime.TransferEncoding.QuotedPrintable;
            msg.Attachments.Add(att);


            AlternateView avCal = AlternateView.CreateAlternateViewFromString(str.ToString(), contype);
            avCal.TransferEncoding = System.Net.Mime.TransferEncoding.QuotedPrintable;
            msg.AlternateViews.Add(avCal);

            //Enviar email
            client.Send(msg);



            //Fazer ligação ao outlook com a sessão atual ligada no outlook
            //Outlook._Application olApp = (Outlook._Application)new Outlook.Application();
            //Outlook.NameSpace mapins = olApp.GetNamespace("MAPI");
            //string profile = "";
            //mapins.Logon(profile, null, null, null);


            //if (checkBox1.Checked == true)
            //{
            //for(int i = 0; i < datas.Count; i += 2)
            //{
            //    int cont = 0;

            //    CreateAppointment(olApp, textBox1.Text, textBox3.Text, datas[i], datas[i + 1]);   //Criar compromisso no calendário

            //    cont ++;
            //}


            //Criar compromisso no calendário
            //CreateYearlyAppointment(olApp, textBox1.Text, textBox3.Text, new DateTime(dateTimePicker2.Value.Year,
            //                    dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, 0, 0, 0), new DateTime(dateTimePicker1.Value.Year,
            //                    dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 0, 0, 0), true, convertNumericUpDown);
            //}
            //else
            //{
            //    for (int j = 0; j < datas.Count; j += 2)
            //        CreateYearlyTask(olApp, textBox1.Text, textBox3.Text, datas[j], datas[j + 1]);


            //Criar compromisso no calendário
            //CreateYearlyAppointment(olApp, textBox1.Text, textBox3.Text, new DateTime(dateTimePicker2.Value.Year,
            //                        dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, dateTimePicker2.Value.Hour,
            //                        dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second), new DateTime(dateTimePicker1.Value.Year,
            //                        dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, dateTimePicker2.Value.Hour,
            //                        dateTimePicker1.Value.Minute, dateTimePicker1.Value.Second), false, convertNumericUpDown);
            //}
        }

        //Função para criar compromisso no calendário
        private void CreateAppointment(Outlook._Application olApp, string reminderComment, string subject, DateTime dtStart, DateTime dtEnd)
        {
            //Nova instância do outlook
            //Outlook.Application app = new Outlook.Application();
            //Outlook._TaskItem tsk = (Outlook._TaskItem)app.CreateItem(Outlook.OlItemType.olTaskItem);

            //tsk.StartDate = DateTime.Now;
            //tsk.DueDate = DateTime.Now;
            //tsk.Subject = "Test";
            //tsk.Body = "Testing Task";
            //tsk.Recipients.Add("lserapicos@drapnorte.gov.pt");
            //tsk.Assign();
            //tsk.Save();


            //Parâmetros para o compromisso
            Outlook._AppointmentItem apt = (Outlook._AppointmentItem)olApp.CreateItem(Outlook.OlItemType.olAppointmentItem);

            apt.MeetingStatus = Microsoft.Office.Interop.Outlook.OlMeetingStatus.olMeeting;
            apt.Subject = subject;
            apt.Body = reminderComment;
            apt.Start = dtStart;
            apt.End = dtEnd;
            apt.ReminderMinutesBeforeStart = 60 * 24 * 3 * 1;
            apt.BusyStatus = Outlook.OlBusyStatus.olFree;
            apt.Location = "";

            //Ocorrer todos os anos
            //Outlook.RecurrencePattern myPattern = apt.GetRecurrencePattern();
            //myPattern.RecurrenceType = Outlook.OlRecurrenceType.olRecursYearly;

            //Outlook.Accounts mail = olApp.Session.Accounts; //???
            //foreach (Outlook.Account acc in mail)
            //{
                //MessageBox.Show(acc.SmtpAddress);

                string emailAddresses = textBox4.Text;
                string[] emails = emailAddresses.Split(';');

                foreach (var email in emails)
                {
                    email.Replace(" ", String.Empty);

                    Outlook.Recipient recipient = apt.Recipients.Add(email);
                    recipient.Type =
                            (int)Outlook.OlMeetingRecipientType.olRequired;
                    ((Outlook._AppointmentItem)apt).Send();

                    ((Outlook._AppointmentItem)apt).Save();
                    //apt.Display(true);
                }
                //((Outlook._TaskItem)apt).Assign();
                //((Outlook._TaskItem)apt).Recipients.ResolveAll();
                //((Outlook._TaskItem)apt).Send();

                //((Outlook._TaskItem)apt).Save();
            //}

            //string emailAddresses = textBox4.Text;
            //string[] emails = emailAddresses.Split(';');

            //foreach (var email in emails)
            //{
            //    email.Replace(" ", String.Empty);
            //    //System.Console.WriteLine($"<{email}>");

            //    Outlook.Recipient recipient =
            //        tsk.Recipients.Add(email);
            //    recipient.Type =
            //        (int)Outlook.OlMeetingRecipientType.olRequired;
            //    ((Outlook._TaskItem)tsk).Assign();
            //    ((Outlook._TaskItem)tsk).Send();
            //}
        }

        //Função que verifica se a checkbox foi marcada/desmarcada
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true)
            //{
            //    dateTimePicker2.CustomFormat = "dddd dd-MM-yyyy";
            //    dateTimePicker1.CustomFormat = "dddd dd-MM-yyyy";

            //    textBox2.Text = dateTimePicker2.Value.ToLongDateString().ToString();
            //    textBox5.Text = dateTimePicker1.Value.ToLongDateString().ToString();
            //}
            //else
            //{
            //    dateTimePicker2.CustomFormat = "dddd dd-MM-yyyy HH:mm:ss tt";
            //    dateTimePicker1.CustomFormat = "dddd dd-MM-yyyy HH:mm:ss tt";

            //    textBox2.Text = dateTimePicker2.Value.ToLongDateString().ToString() + " "
            //                                + dateTimePicker2.Value.ToShortTimeString().ToString();
            //    textBox5.Text = dateTimePicker1.Value.ToLongDateString().ToString() + " "
            //                                + dateTimePicker1.Value.ToShortTimeString().ToString();
            //}
        }

        //Função que controla o comportamento do input de calendário
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == false)
            //    textBox5.Text = dateTimePicker1.Value.ToLongDateString().ToString() + " "
            //                                + dateTimePicker1.Value.ToShortTimeString().ToString();
            //else
                textBox5.Text = dateTimePicker1.Value.ToLongDateString().ToString();
        }

        //Função que controla o comportamento do input numérico
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        //Função que controla o comportamento do input de calendário (apenas datas)
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        //Funcção iniciada quando é pressionado o botão em questão
        private void button2_Click(object sender, EventArgs e)
        {
            //DateTime[] myDates = { dateTimePicker1.Value, dateTimePicker2.Value };

            //monthCalendar1.BoldedDates = myDates;

            //foreach (DateTime date in myDates)
            //    MessageBox.Show(date.ToString());


            datas.Add(dateTimePicker2.Value);   //Após clicar no botão, adiciona a data inserida numa lista
            //datas.Add(dateTimePicker1.Value);
            bodyMail.Add(textBox1.Text);        //Após clicar no botão, adiciona o texto inserido numa lista

            //Construir string que mostra o texto e a data inseridos
            StringBuilder comp = new StringBuilder();
            for (int i = 0; i < datas.Count; i++ )
                comp.AppendLine("Adicionou o aviso: " + bodyMail[i].ToString() + " em " + datas[i].ToLongDateString() + " às " + datas[i].ToShortTimeString());

            MessageBox.Show(comp.ToString());

            //if (checkBox1.Checked == true)
            //{
            //    datasLembrete.Add(dateTimePicker3.Value);

            //    for (int i = 0; i < datas.Count; i += 2)
            //    {
            //        int cont = 0;

            //        MessageBox.Show("Foi marcada a tarefa de " + datas[i].ToString() + " até " + datas[i + 1].ToString() + " e lembrete para " + datasLembrete[cont].ToString() + " .\n");

            //        cont ++;

            //    }
            //}
            //else
            //{
            //    for (int j = 0; j < datas.Count; j += 2)
            //        MessageBox.Show("Foi marcada a tarefa de " + datas[j].ToString() + " até " + datas[j + 1].ToString() + " .\n");
            //}

            //dateTimePicker1.Value = dateTimePicker1.MinDate;
            dateTimePicker2.Value = dateTimePicker2.MinDate;    //Redefinir valor do input de calendário
            //dateTimePicker3.Value = dateTimePicker3.MinDate;

            //checkBox1.Checked = false;

            textBox1.Text = "";                                 //Redefinir texto da caixa de texto para vazio


            //Depois de clicar no botão, é apresentada uma outra view (Lista de avisos)
            //form2.Size = new Size(1500, 500);
            //form2.Show();
        }

        //Função que controla o comportamento do input de calendário
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == false)
            //    textBox6.Text = dateTimePicker3.Value.ToLongDateString().ToString() + " "
            //                                + dateTimePicker3.Value.ToShortTimeString().ToString();
            //else
            //textBox6.Text = dateTimePicker3.Value.ToLongDateString().ToString();
        }

        //Função que verifica se a checkbox foi marcada/desmarcada
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true)
            //{
            //    textBox6.Enabled = true;
            //    dateTimePicker3.Enabled = true;
            //}
            //else
            //{
            //    textBox6.Enabled = false;
            //    dateTimePicker3.Enabled = false;
            //}
        }
    }
}
