// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetUploadUrlResponseBody : TeaModel {
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
        public GetUploadUrlResponseBodyData Data { get; set; }
        public class GetUploadUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>https://<em><b>?uploadSecret=</b></em></para>
            /// </summary>
            [NameInMap("uploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }

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
