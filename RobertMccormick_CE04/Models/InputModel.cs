using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformTutorial.Models
{
    //model contains user inputs
    public class InputModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public decimal Quantity { get; set; }
        public DateTime ImportDate { get; set; }

        public int ImageIndex { get; set; }

        public InputModel()
        {
            
        }
        
        public override string ToString()
        {
            return String.Format("Name: {0}, IsActive: {1}, Quantity {2}, ImportDate:{3}", Name, IsActive, Quantity, ImportDate);
        }
    }
}
