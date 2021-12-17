// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GetEventRequest : TeaModel {
        /// <summary>
        /// 返回参与人，上限500人，默认为0
        /// </summary>
        [NameInMap("maxAttendees")]
        [Validation(Required=false)]
        public long? MaxAttendees { get; set; }

    }

}
