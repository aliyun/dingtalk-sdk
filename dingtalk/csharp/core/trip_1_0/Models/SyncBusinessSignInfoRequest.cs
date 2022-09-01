// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncBusinessSignInfoRequest : TeaModel {
        /// <summary>
        /// 签约企业所支持的订单类目，如机票、酒店、火车票、打车。
        /// 枚举值如下：
        /// ["HOTEL","FLIGHT","TAXI","TRAIN"]
        /// </summary>
        [NameInMap("bizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// 开通企业支付的时间戳，毫秒
        /// 
        /// </summary>
        [NameInMap("gmtOrgPay")]
        [Validation(Required=false)]
        public string GmtOrgPay { get; set; }

        /// <summary>
        /// 签约时间戳，毫秒
        /// 
        /// </summary>
        [NameInMap("gmtSign")]
        [Validation(Required=false)]
        public string GmtSign { get; set; }

        /// <summary>
        /// 开通企业支付状态
        /// 
        /// </summary>
        [NameInMap("orgPayStatus")]
        [Validation(Required=false)]
        public string OrgPayStatus { get; set; }

        /// <summary>
        /// 企业签约状态
        /// </summary>
        [NameInMap("signStatus")]
        [Validation(Required=false)]
        public string SignStatus { get; set; }

        /// <summary>
        /// 签约企业corpId
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

    }

}
