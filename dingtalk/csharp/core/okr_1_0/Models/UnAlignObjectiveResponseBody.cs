// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UnAlignObjectiveResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public UnAlignObjectiveResponseBodyData Data { get; set; }
        public class UnAlignObjectiveResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>59YD</para>
            /// </summary>
            [NameInMap("alignId")]
            [Validation(Required=false)]
            public Stream AlignId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5dAX8</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public Stream Id { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
