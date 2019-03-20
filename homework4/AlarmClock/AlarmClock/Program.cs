using System;
using System.Threading.Tasks;

namespace AlarmClock
{
    public class AlarmClock
    {
        private DateTime TargetTime;
        private string matter;
        //声明委托类型
        public delegate void AlarmEventsHandler(DateTime TargetTime, string matter);
        //声明事件
        public event AlarmEventsHandler AlarmEvent;       

        public AlarmClock(DateTime TargetTime, string matter)
        {
            this.TargetTime = TargetTime;
            this.matter = matter;
        }
        //计时器
        public void CountTime()
        {
            while (DateTime.Now <= TargetTime)
            {
                if (AlarmEvent != null)
                {   //如果有对象注册
                    AlarmEvent(TargetTime, matter);  //调用所有注册对象的方法
                    System.Threading.Thread.Sleep(1000);
                    if (DateTime.Now < TargetTime) { Console.Clear(); }
                }
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("请输入闹钟时间:");
                DateTime TargetTime; DateTime.TryParse((Console.ReadLine()), out TargetTime);
                Console.WriteLine("请输入闹钟事件:");
                string matter = Console.ReadLine();
                AlarmClock AlarmClock = new AlarmClock(TargetTime, matter);

                AlarmClock.AlarmEvent += DisplayCount;
                AlarmClock.AlarmEvent += MatterCome;

                AlarmClock.CountTime();   //开始计时

            }
            //TimeSpan监控剩余时间,值为0时事件触发
            public static void DisplayCount(DateTime TargetTime, string matter)
            {
                TimeSpan tleft = TargetTime - DateTime.Now;
                Console.WriteLine("距离事件" + matter + "还有"+ tleft.Hours.ToString() + "时" + tleft.Minutes.ToString() + "分" + tleft.Seconds.ToString() + "秒");
            }

            public static void MatterCome(DateTime TargetTime, string matter)
            {
                if ((TargetTime - DateTime.Now).Seconds.ToString() == "0")
                {
                    Console.WriteLine("事件" + matter + "时间到了!!!");

                }

            }
        }
    }
}