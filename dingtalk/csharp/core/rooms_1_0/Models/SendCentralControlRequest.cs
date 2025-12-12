// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class SendCentralControlRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{   &quot;version&quot;: &quot;1.0.0&quot;,    &quot;request&quot;: {     &quot;requestId&quot;: &quot;xxxx&quot;,      &quot;service&quot;: &quot;DTRooms.Meeting&quot;,      &quot;method&quot;: &quot;subscribe&quot;    } }</para>
        /// </summary>
        [NameInMap("controlBody")]
        [Validation(Required=false)]
        public string ControlBody { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0ffb7xxxxx</para>
        /// </summary>
        [NameInMap("roomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
