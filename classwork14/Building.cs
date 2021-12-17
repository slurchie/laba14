using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork14
{
	[BuildingInfo("slurchie", "hqd")]
	public class Building
        {
            private static int IDcounter;
            public int ID;
            public double height;
            public int flats;
            public int floors;
            

            static Building() => IDcounter = 0;

            public Building(double height = 9, int flats = 9, int floors = 3)
            {
                ID = IDcounter++;
                this.height = height;
                this.flats = flats;
                this.floors = floors;
               
            }
	
		public double High
		{
			get
			{
				return height;
			}
			set
			{
				if (value > 0)
				{
					height = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException("Значение может быть только положительным числом.");
				}
			}

		}
		public int Floors
		{
			get
			{
				return floors;
			}
			set
			{
				if (value > 0)
				{
					floors = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException("Значение может быть только натуральным числом.");
				}
			}

		}
		public int Flats
		{
			get
			{
				return flats;
			}
			set
			{
				if (value > 0)
				{
					flats = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException("Значение может быть только натуральным числом.");
				}
			}
		}
		
		
		
		
		public override string ToString() => $"ID здания: {ID}";
        }
    }

