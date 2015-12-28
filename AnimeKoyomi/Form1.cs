using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using HorriblesubsScheduleFetcher;
using NodaTime;

namespace AnimeKoyomi
{
    public partial class Form1 : Form
    {
        private DateTimeZone userTimeZone = DateTimeZoneProviders.Tzdb["US/Pacific"];
        private ListViewGroupCollection listViewGroups;

        private List<ScheduleItem> downloadedSchedule;

        private CalendarService calendarService;

        ////////////////
        // UI Methods
        //////////////// 
        
        public Form1()
        {
            InitializeComponent();

            this.DownloadSchedule();
            this.timezoneDropdown.DataSource = DateTimeZoneProviders.Tzdb.Ids;

            if (this.CredentialsDirectoryExists()) this.GoogleAccountAuthentication();
        }

        private void DownloadClick(object sender, EventArgs e)
        {
            this.DownloadSchedule();
        }

        private void scheduleListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) e.Item.Selected = false;
        }
        
        private void GoogleLoginButton_Click(object sender, EventArgs e)
        {
            this.GoogleAccountAuthentication();
        }
        
        private void timezoneDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The user selected a timezone, refresh times for each item

            this.userTimeZone 
                = DateTimeZoneProviders.Tzdb[(string)this.timezoneDropdown.SelectedItem];

            this.RefreshLocalTimes();
        }

        ////////////////////
        // Backend methods
        ////////////////////

        private void DownloadSchedule()
        {
            this.scheduleListView.Items.Clear();

            this.listViewGroups = this.scheduleListView.Groups;
            
            this.downloadedSchedule = new HorriblesubsScheduleFetcher.Fetcher().Fetch();

            foreach (var item in this.downloadedSchedule)
            {
                var newItem = this.ScheduleItemToListViewItem(item);
                this.scheduleListView.Items.Add(newItem);
            }
        }

        private void RefreshLocalTimes()
        {
            if (this.downloadedSchedule != null)
            {
                this.scheduleListView.Items.Clear();

                if(this.listViewGroups == null) 
                    this.listViewGroups = this.scheduleListView.Groups;

                foreach (var item in this.downloadedSchedule)
                {
                    var newItem = this.ScheduleItemToListViewItem(item);
                    this.scheduleListView.Items.Add(newItem);
                }
            }
            else
            {
                this.DownloadSchedule();
            }
        }

        private ListViewItem ScheduleItemToListViewItem(ScheduleItem item)
        {
            var newItem = new ListViewItem(listViewGroups[(int)item.weekday]);

            newItem.Text = item.seriesName;

            var localTime = this.ConvertToLocalTime(item.airTime);

            if (this.CarriesOverToNextDay(item.airTime))
            {
                if ((int)item.weekday <= 5)
                {
                    newItem.Group = listViewGroups[((int)item.weekday + 1)];
                }
                else if ((int)item.weekday == 6)
                {
                    newItem.Group = listViewGroups[0];
                }
            }
            else if (this.CarriesOverToPreviousDay(item.airTime))
            {
                if ((int)item.weekday >= 1)
                {
                    newItem.Group = listViewGroups[((int)item.weekday - 1)];
                }
                else if ((int)item.weekday == 0)
                {
                    newItem.Group = listViewGroups[6];
                }
            }

            var localTimeString = string.Format("{0:00}:{1:00}", localTime.Hour, localTime.Minute);
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, localTimeString));

            return newItem;
        }

        private ZonedDateTime ConvertToLocalTime(ZonedDateTime time)
        {
            return time.ToInstant().InZone(this.userTimeZone);
        }

        private bool CarriesOverToNextDay(ZonedDateTime time)
        {
            var localTime = time.ToInstant().InZone(this.userTimeZone);

            if (localTime.Day > time.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CarriesOverToPreviousDay(ZonedDateTime time)
        {
            var localTime = time.ToInstant().InZone(this.userTimeZone);

            if (localTime.Day < time.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void GoogleAccountAuthentication()
        {
            var service = GoogleAuth.Authenticate();

            if (service != null)
            {
                this.loggedInLabel.Text = "Logged in successfully.";
                this.GoogleLoginButton.Enabled = false;
                this.calendarService = service;

                this.OnSuccessfulAuth();
            }
            else
            {
                this.loggedInLabel.Text = "Error, please try again.";
            }
        }

        private bool CredentialsDirectoryExists()
        {
            string credPath = 
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            credPath = Path.Combine(credPath, ".credentials/animekoyomi");

            return Directory.Exists(credPath);
        }

        private void OnSuccessfulAuth()
        {
            this.googleCalendarBox.Enabled = true;
            this.calendarLabel.Enabled = true;
            this.calendarWarning.Enabled = true;
            this.calendarDropdown.Enabled = true;
            this.submitButton.Enabled = true;

            var calendarList = this.calendarService.CalendarList.List().Execute().Items;
            var calendarNameList = new List<string>();

            foreach (var calendar in calendarList)
            {
                calendarNameList.Add(calendar.Summary);
            }

            this.calendarDropdown.DataSource = calendarNameList;
        }
    }
}
