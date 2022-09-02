// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class CreateGroupSetResponseBody : TeaModel {
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("inviteLink")]
        [Validation(Required=false)]
        public string InviteLink { get; set; }

        [NameInMap("lastOpenConversationId")]
        [Validation(Required=false)]
        public string LastOpenConversationId { get; set; }

        [NameInMap("manager")]
        [Validation(Required=false)]
        public List<CreateGroupSetResponseBodyManager> Manager { get; set; }
        public class CreateGroupSetResponseBodyManager : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("managerUserIds")]
        [Validation(Required=false)]
        public string ManagerUserIds { get; set; }

        [NameInMap("memberCount")]
        [Validation(Required=false)]
        public long? MemberCount { get; set; }

        [NameInMap("memberQuota")]
        [Validation(Required=false)]
        public long? MemberQuota { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("notice")]
        [Validation(Required=false)]
        public string Notice { get; set; }

        [NameInMap("noticeToped")]
        [Validation(Required=false)]
        public int? NoticeToped { get; set; }

        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        [NameInMap("owner")]
        [Validation(Required=false)]
        public CreateGroupSetResponseBodyOwner Owner { get; set; }
        public class CreateGroupSetResponseBodyOwner : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("ownerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
