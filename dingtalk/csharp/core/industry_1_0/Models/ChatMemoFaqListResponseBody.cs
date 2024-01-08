// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatMemoFaqListResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ChatMemoFaqListResponseBodyData> Data { get; set; }
        public class ChatMemoFaqListResponseBodyData : TeaModel {
            [NameInMap("answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            [NameInMap("redirection")]
            [Validation(Required=false)]
            public string Redirection { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
