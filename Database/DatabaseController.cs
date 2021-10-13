using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace UCLFlix.Database
{
    public static class  DatabaseController
    {
        public static void SaveDatabase<T>( this List<T> objeto, string tabela){
            FileStream arq = new FileStream(tabela + ".txt", FileMode.Create);
            BinaryFormatter serial = new BinaryFormatter();
            serial.Serialize(arq, objeto);
            arq.Close();
        }

        public static List<T> GetDatabase<T>(string tabela){
            List<T> info = new List<T>();
            FileStream arq = new FileStream( tabela+".txt", FileMode.Open);
            if( arq.Length == 0 ){
            return info;
            }
            BinaryFormatter serial = new BinaryFormatter();
            info = (List<T>) serial.Deserialize(arq);
            arq.Close();
            return info;
        }
    }
}