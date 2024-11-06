// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumGrantProcessInstanceForDownloadFileResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PremiumGrantProcessInstanceForDownloadFileResponseBodyResult Result { get; set; }
        public class PremiumGrantProcessInstanceForDownloadFileResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://lippi-space-zjk.oss-cn-zhangjiakou.aliyuncs.com/xxxxx">http://lippi-space-zjk.oss-cn-zhangjiakou.aliyuncs.com/xxxxx</a></para>
            /// </summary>
            [NameInMap("downloadUri")]
            [Validation(Required=false)]
            public string DownloadUri { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>26748422566</para>
            /// </summary>
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

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
