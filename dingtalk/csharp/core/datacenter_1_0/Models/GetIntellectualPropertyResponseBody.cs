// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetIntellectualPropertyResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// EntName:公司名称
        /// Number:登记证号
        /// Type:种类
        /// Pledgor:出质人名称
        /// Pawnee:质权人名称
        /// Period:质权登记期限
        /// Status:出质状态
        /// PublicDate:公示日期
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
