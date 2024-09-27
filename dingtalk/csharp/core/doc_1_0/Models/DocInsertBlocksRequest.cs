// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class DocInsertBlocksRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>block_id</para>
        /// </summary>
        [NameInMap("blockId")]
        [Validation(Required=false)]
        public string BlockId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>element</para>
        /// </summary>
        [NameInMap("element")]
        [Validation(Required=false)]
        public Dictionary<string, object> Element { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>index</para>
        /// </summary>
        [NameInMap("index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>where</para>
        /// </summary>
        [NameInMap("where")]
        [Validation(Required=false)]
        public string Where { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
