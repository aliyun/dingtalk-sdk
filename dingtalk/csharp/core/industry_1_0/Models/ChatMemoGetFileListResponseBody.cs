// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatMemoGetFileListResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ChatMemoGetFileListResponseBodyData> Data { get; set; }
        public class ChatMemoGetFileListResponseBodyData : TeaModel {
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("fileDesc")]
            [Validation(Required=false)]
            public string FileDesc { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("tagMap")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> TagMap { get; set; }

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
