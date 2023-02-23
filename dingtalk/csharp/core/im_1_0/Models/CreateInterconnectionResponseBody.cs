// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateInterconnectionResponseBody : TeaModel {
        /// <summary>
        /// 创建失败的钉外账号列表。
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<CreateInterconnectionResponseBodyResults> Results { get; set; }
        public class CreateInterconnectionResponseBodyResults : TeaModel {
            /// <summary>
            /// 钉外账号在业务系统内的唯一标识。
            /// </summary>
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            /// <summary>
            /// 失败原因。
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// 该钉外账号被哪个钉内账号负责。
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
