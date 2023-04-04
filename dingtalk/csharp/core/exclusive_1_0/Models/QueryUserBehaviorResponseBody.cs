// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class QueryUserBehaviorResponseBody : TeaModel {
        /// <summary>
        /// 数据列表
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryUserBehaviorResponseBodyData> Data { get; set; }
        public class QueryUserBehaviorResponseBodyData : TeaModel {
            [NameInMap("pictureUrl")]
            [Validation(Required=false)]
            public string PictureUrl { get; set; }

            [NameInMap("platform")]
            [Validation(Required=false)]
            public int? Platform { get; set; }

            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("dataCnt")]
        [Validation(Required=false)]
        public int? DataCnt { get; set; }

        [NameInMap("totalCnt")]
        [Validation(Required=false)]
        public int? TotalCnt { get; set; }

    }

}
