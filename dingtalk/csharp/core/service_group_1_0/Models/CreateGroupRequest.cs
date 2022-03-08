// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// 业务关联id
        /// </summary>
        [NameInMap("groupBizId")]
        [Validation(Required=false)]
        public string GroupBizId { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// 群标签
        /// </summary>
        [NameInMap("groupTagNames")]
        [Validation(Required=false)]
        public List<string> GroupTagNames { get; set; }

        /// <summary>
        /// 群成员员工ID列表
        /// </summary>
        [NameInMap("memberStaffIds")]
        [Validation(Required=false)]
        public List<string> MemberStaffIds { get; set; }

        /// <summary>
        /// 开放群组ID
        /// </summary>
        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 群主员工ID
        /// </summary>
        [NameInMap("ownerStaffId")]
        [Validation(Required=false)]
        public string OwnerStaffId { get; set; }

    }

}
