// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateSceneGroupConversationRequest : TeaModel {
        /// <summary>
        /// 功能增强
        /// </summary>
        [NameInMap("features")]
        [Validation(Required=false)]
        public Dictionary<string, string> Features { get; set; }

        /// <summary>
        /// 群名称。
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// 群主(钉外用户)userId。
        /// </summary>
        [NameInMap("groupOwnerId")]
        [Validation(Required=false)]
        public string GroupOwnerId { get; set; }

        /// <summary>
        /// 群头像。
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("managementOptions")]
        [Validation(Required=false)]
        public CreateSceneGroupConversationRequestManagementOptions ManagementOptions { get; set; }
        public class CreateSceneGroupConversationRequestManagementOptions : TeaModel {
            /// <summary>
            /// 群禁言，0-默认，不禁言，1-全员禁言
            /// </summary>
            [NameInMap("chatBannedType")]
            [Validation(Required=false)]
            public int? ChatBannedType { get; set; }

            /// <summary>
            /// 管理类型，0-默认，所有人可管理，1-仅群主可管理
            /// </summary>
            [NameInMap("managementType")]
            [Validation(Required=false)]
            public int? ManagementType { get; set; }

            /// <summary>
            /// @ all 权限，0-默认，所有人，1-仅群主可@all
            /// </summary>
            [NameInMap("mentionAllAuthority")]
            [Validation(Required=false)]
            public int? MentionAllAuthority { get; set; }

            /// <summary>
            /// 群可搜索，0-默认，不可搜索，1-可搜索
            /// </summary>
            [NameInMap("searchable")]
            [Validation(Required=false)]
            public int? Searchable { get; set; }

            /// <summary>
            /// 新成员是否可查看聊天历史消息，0-默认，否，1-是
            /// </summary>
            [NameInMap("showHistoryType")]
            [Validation(Required=false)]
            public int? ShowHistoryType { get; set; }

            /// <summary>
            /// 入群验证，0：不入群验证（默认） 1：入群验证
            /// </summary>
            [NameInMap("validationType")]
            [Validation(Required=false)]
            public int? ValidationType { get; set; }

        }

        /// <summary>
        /// 群模板Id。
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

        /// <summary>
        /// 建群去重的业务ID。
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
