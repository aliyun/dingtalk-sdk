// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0.Models
{
    public class GetMineWorkspaceResponseBody : TeaModel {
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public GetMineWorkspaceResponseBodyWorkspace Workspace { get; set; }
        public class GetMineWorkspaceResponseBodyWorkspace : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("cover")]
            [Validation(Required=false)]
            public string Cover { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public GetMineWorkspaceResponseBodyWorkspaceIcon Icon { get; set; }
            public class GetMineWorkspaceResponseBodyWorkspaceIcon : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("modifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("permissionRole")]
            [Validation(Required=false)]
            public string PermissionRole { get; set; }

            [NameInMap("rootNodeId")]
            [Validation(Required=false)]
            public string RootNodeId { get; set; }

            [NameInMap("teamId")]
            [Validation(Required=false)]
            public string TeamId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
