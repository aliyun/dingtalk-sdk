// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ShareUrlResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>shareUrlInfo</para>
        /// </summary>
        [NameInMap("shareUrlInfo")]
        [Validation(Required=false)]
        public ShareUrlResponseBodyShareUrlInfo ShareUrlInfo { get; set; }
        public class ShareUrlResponseBodyShareUrlInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://example.com">http://example.com</a></para>
            /// </summary>
            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://example.com">http://example.com</a></para>
            /// </summary>
            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

        }

    }

}
