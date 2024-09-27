// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyAddMemberRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("isPartnerManager")]
        [Validation(Required=false)]
        public bool? IsPartnerManager { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>187xxxx0001</para>
        /// </summary>
        [NameInMap("memberMobile")]
        [Validation(Required=false)]
        public string MemberMobile { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>李白</para>
        /// </summary>
        [NameInMap("memberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>经理</para>
        /// </summary>
        [NameInMap("memberTitle")]
        [Validation(Required=false)]
        public string MemberTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("memberWorkNumber")]
        [Validation(Required=false)]
        public string MemberWorkNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("supplyDeptId")]
        [Validation(Required=false)]
        public long? SupplyDeptId { get; set; }

    }

}
