// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatAIQueryDatasetPermissionResponseBody : TeaModel {
        [NameInMap("permissionInfos")]
        [Validation(Required=false)]
        public List<ChatAIQueryDatasetPermissionResponseBodyPermissionInfos> PermissionInfos { get; set; }
        public class ChatAIQueryDatasetPermissionResponseBodyPermissionInfos : TeaModel {
            [NameInMap("permissionType")]
            [Validation(Required=false)]
            public string PermissionType { get; set; }

            [NameInMap("permissionValues")]
            [Validation(Required=false)]
            public List<string> PermissionValues { get; set; }

        }

    }

}
