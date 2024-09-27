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
            /// <summary>
            /// <b>Example:</b>
            /// <para>ding1234</para>
            /// </summary>
            [NameInMap("branchCorpId")]
            [Validation(Required=false)]
            public string BranchCorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("linkDeptId")]
            [Validation(Required=false)]
            public long? LinkDeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("unionRootName")]
            [Validation(Required=false)]
            public string UnionRootName { get; set; }

        }

    }

}
