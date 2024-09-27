// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class DeviceHeartbeatResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0心跳正常，1增量更新，2上传日志，3全量更新</para>
        /// </summary>
        [NameInMap("command")]
        [Validation(Required=false)]
        public int? Command { get; set; }

    }

}
