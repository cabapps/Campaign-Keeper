using System;

namespace CampaignKeeperPcl
{
    public struct CampaignDate
    {
        public int Day;
        public int Month;
        public int Year;

        public override string ToString()
        {
            return base.ToString();
        }

        public string ToString(string format)
        {
            switch (format.ToUpper())
            {
                case "S":
                    return $@"{Month}/{Day}/{Year}";
                default:
                    return $"{GetMonth()} {Day}, {Year}";
            }
        }

        private string GetMonth()
        {
            switch (Month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return string.Empty;
            };
        }
    }
}