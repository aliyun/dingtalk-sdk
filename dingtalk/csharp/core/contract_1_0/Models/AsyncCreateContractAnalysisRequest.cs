// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class AsyncCreateContractAnalysisRequest : TeaModel {
        [NameInMap("fileInfo")]
        [Validation(Required=false)]
        public AsyncCreateContractAnalysisRequestFileInfo FileInfo { get; set; }
        public class AsyncCreateContractAnalysisRequestFileInfo : TeaModel {
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

        }

        [NameInMap("originatorUserId")]
        [Validation(Required=false)]
        public string OriginatorUserId { get; set; }

    }

}
