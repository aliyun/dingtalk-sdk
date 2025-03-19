// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetSuperAdminOpenSceneGroupInfoResponseBody : TeaModel {
        [NameInMap("groupUrl")]
        [Validation(Required=false)]
        public string GroupUrl { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("managementOptions")]
        [Validation(Required=false)]
        public GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions ManagementOptions { get; set; }
        public class GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions : TeaModel {
            [NameInMap("chatBannedType")]
            [Validation(Required=false)]
            public string ChatBannedType { get; set; }

            [NameInMap("managementType")]
            [Validation(Required=false)]
            public string ManagementType { get; set; }

            [NameInMap("mentionAllAuthority")]
            [Validation(Required=false)]
            public string MentionAllAuthority { get; set; }

            [NameInMap("searchable")]
            [Validation(Required=false)]
            public string Searchable { get; set; }

            [NameInMap("showHistoryType")]
            [Validation(Required=false)]
            public string ShowHistoryType { get; set; }

            [NameInMap("validationType")]
            [Validation(Required=false)]
            public string ValidationType { get; set; }

        }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("ownerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        [NameInMap("subAdminUserIds")]
        [Validation(Required=false)]
        public List<string> SubAdminUserIds { get; set; }

        [NameInMap("sucess")]
        [Validation(Required=false)]
        public bool? Sucess { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
