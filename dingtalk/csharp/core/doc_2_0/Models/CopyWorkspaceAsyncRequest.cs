// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CopyWorkspaceAsyncRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("param")]
        [Validation(Required=false)]
        public CopyWorkspaceAsyncRequestParam Param { get; set; }
        public class CopyWorkspaceAsyncRequestParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("originWorkspaceId")]
            [Validation(Required=false)]
            public string OriginWorkspaceId { get; set; }

        }

    }

}
