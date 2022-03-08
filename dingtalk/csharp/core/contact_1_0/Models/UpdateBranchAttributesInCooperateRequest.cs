// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateBranchAttributesInCooperateRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateBranchAttributesInCooperateRequestBody> Body { get; set; }
        public class UpdateBranchAttributesInCooperateRequestBody : TeaModel {
            /// <summary>
            /// 分支的企业ID
            /// </summary>
            [NameInMap("branchCorpId")]
            [Validation(Required=false)]
            public string BranchCorpId { get; set; }

            /// <summary>
            /// 挂载节点部门ID
            /// </summary>
            [NameInMap("linkDeptId")]
            [Validation(Required=false)]
            public long? LinkDeptId { get; set; }

            /// <summary>
            /// （分支/合作伙伴）在（集团/合作空间）的别名
            /// </summary>
            [NameInMap("unionRootName")]
            [Validation(Required=false)]
            public string UnionRootName { get; set; }

        }

    }

}
