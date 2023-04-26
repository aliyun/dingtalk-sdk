// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmProcessTransferRequest : TeaModel {
        [NameInMap("deptIdsAfterTransfer")]
        [Validation(Required=false)]
        public List<long?> DeptIdsAfterTransfer { get; set; }

        [NameInMap("jobIdAfterTransfer")]
        [Validation(Required=false)]
        public string JobIdAfterTransfer { get; set; }

        [NameInMap("mainDeptIdAfterTransfer")]
        [Validation(Required=false)]
        public long? MainDeptIdAfterTransfer { get; set; }

        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

        [NameInMap("positionIdAfterTransfer")]
        [Validation(Required=false)]
        public string PositionIdAfterTransfer { get; set; }

        [NameInMap("positionLevelAfterTransfer")]
        [Validation(Required=false)]
        public string PositionLevelAfterTransfer { get; set; }

        [NameInMap("positionNameAfterTransfer")]
        [Validation(Required=false)]
        public string PositionNameAfterTransfer { get; set; }

        [NameInMap("rankIdAfterTransfer")]
        [Validation(Required=false)]
        public string RankIdAfterTransfer { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
