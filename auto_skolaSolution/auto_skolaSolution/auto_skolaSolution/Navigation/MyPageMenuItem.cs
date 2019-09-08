using auto_skolaSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_skolaSolution.Navigation
{

    public class MyPageMenuItem
    {
        public MyPageMenuItem()
        {
            TargetType = typeof(MainPage);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}