// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class DocBlocksQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>block_type</para>
        /// </summary>
        [NameInMap("blockType")]
        [Validation(Required=false)]
        public string BlockType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>end_index</para>
        /// </summary>
        [NameInMap("endIndex")]
        [Validation(Required=false)]
        public int? EndIndex { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>start_index</para>
        /// </summary>
        [NameInMap("startIndex")]
        [Validation(Required=false)]
        public int? StartIndex { get; set; }

    }

}
