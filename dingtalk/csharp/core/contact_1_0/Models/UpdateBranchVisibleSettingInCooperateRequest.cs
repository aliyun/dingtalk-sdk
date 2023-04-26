// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateBranchVisibleSettingInCooperateRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateBranchVisibleSettingInCooperateRequestBody> Body { get; set; }
        public class UpdateBranchVisibleSettingInCooperateRequestBody : TeaModel {
            [NameInMap("branchCorpId")]
            [Validation(Required=false)]
            public string BranchCorpId { get; set; }

            [NameInMap("open")]
            [Validation(Required=false)]
            public bool? Open { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public long? Type { get; set; }

            [NameInMap("visibleBranchCorpIds")]
            [Validation(Required=false)]
            public List<string> VisibleBranchCorpIds { get; set; }

            [NameInMap("visibleDeptIds")]
            [Validation(Required=false)]
            public List<long?> VisibleDeptIds { get; set; }

        }

    }

}
