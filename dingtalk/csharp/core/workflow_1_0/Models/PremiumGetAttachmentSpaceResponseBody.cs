// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumGetAttachmentSpaceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PremiumGetAttachmentSpaceResponseBodyResult Result { get; set; }
        public class PremiumGetAttachmentSpaceResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3996960664</para>
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public long? SpaceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
