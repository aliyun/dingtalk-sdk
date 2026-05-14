// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateGroupRequest : TeaModel {
        [NameInMap("conversationTag")]
        [Validation(Required=false)]
        public long? ConversationTag { get; set; }

        [NameInMap("extidlist")]
        [Validation(Required=false)]
        public List<string> Extidlist { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("managementOptions")]
        [Validation(Required=false)]
        public CreateGroupRequestManagementOptions ManagementOptions { get; set; }
        public class CreateGroupRequestManagementOptions : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("ownerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("useridlist")]
        [Validation(Required=false)]
        public List<string> Useridlist { get; set; }

    }

}
