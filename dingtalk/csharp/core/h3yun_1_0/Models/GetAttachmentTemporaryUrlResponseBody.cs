// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetAttachmentTemporaryUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAttachmentTemporaryUrlResponseBodyData Data { get; set; }
        public class GetAttachmentTemporaryUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://h3yun-infrastructure.oss-cn-shenzhen.aliyuncs.com/mi4x54jcr54b0p8hwoad4wxo3/Formal/D000183te0qsxc20pulavqhgv8sky2p1/F0000041/21a42cb3-f679-4206-8314-597a59a7fd7a/01a27595-53ba-406f-8f39-cd31d99435d8?Expires=1641113859&OSSAccessKeyId=LTAI4G6TouCWDLHSHpAsM1eq&Signature=6FBbQbHMt7lrwi6wX1EsEo0Kr84%3D">http://h3yun-infrastructure.oss-cn-shenzhen.aliyuncs.com/mi4x54jcr54b0p8hwoad4wxo3/Formal/D000183te0qsxc20pulavqhgv8sky2p1/F0000041/21a42cb3-f679-4206-8314-597a59a7fd7a/01a27595-53ba-406f-8f39-cd31d99435d8?Expires=1641113859&amp;OSSAccessKeyId=LTAI4G6TouCWDLHSHpAsM1eq&amp;Signature=6FBbQbHMt7lrwi6wX1EsEo0Kr84%3D</a></para>
            /// </summary>
            [NameInMap("attachmentUrl")]
            [Validation(Required=false)]
            public string AttachmentUrl { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
