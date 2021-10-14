// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetApplyInviteInfoResponseBody : TeaModel {
        /// <summary>
        /// 仅部门邀请有效： 0-无需审核 1-有权限的子管理员
        /// </summary>
        [NameInMap("auditType")]
        [Validation(Required=false)]
        public long? AuditType { get; set; }

        /// <summary>
        /// 是否允许员工扫码加入部门，仅在无需审核的时候有效（已经在组织内的成员通过扫描部门二维码加入某个部门）
        /// </summary>
        [NameInMap("empApplyJoinDept")]
        [Validation(Required=false)]
        public bool? EmpApplyJoinDept { get; set; }

        /// <summary>
        /// 是否开启邀请
        /// </summary>
        [NameInMap("inviteSwitch")]
        [Validation(Required=false)]
        public bool? InviteSwitch { get; set; }

        /// <summary>
        /// 邀请链接
        /// </summary>
        [NameInMap("inviteUrl")]
        [Validation(Required=false)]
        public string InviteUrl { get; set; }

        /// <summary>
        /// 是否开启通过链接邀请加入
        /// </summary>
        [NameInMap("linkInvite")]
        [Validation(Required=false)]
        public bool? LinkInvite { get; set; }

        /// <summary>
        /// 是否开启通过团队号申请加入
        /// </summary>
        [NameInMap("orgApplyCodeInvite")]
        [Validation(Required=false)]
        public bool? OrgApplyCodeInvite { get; set; }

        /// <summary>
        /// 是否开启通过企业名称搜索申请
        /// </summary>
        [NameInMap("searchNameInvite")]
        [Validation(Required=false)]
        public bool? SearchNameInvite { get; set; }

    }

}
