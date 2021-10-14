// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetPlatformResourceResponseBody : TeaModel {
        /// <summary>
        /// accountTotalAmount
        /// </summary>
        [NameInMap("accountTotalAmount")]
        [Validation(Required=false)]
        public int? AccountTotalAmount { get; set; }

        /// <summary>
        /// accountUsageAmount
        /// </summary>
        [NameInMap("accountUsageAmount")]
        [Validation(Required=false)]
        public int? AccountUsageAmount { get; set; }

        /// <summary>
        /// appTotalAmount
        /// </summary>
        [NameInMap("appTotalAmount")]
        [Validation(Required=false)]
        public int? AppTotalAmount { get; set; }

        /// <summary>
        /// attachmentTotalAmount
        /// </summary>
        [NameInMap("attachmentTotalAmount")]
        [Validation(Required=false)]
        public long? AttachmentTotalAmount { get; set; }

        /// <summary>
        /// attachmentUsageAmount
        /// </summary>
        [NameInMap("attachmentUsageAmount")]
        [Validation(Required=false)]
        public long? AttachmentUsageAmount { get; set; }

        /// <summary>
        /// instanceTotalAmount
        /// </summary>
        [NameInMap("instanceTotalAmount")]
        [Validation(Required=false)]
        public long? InstanceTotalAmount { get; set; }

        /// <summary>
        /// instanceUsageAmount
        /// </summary>
        [NameInMap("instanceUsageAmount")]
        [Validation(Required=false)]
        public long? InstanceUsageAmount { get; set; }

        /// <summary>
        /// pluginUsageAmount
        /// </summary>
        [NameInMap("pluginUsageAmount")]
        [Validation(Required=false)]
        public long? PluginUsageAmount { get; set; }

    }

}
