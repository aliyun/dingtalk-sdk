// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateInterconnectionResponseBody : TeaModel {
        /// <summary>
        /// 失败的bc关系列表
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<CreateInterconnectionResponseBodyResults> Results { get; set; }
        public class CreateInterconnectionResponseBodyResults : TeaModel {
            /// <summary>
            /// 客户业务身份唯一标识
            /// </summary>
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            /// <summary>
            /// 客服钉钉Id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
