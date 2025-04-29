// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsApproveRequest : TeaModel {
        [NameInMap("aliDocHighLight")]
        [Validation(Required=false)]
        public bool? AliDocHighLight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>拒绝</para>
        /// </summary>
        [NameInMap("approveReason")]
        [Validation(Required=false)]
        public string ApproveReason { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("approveStatus")]
        [Validation(Required=false)]
        public string ApproveStatus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("imHighLight")]
        [Validation(Required=false)]
        public bool? ImHighLight { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("simHighLight")]
        [Validation(Required=false)]
        public bool? SimHighLight { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>232432</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1213132</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public long? Uuid { get; set; }

    }

}
