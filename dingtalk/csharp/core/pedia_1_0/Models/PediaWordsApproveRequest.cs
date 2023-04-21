// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsApproveRequest : TeaModel {
        /// <summary>
        /// 拒绝的原因，可选
        /// </summary>
        [NameInMap("approveReason")]
        [Validation(Required=false)]
        public string ApproveReason { get; set; }

        /// <summary>
        /// 审核的结果，1通过0代表拒绝
        /// </summary>
        [NameInMap("approveStatus")]
        [Validation(Required=false)]
        public string ApproveStatus { get; set; }

        /// <summary>
        /// 当前内部群是否高亮
        /// </summary>
        [NameInMap("imHighLight")]
        [Validation(Required=false)]
        public bool? ImHighLight { get; set; }

        /// <summary>
        /// 服务群是否高亮
        /// </summary>
        [NameInMap("simHighLight")]
        [Validation(Required=false)]
        public bool? SimHighLight { get; set; }

        /// <summary>
        /// 操作人的组织员工编号，开放平台员工信息接口获取userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 当前审核的词条的主键编号
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public long? Uuid { get; set; }

    }

}
