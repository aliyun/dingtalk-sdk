// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class UpdateGroupRequest : TeaModel {
        [NameInMap("add_extidlist")]
        [Validation(Required=false)]
        public List<string> AddExtidlist { get; set; }

        [NameInMap("add_useridlist")]
        [Validation(Required=false)]
        public List<string> AddUseridlist { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("chatid")]
        [Validation(Required=false)]
        public string Chatid { get; set; }

        [NameInMap("del_extidlist")]
        [Validation(Required=false)]
        public List<string> DelExtidlist { get; set; }

        [NameInMap("del_useridlist")]
        [Validation(Required=false)]
        public List<string> DelUseridlist { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("managementOptions")]
        [Validation(Required=false)]
        public UpdateGroupRequestManagementOptions ManagementOptions { get; set; }
        public class UpdateGroupRequestManagementOptions : TeaModel {
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

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("ownerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

    }

}
