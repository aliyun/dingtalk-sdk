// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class BatchAddPermissionRequest : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<BatchAddPermissionRequestList> List { get; set; }
        public class BatchAddPermissionRequestList : TeaModel {
            [NameInMap("member")]
            [Validation(Required=false)]
            public BatchAddPermissionRequestListMember Member { get; set; }
            public class BatchAddPermissionRequestListMember : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }
            };

            [NameInMap("policyType")]
            [Validation(Required=false)]
            public long? PolicyType { get; set; }

        }

        [NameInMap("targetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
