// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class UploadContractReviewByUrlRequest : TeaModel {
        [NameInMap("file_url")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        [NameInMap("filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
