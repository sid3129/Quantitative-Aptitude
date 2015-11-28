using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.ViewModels
{
    public class GotoMain
    {
        public List<GotoQues> items { get; set; }
        public GotoMain()
        {
            items = new List<GotoQues>();
        }
        public void Load(int ctr)
        {
            for (int i = 1; i <= ctr; i++)
            {
                items.Add(new GotoQues { number = i.ToString() }); 
            }
           
          
        }
    }
}
