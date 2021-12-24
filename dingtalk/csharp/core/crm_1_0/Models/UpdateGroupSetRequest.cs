// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class UpdateGroupSetRequest : TeaModel {
        [NameInMap("managerUserIds")]
        [Validation(Required=false)]
        public string ManagerUserIds { get; set; }

        [NameInMap("memberQuota")]
        [Validation(Required=false)]
        public int? MemberQuota { get; set; }

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

        [NameInMap("ownerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
