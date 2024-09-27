// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateWorkTimeApproveRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-04T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("finishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1233</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NEW</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-04T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("submitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx 用工申请</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxxbpms.xxx/xxxx">https://xxxbpms.xxx/xxxx</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
