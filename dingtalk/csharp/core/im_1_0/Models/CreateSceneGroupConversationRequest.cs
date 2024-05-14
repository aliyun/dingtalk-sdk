// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateSceneGroupConversationRequest : TeaModel {
        [NameInMap("features")]
        [Validation(Required=false)]
        public Dictionary<string, string> Features { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("groupOwnerId")]
        [Validation(Required=false)]
        public string GroupOwnerId { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("managementOptions")]
        [Validation(Required=false)]
        public CreateSceneGroupConversationRequestManagementOptions ManagementOptions { get; set; }
        public class CreateSceneGroupConversationRequestManagementOptions : TeaModel {
            [NameInMap("chatBannedType")]
            [Validation(Required=false)]
            public int? ChatBannedType { get; set; }

            [NameInMap("managementType")]
            [Validation(Required=false)]
            public int? ManagementType { get; set; }

            [NameInMap("mentionAllAuthority")]
            [Validation(Required=false)]
            public int? MentionAllAuthority { get; set; }

            [NameInMap("searchable")]
            [Validation(Required=false)]
            public int? Searchable { get; set; }

            [NameInMap("showHistoryType")]
            [Validation(Required=false)]
            public int? ShowHistoryType { get; set; }

            [NameInMap("validationType")]
            [Validation(Required=false)]
            public int? ValidationType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
