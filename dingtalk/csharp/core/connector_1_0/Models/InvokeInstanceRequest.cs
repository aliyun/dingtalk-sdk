// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class InvokeInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dca://ding32fff839a3e0105d.connect.dingtalk.com/ding32fff839a3e0105d/action/G-ACT-101FDEBD3C6E213DB474000P</para>
        /// </summary>
        [NameInMap("connectAssetUri")]
        [Validation(Required=false)]
        public string ConnectAssetUri { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("inputJsonString")]
        [Validation(Required=false)]
        public string InputJsonString { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SAMPLE</para>
        /// </summary>
        [NameInMap("instanceKey")]
        [Validation(Required=false)]
        public string InstanceKey { get; set; }

    }

}
