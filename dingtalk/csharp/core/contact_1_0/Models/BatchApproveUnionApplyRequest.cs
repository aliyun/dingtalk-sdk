// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class BatchApproveUnionApplyRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<BatchApproveUnionApplyRequestBody> Body { get; set; }
        public class BatchApproveUnionApplyRequestBody : TeaModel {
            [NameInMap("branchCorpId")]
            [Validation(Required=false)]
            public string BranchCorpId { get; set; }

            [NameInMap("linkDeptId")]
            [Validation(Required=false)]
            public long? LinkDeptId { get; set; }

            [NameInMap("unionRootName")]
            [Validation(Required=false)]
            public string UnionRootName { get; set; }

        }

    }

}
