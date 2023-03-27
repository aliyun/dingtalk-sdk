// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class CfJobPostResp : TeaModel {
        /// <summary>
        /// 职务编码
        /// </summary>
        [NameInMap("jobPostCode")]
        [Validation(Required=false)]
        public string JobPostCode { get; set; }

        /// <summary>
        /// 职务名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
