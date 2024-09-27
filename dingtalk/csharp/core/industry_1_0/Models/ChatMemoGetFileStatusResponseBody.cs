// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatMemoGetFileStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>待处理</para>
        /// </summary>
        [NameInMap("statusDesc")]
        [Validation(Required=false)]
        public string StatusDesc { get; set; }

    }

}
