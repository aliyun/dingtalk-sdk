// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateBranchAttributesInCooperateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateBranchAttributesInCooperateRequestBody> Body { get; set; }
        public class UpdateBranchAttributesInCooperateRequestBody : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ding1234</para>
            /// </summary>
            [NameInMap("branchCorpId")]
            [Validation(Required=false)]
            public string BranchCorpId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23456</para>
            /// </summary>
            [NameInMap("linkDeptId")]
            [Validation(Required=false)]
            public long? LinkDeptId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ding1234</para>
            /// </summary>
            [NameInMap("unionRootName")]
            [Validation(Required=false)]
            public string UnionRootName { get; set; }

        }

    }

}
