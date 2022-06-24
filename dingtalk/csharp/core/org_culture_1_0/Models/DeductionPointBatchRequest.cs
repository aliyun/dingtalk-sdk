// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class DeductionPointBatchRequest : TeaModel {
        /// <summary>
        /// 扣减数量 范围：1—100000
        /// </summary>
        [NameInMap("deductionAmount")]
        [Validation(Required=false)]
        public long? DeductionAmount { get; set; }

        /// <summary>
        /// 扣减积分原因
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 是否发送组织文化通知
        /// </summary>
        [NameInMap("sendOrgCultureInform")]
        [Validation(Required=false)]
        public bool? SendOrgCultureInform { get; set; }

        /// <summary>
        /// 批量扣减积分用户
        /// </summary>
        [NameInMap("targetUserList")]
        [Validation(Required=false)]
        public List<DeductionPointBatchRequestTargetUserList> TargetUserList { get; set; }
        public class DeductionPointBatchRequestTargetUserList : TeaModel {
            /// <summary>
            /// 积分交易单号
            /// </summary>
            [NameInMap("outId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// 扣减目标用户userId
            /// </summary>
            [NameInMap("targetUserId")]
            [Validation(Required=false)]
            public string TargetUserId { get; set; }

        }

        /// <summary>
        /// 操作人userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
