// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyUpdateMemberRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("isCopyDept")]
        [Validation(Required=false)]
        public bool? IsCopyDept { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>财务</para>
        /// </summary>
        [NameInMap("memberTitle")]
        [Validation(Required=false)]
        public string MemberTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>121212</para>
        /// </summary>
        [NameInMap("memberWorkNumber")]
        [Validation(Required=false)]
        public string MemberWorkNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13914772100</para>
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("newDeptId")]
        [Validation(Required=false)]
        public long? NewDeptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("oldDeptId")]
        [Validation(Required=false)]
        public long? OldDeptId { get; set; }

        [NameInMap("roleIdList")]
        [Validation(Required=false)]
        public List<string> RoleIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1212</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
