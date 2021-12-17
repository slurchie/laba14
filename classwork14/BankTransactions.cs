using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork14
{
    public class BankTransaction
    {
		
			public readonly DateTime dateTime;
			public readonly decimal balance;
			public BankTransaction(decimal balance)
			{
				this.balance = balance;
				dateTime = DateTime.Now;
			}
			public override string ToString()
			{
				return $"{dateTime.ToShortDateString()} {dateTime.ToLongTimeString()} {balance}";
			}
		}
	}

