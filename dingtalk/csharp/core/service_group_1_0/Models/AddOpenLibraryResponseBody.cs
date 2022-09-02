// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class AddOpenLibraryResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public AddOpenLibraryResponseBodyResult Result { get; set; }
        public class AddOpenLibraryResponseBodyResult : TeaModel {
            /// <summary>
            /// 知识库ID
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 失败时错误消息
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// 添加/修改知识库是否成功
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
