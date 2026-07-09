// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class GetFileDownloadUrlResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetFileDownloadUrlResponseBodyResult Result { get; set; }
        public class GetFileDownloadUrlResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public GetFileDownloadUrlResponseBodyResultData Data { get; set; }
            public class GetFileDownloadUrlResponseBodyResultData : TeaModel {
                [NameInMap("attachment")]
                [Validation(Required=false)]
                public List<GetFileDownloadUrlResponseBodyResultDataAttachment> Attachment { get; set; }
                public class GetFileDownloadUrlResponseBodyResultDataAttachment : TeaModel {
                    [NameInMap("downloadUrl")]
                    [Validation(Required=false)]
                    public string DownloadUrl { get; set; }

                    [NameInMap("fileId")]
                    [Validation(Required=false)]
                    public string FileId { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }

                    [NameInMap("urlExpireTime")]
                    [Validation(Required=false)]
                    public long? UrlExpireTime { get; set; }

                }

                [NameInMap("signDocs")]
                [Validation(Required=false)]
                public List<GetFileDownloadUrlResponseBodyResultDataSignDocs> SignDocs { get; set; }
                public class GetFileDownloadUrlResponseBodyResultDataSignDocs : TeaModel {
                    [NameInMap("downloadUrl")]
                    [Validation(Required=false)]
                    public string DownloadUrl { get; set; }

                    [NameInMap("fileId")]
                    [Validation(Required=false)]
                    public string FileId { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }

                    [NameInMap("urlExpireTime")]
                    [Validation(Required=false)]
                    public long? UrlExpireTime { get; set; }

                }

                [NameInMap("signFlowId")]
                [Validation(Required=false)]
                public string SignFlowId { get; set; }

            }

            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
