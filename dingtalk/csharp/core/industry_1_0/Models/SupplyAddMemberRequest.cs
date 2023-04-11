// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyAddMemberRequest : TeaModel {
        /// <summary>
        /// 是否为伙伴负责人
        /// </summary>
        [NameInMap("isPartnerManager")]
        [Validation(Required=false)]
        public bool? IsPartnerManager { get; set; }

        /// <summary>
        /// 成员手机号
        /// </summary>
        [NameInMap("memberMobile")]
        [Validation(Required=false)]
        public string MemberMobile { get; set; }

        /// <summary>
        /// 成员名字
        /// </summary>
        [NameInMap("memberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        /// <summary>
        /// 成员编码/工号
        /// </summary>
        [NameInMap("memberWorkNumber")]
        [Validation(Required=false)]
        public string MemberWorkNumber { get; set; }

        /// <summary>
        /// 所属伙伴/子部门
        /// </summary>
        [NameInMap("supplyDeptId")]
        [Validation(Required=false)]
        public long? SupplyDeptId { get; set; }

    }

}
