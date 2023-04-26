// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class QueryPartnerInfoResponseBody : TeaModel {
        [NameInMap("partnerDeptList")]
        [Validation(Required=false)]
        public List<QueryPartnerInfoResponseBodyPartnerDeptList> PartnerDeptList { get; set; }
        public class QueryPartnerInfoResponseBodyPartnerDeptList : TeaModel {
            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public long? MemberCount { get; set; }

            [NameInMap("partnerLabelModelLevel1")]
            [Validation(Required=false)]
            public QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 PartnerLabelModelLevel1 { get; set; }
            public class QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 : TeaModel {
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                [NameInMap("labelname")]
                [Validation(Required=false)]
                public string Labelname { get; set; }

            }

            [NameInMap("partnerNum")]
            [Validation(Required=false)]
            public string PartnerNum { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("partnerLabelList")]
        [Validation(Required=false)]
        public List<QueryPartnerInfoResponseBodyPartnerLabelList> PartnerLabelList { get; set; }
        public class QueryPartnerInfoResponseBodyPartnerLabelList : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
