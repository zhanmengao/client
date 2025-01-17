﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
/*
 * 消息体粘包工具
 */
namespace NetFrame
{
    public class LengthEncoding
    {
        /// <summary>
        /// 粘包长度编码
        /// </summary>
        /// <param name="buff"></param>
        /// <returns></returns>
        public static byte[] encode(byte[] buff)
        {
            MemoryStream ms = new MemoryStream();         //创建内存流对象
            BinaryWriter sw = new BinaryWriter(ms);       //写入二进制对象流

            sw.Write(buff.Length);                        //写入消息长度
            sw.Write(buff);                              //写入消息体

            byte[] result = new byte[ms.Length];
            Buffer.BlockCopy(ms.GetBuffer(), 0, result, 0, (int)ms.Length);
            sw.Close();
            ms.Close();
            return result;
        }

        /// <summary>
        /// 粘包长度解码
        /// </summary>
        /// <param name="cache"></param>
        /// <returns></returns>
        public static byte[] decode(ref List<byte> cache)
        {
            if (cache.Count < 4) return null;

            MemoryStream ms = new MemoryStream(cache.ToArray());       //创建内存流对象，并将缓存数据写入进去
            BinaryReader br = new BinaryReader(ms);                                          //二进制读取流
            int length = br.ReadInt32();


            if (length > ms.Length - ms.Position)
            {
                return null;
            }

            byte[] result = br.ReadBytes(length);                                                       //读取正确长度的数据
            cache.Clear();

            cache.AddRange(br.ReadBytes((int)(ms.Length - ms.Position)));               //将读取后的剩余数据写入缓存
            br.Close();
            ms.Close();
            return result;
        }
    }
}
