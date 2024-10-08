// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class SetSuperUserMeetingRoomRequest : TeaModel {
        [NameInMap("deptIdWhiteList")]
        [Validation(Required=false)]
        public List<long?> DeptIdWhiteList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("roomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OcMXXXXXM2eRogiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        [NameInMap("userIdWhiteList")]
        [Validation(Required=false)]
        public List<string> UserIdWhiteList { get; set; }

    }

}
