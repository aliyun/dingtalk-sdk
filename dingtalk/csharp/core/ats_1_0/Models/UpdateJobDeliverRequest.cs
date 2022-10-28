// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class UpdateJobDeliverRequest : TeaModel {
        /// <summary>
        /// 招聘业务标识，目前固定ddats
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 渠道侧职位唯一标识
        /// </summary>
        [NameInMap("channelOuterId")]
        [Validation(Required=false)]
        public string ChannelOuterId { get; set; }

        /// <summary>
        /// 渠道侧错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 渠道侧错误信息
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [NameInMap("opTime")]
        [Validation(Required=false)]
        public long? OpTime { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// 职位投递状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// 企业corpId
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 钉钉侧职位唯一标识
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
