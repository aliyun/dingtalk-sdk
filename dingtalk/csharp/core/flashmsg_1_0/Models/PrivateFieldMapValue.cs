// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmsg_1_0.Models
{
    public class PrivateFieldMapValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>XXX发了一条闪读消息，请于今天 12:00前查看</para>
        /// </summary>
        [NameInMap("tipTitle")]
        [Validation(Required=false)]
        public string TipTitle { get; set; }

        [NameInMap("isDingSend")]
        [Validation(Required=false)]
        public bool? IsDingSend { get; set; }

        [NameInMap("isRead")]
        [Validation(Required=false)]
        public bool? IsRead { get; set; }

        [NameInMap("buttonStatus")]
        [Validation(Required=false)]
        public string ButtonStatus { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

    }

}
