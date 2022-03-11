// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbadge_1_0.Models
{
    public class DecodeBadgeCodeResponseBody : TeaModel {
        /// <summary>
        /// 支付宝付款码
        /// </summary>
        [NameInMap("alipayCode")]
        [Validation(Required=false)]
        public string AlipayCode { get; set; }

        /// <summary>
        /// 码ID，对于访客或会展码等静态码值返回
        /// </summary>
        [NameInMap("codeId")]
        [Validation(Required=false)]
        public string CodeId { get; set; }

        /// <summary>
        /// 码标识，工牌码：DT_IDENTITY，访客码：DT_VISITOR，会展码：DT_CONFERENCE
        /// </summary>
        [NameInMap("codeIdentity")]
        [Validation(Required=false)]
        public string CodeIdentity { get; set; }

        /// <summary>
        /// 码类型
        /// </summary>
        [NameInMap("codeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部业务ID，值为调用创建工牌码接口传入的requestId
        /// </summary>
        [NameInMap("outBizId")]
        [Validation(Required=false)]
        public string OutBizId { get; set; }

        /// <summary>
        /// 用户和企业关系
        /// </summary>
        [NameInMap("userCorpRelationType")]
        [Validation(Required=false)]
        public string UserCorpRelationType { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
