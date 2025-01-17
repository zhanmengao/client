﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Runtime.Serialization;
using System.Reflection;
namespace NetFrame
{　
    public class SerializeUtil
    {
        /// <summary>
        /// 对象序列化（传输层）
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] encode(object value)
        {
            MemoryStream ms = new MemoryStream();                  //创建编码解码的内存流对象
            BinaryFormatter bw = new BinaryFormatter();           //二进制流序列化对象
            bw.Serialize(ms, value);                                            //将obj对象序列化成二进制数据 写入到 内存流
            byte[] result = new byte[ms.Length];
            //将流数据 拷贝到结果数组
            Buffer.BlockCopy(ms.GetBuffer(), 0, result, 0, (int)ms.Length);
            ms.Close();
            return result;
        }

        public class UBinder : SerializationBinder
        {
            public override Type BindToType(string assemblyName, string typeName)
            {
                Assembly ass = Assembly.GetExecutingAssembly();
                return ass.GetType(typeName);
            }
        }
        /// <summary>
        /// 反序列化对象（传输层）
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object decode(byte[] value)
        {
            MemoryStream ms = new MemoryStream(value);                //创建编码解码的内存流对象 并将需要反序列化的数据写入其中
            BinaryFormatter bw = new BinaryFormatter();               //二进制流序列化对象
            bw.Binder = new UBinder();
            object result = bw.Deserialize(ms);                       //将流数据反序列化为obj对象
            ms.Close();
            return result;
        }
    }
}
