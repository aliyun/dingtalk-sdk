// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmanufacturing_1_0.Models
{
    public class IndustrializeManufactureQueryJobsResponseBody : TeaModel {
        /// <summary>
        /// 查询的数据结果
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// httpCode
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

    }

}
