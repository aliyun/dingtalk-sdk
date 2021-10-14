// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrade_1_0.Models
{
    public class CreateOpportunityRequest : TeaModel {
        /// <summary>
        /// 归属人电话号码
        /// </summary>
        [NameInMap("belongToPhoneNum")]
        [Validation(Required=false)]
        public string BelongToPhoneNum { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [NameInMap("contactPhoneNum")]
        [Validation(Required=false)]
        public string ContactPhoneNum { get; set; }

        /// <summary>
        /// 企业CorpId
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 部门Id
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        /// <summary>
        /// 商品码
        /// </summary>
        [NameInMap("marketCode")]
        [Validation(Required=false)]
        public string MarketCode { get; set; }

    }

}
