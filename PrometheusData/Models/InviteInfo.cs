using System;

namespace PrometheusData.Models
{
    public class InviteInfo
    {
        public Person Person { get; set; }
        public Person Inviter { get; set; }
        public DateTime Date { get; set; }
        public Place Place { get; set; }
    }
}