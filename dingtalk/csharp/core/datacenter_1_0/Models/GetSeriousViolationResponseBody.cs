// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetSeriousViolationResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// IN_DATE:列入日期
        /// IN_DEPARTMENT:列入决定机关
        /// IN_REASON:列入严重违法失信企业名单原因
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
