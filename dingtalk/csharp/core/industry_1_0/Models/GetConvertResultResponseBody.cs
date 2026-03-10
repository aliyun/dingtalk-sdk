// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class GetConvertResultResponseBody : TeaModel {
        [NameInMap("dingOpenErrcode")]
        [Validation(Required=false)]
        public long? DingOpenErrcode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetConvertResultResponseBodyResult Result { get; set; }
        public class GetConvertResultResponseBodyResult : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public float? CreateTime { get; set; }

            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            [NameInMap("outputInfo")]
            [Validation(Required=false)]
            public GetConvertResultResponseBodyResultOutputInfo OutputInfo { get; set; }
            public class GetConvertResultResponseBodyResultOutputInfo : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public float? FileSize { get; set; }

                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("fileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taskBizId")]
            [Validation(Required=false)]
            public string TaskBizId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
