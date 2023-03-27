// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class CfJobPositionResp : TeaModel {
        /// <summary>
        /// 职位编码
        /// </summary>
        [NameInMap("jobPositionCode")]
        [Validation(Required=false)]
        public string JobPositionCode { get; set; }

        /// <summary>
        /// 职位名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
