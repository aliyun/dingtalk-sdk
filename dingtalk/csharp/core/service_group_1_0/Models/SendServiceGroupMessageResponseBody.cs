// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class SendServiceGroupMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msgxxxxxx==</para>
        /// </summary>
        [NameInMap("openMsgTaskId")]
        [Validation(Required=false)]
        public string OpenMsgTaskId { get; set; }

    }

}
