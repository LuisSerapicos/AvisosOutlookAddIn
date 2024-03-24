using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace OutlookAddIn2
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //try
            //{
            //    Outlook.AppointmentItem newAppointment =
            //        (Outlook.AppointmentItem)
            //    this.Application.CreateItem(Outlook.OlItemType.olAppointmentItem);
            //    newAppointment.Start = DateTime.Now.AddHours(2);
            //    newAppointment.End = DateTime.Now.AddHours(3);
            //    newAppointment.Location = "ConferenceRoom #2345";
            //    newAppointment.Body =
            //        "We will discuss progress on the group project.";
            //    newAppointment.AllDayEvent = false;
            //    newAppointment.Subject = "Group Project";
            //    newAppointment.Recipients.Add("lserapicos@drapnorte.gov.pt");
            //    Outlook.Recipients sentTo = newAppointment.Recipients;
            //    Outlook.Recipient sentInvite = null;
            //    sentInvite = sentTo.Add("Holly Holt");
            //    sentInvite.Type = (int)Outlook.OlMeetingRecipientType
            //        .olRequired;
            //    sentInvite = sentTo.Add("David Junca ");
            //    sentInvite.Type = (int)Outlook.OlMeetingRecipientType
            //        .olOptional;
            //    sentTo.ResolveAll();
            //    newAppointment.Save();
            //    newAppointment.Display(true);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("The following error occurred: " + ex.Message);
            //}

            //Form1 form = new Form1();
            //form.Show();

            //Outlook.AppointmentItem agendaMeeting = (Outlook.AppointmentItem)
            //    this.Application.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olAppointmentItem);

            //if (agendaMeeting != null)
            //{
            //    agendaMeeting.MeetingStatus =
            //        Microsoft.Office.Interop.Outlook.OlMeetingStatus.olMeeting;
            //    //agendaMeeting.Location = form;
            //    agendaMeeting.Subject = "Discussing the Agenda";
            //    agendaMeeting.Body = "Let's discuss the agenda.";
            //    agendaMeeting.Start = new DateTime(2022, 02, 15, 13, 0, 0);
            //    agendaMeeting.End = new DateTime(2022, 02, 15, 14, 0, 0);
            //    Outlook.Recipient recipient =
            //        agendaMeeting.Recipients.Add("lserapicos@drapnorte.gov.pt");
            //    recipient.Type =
            //        (int)Outlook.OlMeetingRecipientType.olRequired;
            //    ((Outlook._AppointmentItem)agendaMeeting).Send();
            //}
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Nota: o Outlook não aciona mais esse evento. Se você tiver o código que 
            //    deve ser executado quando o Outlook é desligado, consulte https://go.microsoft.com/fwlink/?LinkId=506785
        }

        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new Ribbon2();
        }

        #region Código gerado por VSTO

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
