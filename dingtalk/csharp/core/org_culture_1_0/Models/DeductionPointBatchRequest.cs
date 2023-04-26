// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class DeductionPointBatchRequest : TeaModel {
        [NameInMap("deductionAmount")]
        [Validation(Required=false)]
        public long? DeductionAmount { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("sendOrgCultureInform")]
        [Validation(Required=false)]
        public bool? SendOrgCultureInform { get; set; }

        [NameInMap("targetUserList")]
        [Validation(Required=false)]
        public List<DeductionPointBatchRequestTargetUserList> TargetUserList { get; set; }
        public class DeductionPointBatchRequestTargetUserList : TeaModel {
            [NameInMap("outId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            [NameInMap("targetUserId")]
            [Validation(Required=false)]
            public string TargetUserId { get; set; }

        }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
