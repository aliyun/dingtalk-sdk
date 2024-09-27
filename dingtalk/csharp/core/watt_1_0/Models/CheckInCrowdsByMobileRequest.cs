// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwatt_1_0.Models
{
    public class CheckInCrowdsByMobileRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12520</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("crowdIds")]
        [Validation(Required=false)]
        public byte[] CrowdIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N5u3hS6KJeoUdopXW4GzFg==</para>
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

    }

}
