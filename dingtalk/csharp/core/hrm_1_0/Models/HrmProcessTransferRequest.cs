// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmProcessTransferRequest : TeaModel {
        /// <summary>
        /// 员工调岗后的部门id列表
        /// </summary>
        [NameInMap("deptIdsAfterTransfer")]
        [Validation(Required=false)]
        public List<long?> DeptIdsAfterTransfer { get; set; }

        /// <summary>
        /// 员工调岗后的职务id
        /// </summary>
        [NameInMap("jobIdAfterTransfer")]
        [Validation(Required=false)]
        public string JobIdAfterTransfer { get; set; }

        /// <summary>
        /// 员工调岗后的人事主部门id
        /// </summary>
        [NameInMap("mainDeptIdAfterTransfer")]
        [Validation(Required=false)]
        public long? MainDeptIdAfterTransfer { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

        /// <summary>
        /// 员工调岗后的职位id，参数同时有职位名称以及id，以id为准
        /// </summary>
        [NameInMap("positionIdAfterTransfer")]
        [Validation(Required=false)]
        public string PositionIdAfterTransfer { get; set; }

        /// <summary>
        /// 员工调岗后的职级名称，长度不超过64，参数同时有职级名称以及id，以id为准
        /// </summary>
        [NameInMap("positionLevelAfterTransfer")]
        [Validation(Required=false)]
        public string PositionLevelAfterTransfer { get; set; }

        /// <summary>
        /// 员工调岗后的职位名称，长度不超过124，参数同时有职位名称以及id，以id为准
        /// </summary>
        [NameInMap("positionNameAfterTransfer")]
        [Validation(Required=false)]
        public string PositionNameAfterTransfer { get; set; }

        /// <summary>
        /// 员工调岗后的职级id，参数同时有职级名称以及id，以id为准
        /// </summary>
        [NameInMap("rankIdAfterTransfer")]
        [Validation(Required=false)]
        public string RankIdAfterTransfer { get; set; }

        /// <summary>
        /// 被调岗员工userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
