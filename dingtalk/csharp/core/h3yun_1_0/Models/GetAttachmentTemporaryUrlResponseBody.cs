// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetAttachmentTemporaryUrlResponseBody : TeaModel {
        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 业务响应结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAttachmentTemporaryUrlResponseBodyData Data { get; set; }
        public class GetAttachmentTemporaryUrlResponseBodyData : TeaModel {
            [NameInMap("attachmentUrl")]
            [Validation(Required=false)]
            public string AttachmentUrl { get; set; }
        };

        /// <summary>
        /// 提示信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
