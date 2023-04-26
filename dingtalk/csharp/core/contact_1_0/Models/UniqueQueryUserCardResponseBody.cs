// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UniqueQueryUserCardResponseBody : TeaModel {
        [NameInMap("avatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        [NameInMap("cardId")]
        [Validation(Required=false)]
        public string CardId { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extension { get; set; }

        [NameInMap("industryName")]
        [Validation(Required=false)]
        public string IndustryName { get; set; }

        [NameInMap("introduce")]
        [Validation(Required=false)]
        public string Introduce { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("settings")]
        [Validation(Required=false)]
        public Dictionary<string, object> Settings { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
