// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateTaskObjectLinkResponseBody : TeaModel {
        /// <summary>
        /// 返回结果对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateTaskObjectLinkResponseBodyResult Result { get; set; }
        public class CreateTaskObjectLinkResponseBodyResult : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// 关联对象id
            /// </summary>
            [NameInMap("objectLinkId")]
            [Validation(Required=false)]
            public string ObjectLinkId { get; set; }

        }

    }

}
