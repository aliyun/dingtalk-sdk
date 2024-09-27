// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class AttendanceBleDevicesQueryRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62001E1C5B9XXXX369D316DED25FXXXX</para>
        /// </summary>
        [NameInMap("groupKey")]
        [Validation(Required=false)]
        public string GroupKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>userId001</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
