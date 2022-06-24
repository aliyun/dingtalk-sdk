// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class AssignOrgHoldingToEmpHoldingBatchRequest : TeaModel {
        /// <summary>
        /// 备注信息 长度小于40
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
        /// 发放积分或额度数量 1～100000
        /// </summary>
        [NameInMap("singleAmount")]
        [Validation(Required=false)]
        public long? SingleAmount { get; set; }

        /// <summary>
        /// 发放人sourceUsage  发放人与接受人usage应一一对应
        /// 发放积分sourceUsage：OPEN_ORG_POINT_PERSONAL_ASSIGN 对应的targetUsage为OPEN_EMP_POINT_PERSONAL_RECEIVE；
        /// 发额度sourceUsage：OPEN_ORG_POINT_HOLDING_ASSIGN 对应的 targetUsage为OPEN_EMP_POINT_HOLDING_RECEIVE；
        /// 行为规则发积分 sourceUsage：OPEN_ACTION_RULE_PERSONAL_ASSIGN 对应的 targetUsage为OPEN_ACTION_RULE_PERSONAL_RECEIVE
        /// </summary>
        [NameInMap("sourceUsage")]
        [Validation(Required=false)]
        public string SourceUsage { get; set; }

        /// <summary>
        /// 接受人targetUsage  发放人与接受人usage应一一对应
        /// </summary>
        [NameInMap("targetUsage")]
        [Validation(Required=false)]
        public string TargetUsage { get; set; }

        /// <summary>
        /// 发放目标用户
        /// </summary>
        [NameInMap("targetUserList")]
        [Validation(Required=false)]
        public List<AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList> TargetUserList { get; set; }
        public class AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList : TeaModel {
            /// <summary>
            /// 积分交易单号，长度1-32。
            /// 
            /// </summary>
            [NameInMap("outId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// 操作目标对象userId
            /// </summary>
            [NameInMap("targetUserId")]
            [Validation(Required=false)]
            public string TargetUserId { get; set; }

        }

    }

}
