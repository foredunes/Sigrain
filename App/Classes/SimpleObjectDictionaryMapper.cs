using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sigran.Classes
{

    /*Sample s = new Sample();
    s.Id = 100;
    s.Amostra = "S1";
    s.Categoria = "BERMA";

    IDictionary<string, object> d = SimpleObjectDictionaryMapper<Sample>.GetDictionary(s);

    Console.WriteLine("---------------" + d["Id"]);
    */


    /*

    IDictionary<string, object> dd = new Dictionary<string, object>();
    dd.Add("Id", 10);
    dd.Add("Amostra", "Cascalho");
    Sample oo = SimpleObjectDictionaryMapper<Sample>.GetObject(dd);

    Console.WriteLine("---------------" + oo.Amostra);
    */

    public class SimpleObjectDictionaryMapper<TObject>
    {
        public static TObject GetObject(IDictionary<string, object> d)
        {
            PropertyInfo[] props = typeof(TObject).GetProperties();
            TObject res = Activator.CreateInstance<TObject>();
            for (int i = 0; i < props.Length; i++)
            {
                if (props[i].CanWrite && d.ContainsKey(props[i].Name))
                {
                    props[i].SetValue(res, d[props[i].Name], null);
                }
            }
            return res;
        }

        public static IDictionary<string, object> GetDictionary(TObject o)
        {
            IDictionary<string, object> res = new Dictionary<string, object>();
            PropertyInfo[] props = typeof(TObject).GetProperties();
            for (int i = 0; i < props.Length; i++)
            {
                if (props[i].CanRead)
                {
                    res.Add(props[i].Name, props[i].GetValue(o, null));
                }
            }
            return res;
        }
    }
}
