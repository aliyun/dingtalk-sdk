// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class FindTargetRelatedFollowRecordsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public FindTargetRelatedFollowRecordsResponseBodyResult Result { get; set; }
        public class FindTargetRelatedFollowRecordsResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("resultList")]
            [Validation(Required=false)]
            public List<FindTargetRelatedFollowRecordsResponseBodyResultResultList> ResultList { get; set; }
            public class FindTargetRelatedFollowRecordsResponseBodyResultResultList : TeaModel {
                [NameInMap("creatorUserId")]
                [Validation(Required=false)]
                public string CreatorUserId { get; set; }

                [NameInMap("followContent")]
                [Validation(Required=false)]
                public List<FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent> FollowContent { get; set; }
                public class FindTargetRelatedFollowRecordsResponseBodyResultResultListFollowContent : TeaModel {
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    [NameInMap("extendValue")]
                    [Validation(Required=false)]
                    public string ExtendValue { get; set; }

                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("followTargetDataId")]
                [Validation(Required=false)]
                public string FollowTargetDataId { get; set; }

                [NameInMap("followTargetType")]
                [Validation(Required=false)]
                public string FollowTargetType { get; set; }

                [NameInMap("gmtCreateMilliseconds")]
                [Validation(Required=false)]
                public string GmtCreateMilliseconds { get; set; }

                [NameInMap("gmtModifiedMilliseconds")]
                [Validation(Required=false)]
                public string GmtModifiedMilliseconds { get; set; }

                [NameInMap("modifierUserId")]
                [Validation(Required=false)]
                public string ModifierUserId { get; set; }

                [NameInMap("recordInstId")]
                [Validation(Required=false)]
                public string RecordInstId { get; set; }

            }

        }

    }

}
