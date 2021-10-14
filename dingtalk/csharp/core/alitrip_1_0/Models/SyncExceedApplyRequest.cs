// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class SyncExceedApplyRequest : TeaModel {
        /// <summary>
        /// 商旅超标审批单id
        /// </summary>
        [NameInMap("applyId")]
        [Validation(Required=false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 审批意见
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 审批单状态 1同意2拒绝
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// 第三方流程实例id
        /// </summary>
        [NameInMap("thirdpartyFlowId")]
        [Validation(Required=false)]
        public string ThirdpartyFlowId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
