// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class UpdateResidentMemberRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试小区1</para>
        /// </summary>
        [NameInMap("residentUpdateInfo")]
        [Validation(Required=false)]
        public UpdateResidentMemberRequestResidentUpdateInfo ResidentUpdateInfo { get; set; }
        public class UpdateResidentMemberRequestResidentUpdateInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11112</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isPropertyOwner")]
            [Validation(Required=false)]
            public bool? IsPropertyOwner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;startTime&quot;:1652358627106,&quot;endTime&quot;:1652445027106}</para>
            /// </summary>
            [NameInMap("memberDeptExtension")]
            [Validation(Required=false)]
            public Dictionary<string, string> MemberDeptExtension { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11123</para>
            /// </summary>
            [NameInMap("oldDeptId")]
            [Validation(Required=false)]
            public long? OldDeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("relateType")]
            [Validation(Required=false)]
            public string RelateType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11123</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1212</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
