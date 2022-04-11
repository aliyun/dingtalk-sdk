// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcarbon_1_0.Models
{
    public class GetPersonalCarbonInfoResponseBody : TeaModel {
        /// <summary>
        /// 文案
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 减碳数据
        /// </summary>
        [NameInMap("personalCarbonAmount")]
        [Validation(Required=false)]
        public double? PersonalCarbonAmount { get; set; }

    }

}
