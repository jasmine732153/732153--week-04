﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)




        {
            countryside blue = new countryside();

        }

        class village
        {
            public village nextvillage;
            public village previousvillage;
            public string villagename;
            public bool isaAstrildeHere = false;
        }
        class countryside
        {
            village maple = new village();


            village toronto = new village();

            village ajax = new village();
            village first;
            village last;
            village Temp;
          


            public void launch()
            {
               
                first = maple;
                last = ajax;
                maple.villagename = "maple";
                maple.nextvillage = toronto;
                toronto.villagename = "toronto";
                toronto.nextvillage = ajax;
                toronto.previousvillage = maple;
                ajax.villagename = "ajax";
                ajax.nextvillage = null;
                ajax.nextvillage = toronto;
                Console.WriteLine( this.displaymap());
            }
            public string displaymap()
            {
                string listofcities = "";
                
                    listofcities = listofcities + first.villagename + "---";
                    Temp = first.nextvillage;
                  listofcities = listofcities + Temp.villagename + "---";


                return listofcities;
            }
          
        }


        
    }
    

}
