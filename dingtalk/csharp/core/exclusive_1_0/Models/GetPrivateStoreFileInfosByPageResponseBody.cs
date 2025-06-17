// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetPrivateStoreFileInfosByPageResponseBody : TeaModel {
        [NameInMap("fileInfos")]
        [Validation(Required=false)]
        public List<GetPrivateStoreFileInfosByPageResponseBodyFileInfos> FileInfos { get; set; }
        public class GetPrivateStoreFileInfosByPageResponseBodyFileInfos : TeaModel {
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public long? DentryId { get; set; }

            [NameInMap("fileCreateTime")]
            [Validation(Required=false)]
            public long? FileCreateTime { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("filePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public long? SpaceId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
