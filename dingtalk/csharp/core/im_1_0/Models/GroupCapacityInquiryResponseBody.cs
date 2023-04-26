// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GroupCapacityInquiryResponseBody : TeaModel {
        [NameInMap("actualPrice")]
        [Validation(Required=false)]
        public long? ActualPrice { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("currentCapacity")]
        [Validation(Required=false)]
        public int? CurrentCapacity { get; set; }

        [NameInMap("currentEffectUntil")]
        [Validation(Required=false)]
        public long? CurrentEffectUntil { get; set; }

        [NameInMap("discount")]
        [Validation(Required=false)]
        public int? Discount { get; set; }

        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtInfo { get; set; }

        [NameInMap("groupOwner")]
        [Validation(Required=false)]
        public string GroupOwner { get; set; }

        [NameInMap("groupTitle")]
        [Validation(Required=false)]
        public string GroupTitle { get; set; }

        [NameInMap("markedPrice")]
        [Validation(Required=false)]
        public long? MarkedPrice { get; set; }

        [NameInMap("memberCount")]
        [Validation(Required=false)]
        public int? MemberCount { get; set; }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("targetCapacity")]
        [Validation(Required=false)]
        public int? TargetCapacity { get; set; }

        [NameInMap("targetEffectUntil")]
        [Validation(Required=false)]
        public long? TargetEffectUntil { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
