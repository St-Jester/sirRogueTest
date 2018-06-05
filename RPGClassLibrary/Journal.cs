using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassLibrary
{
    public class Journal
    {
        public Dictionary<string, string> JournalRecords { get; set; }

        public Journal()
        {
            JournalRecords = new Dictionary<string, string>();
        }
        public void AddRecord(string _recordName, string _record)
        {
            JournalRecords.Add(_recordName, _record);
        }
    }
}
