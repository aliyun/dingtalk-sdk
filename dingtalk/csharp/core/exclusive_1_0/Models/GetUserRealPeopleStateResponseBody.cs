// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetUserRealPeopleStateResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetUserRealPeopleStateResponseBodyData> Data { get; set; }
        public class GetUserRealPeopleStateResponseBodyData : TeaModel {
            /// <summary>
            /// 认证状态 1-未认证 2-已认证
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public int? State { get; set; }

            /// <summary>
            /// userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
