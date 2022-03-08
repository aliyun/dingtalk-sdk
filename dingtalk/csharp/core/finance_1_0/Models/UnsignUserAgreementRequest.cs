// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UnsignUserAgreementRequest : TeaModel {
        /// <summary>
        /// 协议编号
        /// </summary>
        [NameInMap("agreementNo")]
        [Validation(Required=false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务代码
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [NameInMap("bizScene")]
        [Validation(Required=false)]
        public string BizScene { get; set; }

        /// <summary>
        /// 主机构编号
        /// </summary>
        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        /// <summary>
        /// 子机构编号
        /// </summary>
        [NameInMap("subInstId")]
        [Validation(Required=false)]
        public string SubInstId { get; set; }

        /// <summary>
        /// 付款人staffId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
