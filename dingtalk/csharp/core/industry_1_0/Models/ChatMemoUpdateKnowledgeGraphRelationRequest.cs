// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatMemoUpdateKnowledgeGraphRelationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111111</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("relationInfo")]
        [Validation(Required=false)]
        public ChatMemoUpdateKnowledgeGraphRelationRequestRelationInfo RelationInfo { get; set; }
        public class ChatMemoUpdateKnowledgeGraphRelationRequestRelationInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;年龄&quot;：43}</para>
            /// </summary>
            [NameInMap("propertiesString")]
            [Validation(Required=false)]
            public string PropertiesString { get; set; }

        }

    }

}
