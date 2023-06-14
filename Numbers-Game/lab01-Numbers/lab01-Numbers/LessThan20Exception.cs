using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab01_Numbers
{
	public class LessThan20Exception: Exception
	{
	public LessThan20Exception(string message):base(message) { }
	}
}
