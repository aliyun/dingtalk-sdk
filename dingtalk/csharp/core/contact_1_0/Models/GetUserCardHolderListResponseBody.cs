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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<GetUserCardHolderListResponseBodyList> List { get; set; }
        public class GetUserCardHolderListResponseBodyList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("cardAcceptStatus")]
            [Validation(Required=false)]
            public int? CardAcceptStatus { get; set; }

            [NameInMap("cardAcceptTimeLong")]
            [Validation(Required=false)]
            public long? CardAcceptTimeLong { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cardId")]
            [Validation(Required=false)]
            public string CardId { get; set; }

            [NameInMap("cardSource")]
            [Validation(Required=false)]
            public int? CardSource { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, object> Extension { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("industryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("introduce")]
            [Validation(Required=false)]
            public string Introduce { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
