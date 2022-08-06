using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UnoMvvmSample.Models
{
	public partial class Model
	{
		private string outputTxt;
		public Model()
		{
			outputTxt = "Hello from INTELLIZ";
		}

		public String OutputTxt
		{
			get
			{
				return outputTxt;
			}
			set
			{
				outputTxt = value;
			}
		}
		


	}



	
}
