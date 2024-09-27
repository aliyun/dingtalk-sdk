// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class RemoveSuperUserMeetingRoomRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed</para>
        /// </summary>
        [NameInMap("roomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
