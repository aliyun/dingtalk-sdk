// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetAbnormalOperationResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// DEPARTMENT:列入决定机关
        /// IN_REASON 列入原因
        /// OUT_DATE:移出日期
        /// OUT_DEPARTMENT:移出决定机关
        /// OUT_REASON:移出原因
        /// IN_DATE:列入日期
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
