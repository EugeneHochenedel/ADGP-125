using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
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
			using (FileStream fStream = File.Create(Program.SaveDataDirectory + Files + ".xml"))
			{
				XmlSerializer _serialize = new XmlSerializer(typeof(T));
				_serialize.Serialize(fStream, Info);
				fStream.Close();
			}
		}

		public T Deserialization(string Files)
		{
			
			T tCharacter;
			using (FileStream fStream = File.OpenRead(Program.SaveDataDirectory + Files + ".xml"))
			{
				XmlSerializer _deserialization = new XmlSerializer(typeof(T));
				tCharacter = (T)_deserialization.Deserialize(fStream);
				fStream.Close();
			}
			return tCharacter;
		}
	}
}