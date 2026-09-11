// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class UpdatePermissionResponseBody : TeaModel {
        [NameInMap("allSucceeded")]
        [Validation(Required=false)]
        public bool? AllSucceeded { get; set; }

        [NameInMap("failMemberInfoList")]
        [Validation(Required=false)]
        public List<UpdatePermissionResponseBodyFailMemberInfoList> FailMemberInfoList { get; set; }
        public class UpdatePermissionResponseBodyFailMemberInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public int? MemberType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lJcRnm39OsU4jlFVmRGXXXXX</para>
            /// </summary>
            [NameInMap("memberUnionId")]
            [Validation(Required=false)]
            public string MemberUnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("policyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

        }

        [NameInMap("memberPermissionOperationResults")]
        [Validation(Required=false)]
        public List<UpdatePermissionResponseBodyMemberPermissionOperationResults> MemberPermissionOperationResults { get; set; }
        public class UpdatePermissionResponseBodyMemberPermissionOperationResults : TeaModel {
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("memberType")]
            [Validation(Required=false)]
            public int? MemberType { get; set; }

            [NameInMap("memberUnionId")]
            [Validation(Required=false)]
            public string MemberUnionId { get; set; }

            [NameInMap("opType")]
            [Validation(Required=false)]
            public int? OpType { get; set; }

            [NameInMap("policyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("modelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        [NameInMap("partialSuccess")]
        [Validation(Required=false)]
        public bool? PartialSuccess { get; set; }

        [NameInMap("shareScopeResult")]
        [Validation(Required=false)]
        public UpdatePermissionResponseBodyShareScopeResult ShareScopeResult { get; set; }
        public class UpdatePermissionResponseBodyShareScopeResult : TeaModel {
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
