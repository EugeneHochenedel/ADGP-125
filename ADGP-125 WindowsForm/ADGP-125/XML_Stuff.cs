using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace ADGP_125
{
	public class XML_Stuff<T>
	{
		public XML_Stuff()
		{
		}

		public void Seralization(string Files, T Info)
		{
			using (FileStream fStream = File.Create(@"..\..\Saves\" + Files + ".xml"))
			{
				SoapFormatter _serialize = new SoapFormatter();
				_serialize.Serialize(fStream, Info);
				fStream.Close();
			}
		}

		public T Deserialization(string Files)
		{
			T tCharacter;
			using (FileStream fStream = File.OpenRead(@"..\..\Saves\" + Files + ".xml"))
			{
				SoapFormatter _deseraialization = new SoapFormatter();
				tCharacter = (T)_deseraialization.Deserialize(fStream);
				fStream.Close();
			}
			return tCharacter;
		}
	}
}
