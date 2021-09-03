// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetDingReportDeptSummaryRequest : TeaModel {
        /// <summary>
        /// 启始数据游标
        /// </summary>
        [NameInMap("pageStart")]
        [Validation(Required=false)]
        public long? PageStart { get; set; }

        /// <summary>
        /// 每页包含的数据条数
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
