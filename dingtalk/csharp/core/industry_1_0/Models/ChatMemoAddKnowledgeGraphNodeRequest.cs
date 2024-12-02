// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatMemoAddKnowledgeGraphNodeRequest : TeaModel {
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
        [NameInMap("nodeInfo")]
        [Validation(Required=false)]
        public ChatMemoAddKnowledgeGraphNodeRequestNodeInfo NodeInfo { get; set; }
        public class ChatMemoAddKnowledgeGraphNodeRequestNodeInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>人物</para>
            /// </summary>
            [NameInMap("nodeLabel")]
            [Validation(Required=false)]
            public string NodeLabel { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>刘备</para>
            /// </summary>
            [NameInMap("nodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

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
