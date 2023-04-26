// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetUserCardHolderListResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<GetUserCardHolderListResponseBodyList> List { get; set; }
        public class GetUserCardHolderListResponseBodyList : TeaModel {
            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("cardAcceptStatus")]
            [Validation(Required=false)]
            public int? CardAcceptStatus { get; set; }

            [NameInMap("cardAcceptTimeLong")]
            [Validation(Required=false)]
            public long? CardAcceptTimeLong { get; set; }

            [NameInMap("cardId")]
            [Validation(Required=false)]
            public string CardId { get; set; }

            [NameInMap("cardSource")]
            [Validation(Required=false)]
            public int? CardSource { get; set; }

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

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
