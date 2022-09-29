using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modern_Real_Estates_DAL
{
    [Serializable]
    public class ListManager<T> : IListManager<T>
    {

        List<T> list;

        public ListManager()
        {
            list = new List<T>();
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool Add(T aType)
        {
            if (aType != null)
            {
                list.Add(aType);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BinarySerialize(string fileName)
        {
            using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, list);
                return true;
            }
        }

        public bool BinaryDeSerialize(string fileName)
        {
            using (Stream stream = File.Open(fileName, FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();
                list = (List<T>)bin.Deserialize(stream);
                return true;
            }
        }

        public bool ChangeAt(T aType, int anIndex)
        {
            if (aType != null)
            {
                list[anIndex] = aType;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIndex(int index)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            list.Clear();
            list = null;
        }

        public bool DeleteAt(int anIndex)
        {
            if (anIndex >= 0)
            {
                list.RemoveAt(anIndex);
                return true;
            }
            else
            {
                return false;
            }
        }

        public T GetAt(int anIndex)
        {
            if (anIndex >= 0)
            {
                return list[anIndex];
            }
            return default;
        }

        public string[] ToStringArray()
        {
            string[] listToStringArray = new string[list.Count];
            for (int i = 0; i < Count; i++)
            {
                listToStringArray[i] = list[i].ToString();
            }
            return listToStringArray;
        }

        public List<string> ToStringList()
        {
            throw new NotImplementedException();
        }

        public bool XMLSerialize(string fileName)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            TextWriter w = new StreamWriter(fileName);
            string errorMsg = null;
            try
            {
                s.Serialize(w, list);
                return true;
            }
            catch (Exception e)
            {
                errorMsg = e.Message;
                return false;
            }
            finally
            {
                if (w != null)
                    w.Close();
            }
        }
    }
}
