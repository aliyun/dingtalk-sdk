// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateInterconnectionResponseBody : TeaModel {
        /// <summary>
        /// 创建失败的钉外钉内关系列表。
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<CreateInterconnectionResponseBodyResults> Results { get; set; }
        public class CreateInterconnectionResponseBodyResults : TeaModel {
            /// <summary>
            /// 钉外用户在业务系统内的唯一标识。
            /// </summary>
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            /// <summary>
            /// 钉内用户userId。
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
