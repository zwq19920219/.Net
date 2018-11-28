using System;
using System.Timers;

namespace 计算器
{
    public class GxTime
    {
        private DateTime _currnetTime = new DateTime();
        private Timer _timer = new Timer();

        /// <summary>
        /// 构造函数
        /// </summary>
        public GxTime()
        {
            Console.WriteLine("HelloWorld");
        }

        /// <summary>
        /// 当前时间属性
        /// </summary>
        /// <value>The current time.</value>
        public DateTime CurrentTime
        {

            get
            {
                return _currnetTime;
            }
            set
            {
                _currnetTime = value;
            }
        }

        /// <summary>
        /// Shows the time.
        /// </summary>
        public void ShowTime()
        {
            Console.WriteLine(string.Format("当前系统时间:{0}", DateTime.Now));
        }

    }
}
