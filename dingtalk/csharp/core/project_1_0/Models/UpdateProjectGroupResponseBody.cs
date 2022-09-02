// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateProjectGroupResponseBody : TeaModel {
        /// <summary>
        /// 结果对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateProjectGroupResponseBodyResult Result { get; set; }
        public class UpdateProjectGroupResponseBodyResult : TeaModel {
            /// <summary>
            /// 是否成功
            /// </summary>
            [NameInMap("ok")]
            [Validation(Required=false)]
            public bool? Ok { get; set; }

        }

    }

}
