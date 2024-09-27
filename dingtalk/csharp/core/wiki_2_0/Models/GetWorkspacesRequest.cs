// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0.Models
{
    public class GetWorkspacesRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public GetWorkspacesRequestOption Option { get; set; }
        public class GetWorkspacesRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("withPermissionRole")]
            [Validation(Required=false)]
            public bool? WithPermissionRole { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("workspaceIds")]
        [Validation(Required=false)]
        public List<string> WorkspaceIds { get; set; }

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
