// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkswform_1_0.Models
{
    public class ListFormInstancesRequest : TeaModel {
        /// <summary>
        /// 时间，必须是YYYY-MM-DD的格式。循环填表才需要传这个参数。
        /// </summary>
        [NameInMap("actionDate")]
        [Validation(Required=false)]
        public string ActionDate { get; set; }

        /// <summary>
        /// 填表类型。0表示通用填表，1表示教育版填表
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// 10
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 0
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

    }

}
