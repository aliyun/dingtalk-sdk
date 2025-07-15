// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class HandoveryWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("param")]
        [Validation(Required=false)]
        public HandoveryWorkspaceRequestParam Param { get; set; }
        public class HandoveryWorkspaceRequestParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>unionId</para>
            /// </summary>
            [NameInMap("leave")]
            [Validation(Required=false)]
            public bool? Leave { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>unionId</para>
            /// </summary>
            [NameInMap("receiverUnionId")]
            [Validation(Required=false)]
            public string ReceiverUnionId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root_node_uuid</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

    }

}
