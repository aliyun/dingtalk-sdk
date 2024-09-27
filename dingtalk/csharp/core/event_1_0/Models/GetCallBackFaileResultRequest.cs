// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkevent_1_0.Models
{
    public class GetCallBackFaileResultRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1606126433000</para>
        /// </summary>
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1606126493000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

    }

}
