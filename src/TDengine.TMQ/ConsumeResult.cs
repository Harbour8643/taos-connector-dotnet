﻿using System;
using System.Collections.Generic;
using TDengineDriver;

namespace TDengineTMQ
{
    /// <summary>
    /// Represent the consumer result's TKey.
    /// </summary>
    public struct TopicPartition
    {
        internal string topic { get; set; }
        internal int vGroupId { get; set; }
        internal string db { get; set; }
        internal string table { get; set; }
        internal IntPtr taosResPtr { get; set; }

        public TopicPartition(string topic, int vGroupId, string db, string table,IntPtr msg)
        {
            this.topic = topic;
            this.vGroupId = vGroupId;
            this.db = db;
            this.table = table;
            this.taosResPtr = msg;
        }
        public string ToString()
        {
            return $"topic:{this.topic}+\n + vGroupId:{this.vGroupId.ToString()} + \n + db:{this.db} + \n + table:{this.table}";
        }
    }

    /// <summary>
    ///  Represent consume result.
    /// </summary>
    public class ConsumeResult
    {
        public TopicPartition TopicPartition { get; set; }
        /// <summary>
        /// An instance of the <see cref="TopicPartition"/>
        /// </summary>
        public List<TDengineMeta> Key { get; set; }

        /// <summary>
        ///  An instance of KeyValuePair, 
        ///  key is List of <see cref="TDengineMeta"/> represents the meta info of the consumer result.
        ///  and value is <see cref="Object"/> which represents the retrieved data.
        /// </summary>
        public List<Object> Value { get; set; }

        /// <summary>
        /// store the result pointer.
        /// </summary>

    }
}