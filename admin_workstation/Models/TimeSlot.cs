using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Models
{
    public enum TimeSlot
    {
        Slot_10_11,
        Slot_11_12
    }

    public static class TimeSlotExtensions
    {
        public static string ToDisplayString(this TimeSlot slot)
        {
            return slot switch
            {
                TimeSlot.Slot_10_11 => "10:00-11:00",
                TimeSlot.Slot_11_12 => "11:00-12:00",
                _ => throw new ArgumentException("Invalid time slot")
            };
        }

        public static TimeSlot FromDisplayString(string display)
        {
            return display switch
            {
                "10:00-11:00" => TimeSlot.Slot_10_11,
                "11:00-12:00" => TimeSlot.Slot_11_12,
                _ => throw new ArgumentException("Invalid time slot string")
            };
        }
    }
}
