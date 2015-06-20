
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManager
{

    //class Program
    //{
    //    private static Conference _testConference;
    //    private static TalkDuration _duration;
    //    private static IScheduler _scheduler;
    //    private static List<Track> _tracks;
    //    private static List<Day> _days;
    //    static void Main(string[] args)
    //    {
    //        _duration = new TalkDuration(TimeUnit.Min, 60);
    //        _scheduler = new SimpleScheduler();
    //        SetDaysSchedule();
    //        _testConference = new Conference(_scheduler, _days);
    //        _testConference.ResultFormatter = new TextFileFormatter();
    //    }
    //    private static void SetDaysSchedule()
    //    {
    //        _days = new List<Day>();

    //        _tracks = new List<Track>();
    //        for (var i = 0; i < 2; i++)
    //        {
    //            _tracks.Add(Helper.GetNewTrack());
    //        }

    //        _days.Add(new Day(_tracks));
    //    }
    //}
}
