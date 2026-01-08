// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class UpdatePermissionRequest : TeaModel {
        [NameInMap("memberInfoList")]
        [Validation(Required=false)]
        public List<UpdatePermissionRequestMemberInfoList> MemberInfoList { get; set; }
        public class UpdatePermissionRequestMemberInfoList : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("opType")]
        [Validation(Required=false)]
        public int? OpType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("roleCode")]
        [Validation(Required=false)]
        public string RoleCode { get; set; }

        [NameInMap("roleSubResourceIds")]
        [Validation(Required=false)]
        public List<string> RoleSubResourceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("shareScope")]
        [Validation(Required=false)]
        public int? ShareScope { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lJcRnm39OsU4jlFVmRGXXXXX</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
