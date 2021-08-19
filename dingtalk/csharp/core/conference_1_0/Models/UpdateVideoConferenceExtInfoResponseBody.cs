// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class UpdateVideoConferenceExtInfoResponseBody : TeaModel {
        /// <summary>
        /// 失败原因
        /// </summary>
        [NameInMap("case")]
        [Validation(Required=false)]
        public string Case { get; set; }

        /// <summary>
        /// 返回编码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
